using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Drawing.Drawing2D;

public partial class frmProcess : Form
{
    private string mImagePath = "";
    private string mThumbPath = "";
    private string[] mImagePaths;

    private int mMaxWidth = 1280;
    private int mMaxHeight = 1280;
    private double mPercentage = 100;
    private bool mKeepAspect = true;
    private bool mStretch = false;
    private string mPrefix = "";

    private DateTime mStartTime;
    private int mImagesProcessed = 0;
    private int mTotalImages = 0;

    private BackgroundWorker mThreadController;
    private int mThreadCount;
    private int mThreadsRunning = 0;
    private EventHandler mInterfaceDelegate = null;
    private bool SpecialClosing = false;

    public frmProcess(string sourceDir, string destDir, int maxWidth, int maxHeight,
        double percentage, string prefix, bool keepAspect, bool stretch, int threadCount)
    {
        InitializeComponent();

        mImagePath = sourceDir;
        mThumbPath = destDir;

        mMaxWidth = maxWidth;
        mMaxHeight = maxHeight;
        mPercentage = percentage;
        mKeepAspect = keepAspect;
        mStretch = stretch;
        mPrefix = prefix;
        mThreadCount = threadCount;

        mImagePaths = Program.LoadImages(mImagePath);
        mTotalImages = mImagePaths.Length;

        //Status bar...
        pgbStatusBar.Maximum = mTotalImages;
        mStartTime = DateTime.Now;

        //Get our delegate ready...
        mInterfaceDelegate = new EventHandler(UpdateStatus);

        //Fire up the threads!
        mThreadController = new BackgroundWorker();
        mThreadController.DoWork += new DoWorkEventHandler(ControllerStart);
        mThreadController.RunWorkerCompleted += new RunWorkerCompletedEventHandler(ControllerCompleted);
        mThreadController.WorkerSupportsCancellation = true;
        mThreadController.RunWorkerAsync();

        //Start ticking...
        tmrStatus.Start();
    }

    private void UpdateStatus(object sender, EventArgs e)
    {
        lblProcessing.Text = "Processing Image " + mImagesProcessed + " of " + mTotalImages + "...";
        this.Text = lblProcessing.Text;

        pgbStatusBar.Value = mImagesProcessed;
    }

    private void tmrStatus_Tick(object sender, EventArgs e)
    {
        TimeSpan ts = DateTime.Now.Subtract(mStartTime);
        lblProcessTime.Text = ts.Hours + "h " + ts.Minutes + "m " + ts.Seconds + "s";
    }

    private void ControllerStart(object sender, DoWorkEventArgs e)
    {
        for (int i = 0; i < mImagePaths.Length; i++)
        {
            while (mThreadsRunning >= mThreadCount && e.Cancel == false)
                Thread.Sleep(50); //Wait for a thread to open up...
            if (mThreadController.CancellationPending == true)
                return;
            BackgroundWorker imageProcessor = new BackgroundWorker();
            imageProcessor.DoWork += new DoWorkEventHandler(processImage);
            imageProcessor.RunWorkerCompleted += new RunWorkerCompletedEventHandler(processImageCompleted);
            imageProcessor.RunWorkerAsync(i);
            mThreadsRunning++;
        }

        //Put this waiting instance here so that we don't lockup the main thread...
        while (mImagesProcessed < mImagePaths.Length)
            Thread.Sleep(50); //Wait for all threads to finish...
    }

    private void ControllerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
        this.SpecialClose(); //Close the form when we are completed!
    }

    private void processImage(object sender, DoWorkEventArgs e)
    {
        int indexToProcess = (int)e.Argument; //Grab the image index # from the argument...

        Bitmap bmp = null;
        Bitmap newBmp = null;
        Rectangle rect;
        string file = "";
        try
        {
            file = mImagePaths[indexToProcess];
            //Load
            bmp = new Bitmap(file);

            //Resize Operation
            rect = Program.ResizeAspect(bmp.Height, bmp.Width, mMaxHeight, mMaxWidth, mPercentage, mKeepAspect, mStretch);
            newBmp = new Bitmap(rect.Width, rect.Height);
            using (Graphics g = Graphics.FromImage((Image)newBmp))
            {
                //Quality settings!
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                g.DrawImage(bmp, 0, 0, rect.Width, rect.Height);
                g.Dispose();
            }

            //Save
            newBmp.Save(Path.Combine(mThumbPath, mPrefix + Path.GetFileName(file)), Program.GetImageFormat(file));

            //Cleanup (This is necessary to prevent memory leaks)
            bmp.Dispose();
            newBmp.Dispose();

            //Increment!
            mImagesProcessed++;

            //Pump for an update
            try
            {
                this.Invoke(mInterfaceDelegate);
            }
            catch(Exception ex)
            {
                string temp = ex.Message + "";
            }
        }
        catch (Exception)
        {
            try
            {
                //Cleanup (This is necessary to prevent memory leaks)
                if (bmp != null)
                    bmp.Dispose();
                if (newBmp != null)
                    newBmp.Dispose();
                this.Invoke(mInterfaceDelegate);
            }
            catch { }
        }
    }

    void processImageCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
        mThreadsRunning--;
    }

    private void frmProcess_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (!SpecialClosing)
        {
            e.Cancel = true;
            return;
        }
        //Garbage collect to cleanup memory, finally.
        GC.Collect();
    }

    private void SpecialClose()
    {
        SpecialClosing = true;
        this.Close();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        mThreadController.CancelAsync();
    }
}