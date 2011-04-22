using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

public partial class frmMain : Form
{
    public frmMain()
    {
        InitializeComponent();
        this.Text = Program.AppName + " - v" + Program.AppVersion.Major + "." + Program.AppVersion.Minor;
        
        //Get threading count ready
        trkThreadCount.Maximum = Program.ProcessorCount * 4;
        trkThreadCount.Value = Program.ProcessorCount;
        trkThreadCount_ValueChanged(null, null);
        
        //Wiring up textboxes to highlight on enter
        txtMaxHeight.Enter += new EventHandler(SelectTextForControl);
        txtMaxWidth.Enter += new EventHandler(SelectTextForControl);
        txtPercentage.Enter += new EventHandler(SelectTextForControl);
        txtPrefix.Enter += new EventHandler(SelectTextForControl);
    }

    private void trkThreadCount_ValueChanged(object sender, EventArgs e)
    {
        lblThreads.Text = trkThreadCount.Value.ToString();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void btnBrowseSource_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog f = new FolderBrowserDialog();
        
        f.SelectedPath = txtSource.Text;
        f.ShowDialog();
        if (f.SelectedPath != "") //Did user cancel?
        {
            txtSource.Text = f.SelectedPath;

            string s = "s";
            int count = Program.LoadImages(txtSource.Text).Length;
            if (count == 1)
                s = "";
            lblFileCount.Text = count + " Image" + s;

            if (count > 0)
                lblFileCount.ForeColor = Color.Green;
            else
                lblFileCount.ForeColor = Color.Red;
        }

        f.Dispose();
    }

    private void btnBrowseDestination_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog f = new FolderBrowserDialog();

        f.SelectedPath = txtDestination.Text;
        f.ShowDialog();
        if (f.SelectedPath != "") //Did user cancel?
            txtDestination.Text = f.SelectedPath;

        f.Dispose();
    }

    private void btnResize_Click(object sender, EventArgs e)
    {
        string errors = "";
        //Validate...
        if (!Directory.Exists(txtSource.Text))
            errors += "- A source directory is required.\n";
        if (!Directory.Exists(txtDestination.Text))
            errors += "- A destination directory is required.\n";
        if (txtSource.Text == txtDestination.Text)
            errors += "- Source and Destination directories cannot be the same.\n";

        int maxWidth = 0;
        int maxHeight = 0;
        double percentage = 0;

        if ((txtMaxWidth.Text.Trim() == "" && txtMaxHeight.Text.Trim() == "" && txtPercentage.Text.Trim() == "")
            || (txtMaxWidth.Text.Trim() != "" && txtMaxHeight.Text.Trim() != "" && txtPercentage.Text.Trim() != ""))
            errors += "- You must choose to use Max Width, Max Height, or Percentage.\n";
        else
        {
            if (txtMaxWidth.Text.Trim().Length > 0 && !int.TryParse(txtMaxWidth.Text, out maxWidth))
                errors += "- Max Width must be a valid positive number.\n";
            else if (txtMaxWidth.Text.Trim().Length > 0 && maxWidth <= 0)
                errors += "- Max Width must be a valid positive number.\n";

            if (txtMaxHeight.Text.Trim().Length > 0 && !int.TryParse(txtMaxHeight.Text, out maxHeight))
                errors += "- Max Height must be a valid positive number.\n";
            else if (txtMaxHeight.Text.Trim().Length > 0 && maxHeight <= 0)
                errors += "- Max Height must be a valid positive number.\n";

            if (txtPercentage.Text.Trim().Length > 0 && !double.TryParse(txtPercentage.Text, out percentage))
                errors += "- Percentage must be a valid positive number.\n";
            else if (txtPercentage.Text.Trim().Length > 0 && percentage <= 0)
                errors += "- Percentage must be a valid positive number.\n";
        }

        if (txtPrefix.Text.IndexOfAny(Path.GetInvalidFileNameChars()) > -1)
            errors += "- Prefix has characters that invalid for a file name.\n";

        if(Directory.Exists(txtSource.Text) && Program.LoadImages(txtSource.Text).Length == 0)
            errors += "- There are no images in the source folder.\n";

        //Got errors?
        if (errors.Length > 0)
        {
            Program.ShowMessageBox("There were some errors with your entry:\n\n" + errors);
            return;
        }

        //Open up the new form and go!
        frmProcess form = new frmProcess(txtSource.Text, txtDestination.Text, maxWidth, maxHeight,
            percentage, txtPrefix.Text, chkKeepAspect.Checked, chkStretch.Checked, trkThreadCount.Value);
        form.ShowDialog();

        form.Dispose();
    }

    private void SelectTextForControl(object sender, EventArgs e)
    {
        TextBox tb = (TextBox)sender;
        tb.SelectAll();
    }
}