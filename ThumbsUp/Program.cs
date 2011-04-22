using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Drawing2D;
using System.Reflection;

static class Program
{
    public static string AppName = "ThumbsUp!";
    public static Version AppVersion = Assembly.GetExecutingAssembly().GetName().Version;
    //Zero based for arrays
    public static int ProcessorCount = Environment.ProcessorCount;

    [STAThread]
    static void Main()
    {
        //I guess these two lines are important now?
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new frmMain());
    }

    public static void ShowMessageBox(string message)
    {
        MessageBox.Show(message, Program.AppName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
        return;
    }

    public static void ShowErrorBox(string message)
    {
        MessageBox.Show(message, Program.AppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        return;
    }

    public static bool ShowQuestionBox(string message)
    {
        DialogResult result = new DialogResult();
        result = MessageBox.Show(message, Program.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        if (result == DialogResult.Yes)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static string[] LoadImages(string path)
    {
        List<string> imgList = new List<string>();
        string ext = "";

        string[] files = Directory.GetFiles(path);
        foreach (string file in files)
        {
            ext = Path.GetExtension(file).ToUpper();
            if (ext == ".PNG"
                || ext == ".JPG"
                || ext == ".BMP"
                || ext == ".JPEG"
                || ext == ".GIF")
            {
                imgList.Add(file);
            }
        }

        return imgList.ToArray();
    }

    //Stolen from:
    //http://www.peterprovost.org/blog/post/Resize-Image-in-C.aspx
    //This code leaks memory! Passing by reference may fix this?
    //ResizeBitmap(ref Bitmap b, Rectangle rect)
    public static Bitmap ResizeBitmap(Bitmap b, Rectangle rect)
    {
        Bitmap result = new Bitmap(rect.Width, rect.Height);
        using (Graphics g = Graphics.FromImage((Image)result))
        {
            //These lines enforce high quality resizes. Sacrifices some speed, but I prefer image quality.
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            //This line does the actual resize.
            g.DrawImage(b, 0, 0, rect.Width, rect.Height);
        }
        return result;
    }

    public static Rectangle ResizeAspect(int height, int width, 
        int maxHeight, int maxWidth, double percentage, 
        bool keepAspect, bool stretch)
    {
        //Defaults
        Rectangle rect = new Rectangle();
        rect.Height = height;
        rect.Width = width;
        double ratio = 0;

        if (percentage > 0) //We are doing a percentage resize
        {
            rect.Height = (int)(height * (percentage / 100));
            rect.Width = (int)(width * (percentage / 100));
        }
        else if (!keepAspect) //Boxed resize
        {
            if (maxWidth > 0 && width > maxWidth)
                rect.Width = maxWidth;
            if (maxHeight > 0 && height > maxHeight)
                rect.Height = maxHeight;

            if (stretch)
            {
                if (maxWidth > 0)
                    rect.Width = maxWidth;
                if (maxHeight > 0)
                    rect.Height = maxHeight;
            }
        }
        else //We are doing a normal resize
        {
            if (stretch) //Stretch
            {
                if (height > width) //Taller than wide
                {
                    if (maxHeight > 0)
                    {
                        ratio = (double)width / (double)height;
                        rect.Height = maxHeight;
                        rect.Width = (int)(maxHeight * ratio);
                    }
                    else if (maxWidth > 0)
                    {
                        ratio = (double)height / (double)width;
                        rect.Width = maxWidth;
                        rect.Height = (int)(maxWidth * ratio);
                    }
                }
                else //Wider than tall
                {
                    if (maxWidth > 0)
                    {
                        ratio = (double)height / (double)width;
                        rect.Width = maxWidth;
                        rect.Height = (int)(maxWidth * ratio);
                    }
                    else if (maxHeight > 0)
                    {
                        ratio = (double)width / (double)height;
                        rect.Height = maxHeight;
                        rect.Width = (int)(maxHeight * ratio);
                    }
                }
            }
            else //No stretch
            {
                if (height > width) //Taller than wide
                {
                    if (maxHeight > 0 && height > maxHeight)
                    {
                        ratio = (double)width / (double)height;
                        rect.Height = maxHeight;
                        rect.Width = (int)(maxHeight * ratio);
                    }
                    else if (maxWidth > 0 && width > maxWidth)
                    {
                        ratio = (double)height / (double)width;
                        rect.Width = maxWidth;
                        rect.Height = (int)(maxWidth * ratio);
                    }
                }
                else //Wider than tall
                {
                    ratio = (double)height / (double)width;
                    if (maxWidth > 0 && width > maxWidth)
                    {
                        ratio = (double)height / (double)width;
                        rect.Width = maxWidth;
                        rect.Height = (int)(maxWidth * ratio);
                    }
                    else if (maxHeight > 0 && height > maxHeight)
                    {
                        ratio = (double)width / (double)height;
                        rect.Height = maxHeight;
                        rect.Width = (int)(maxHeight * ratio);
                    }
                }
            }
        }

        //Final checking... must be at least 1x1
        if (rect.Width == 0)
            rect.Width = 1;
        if (rect.Height == 0)
            rect.Height = 1;

        int upperConstraint = 8000;
        //And not TOO large...
        if (rect.Width > upperConstraint)
            rect.Width = upperConstraint;
        if (rect.Height > upperConstraint)
            rect.Height = upperConstraint;

        return rect;
    }

    public static System.Drawing.Imaging.ImageFormat GetImageFormat(string filename)
    {
        string ext = Path.GetExtension(filename).ToUpper();
        switch (ext)
        {
            case ".JPG":
                return System.Drawing.Imaging.ImageFormat.Jpeg;
            case ".JPEG":
                return System.Drawing.Imaging.ImageFormat.Jpeg;
            case ".PNG":
                return System.Drawing.Imaging.ImageFormat.Png;
            case ".GIF":
                return System.Drawing.Imaging.ImageFormat.Gif;
            case ".BMP":
                return System.Drawing.Imaging.ImageFormat.Bmp;
            default:
                return System.Drawing.Imaging.ImageFormat.Jpeg;
        }
    }
}