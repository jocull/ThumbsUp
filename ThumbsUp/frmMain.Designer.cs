partial class frmMain
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
        this.label1 = new System.Windows.Forms.Label();
        this.txtSource = new System.Windows.Forms.TextBox();
        this.btnBrowseSource = new System.Windows.Forms.Button();
        this.btnBrowseDestination = new System.Windows.Forms.Button();
        this.txtDestination = new System.Windows.Forms.TextBox();
        this.label2 = new System.Windows.Forms.Label();
        this.btnResize = new System.Windows.Forms.Button();
        this.label3 = new System.Windows.Forms.Label();
        this.txtMaxHeight = new System.Windows.Forms.TextBox();
        this.txtMaxWidth = new System.Windows.Forms.TextBox();
        this.label4 = new System.Windows.Forms.Label();
        this.lblFileCount = new System.Windows.Forms.Label();
        this.txtPercentage = new System.Windows.Forms.TextBox();
        this.label6 = new System.Windows.Forms.Label();
        this.chkKeepAspect = new System.Windows.Forms.CheckBox();
        this.btnExit = new System.Windows.Forms.Button();
        this.trkThreadCount = new System.Windows.Forms.TrackBar();
        this.label7 = new System.Windows.Forms.Label();
        this.lblThreads = new System.Windows.Forms.Label();
        this.txtPrefix = new System.Windows.Forms.TextBox();
        this.label5 = new System.Windows.Forms.Label();
        this.chkStretch = new System.Windows.Forms.CheckBox();
        ((System.ComponentModel.ISupportInitialize)(this.trkThreadCount)).BeginInit();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(10, 9);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(76, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "Source Folder:";
        // 
        // txtSource
        // 
        this.txtSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.txtSource.Location = new System.Drawing.Point(13, 30);
        this.txtSource.Name = "txtSource";
        this.txtSource.ReadOnly = true;
        this.txtSource.Size = new System.Drawing.Size(238, 20);
        this.txtSource.TabIndex = 1;
        // 
        // btnBrowseSource
        // 
        this.btnBrowseSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnBrowseSource.Location = new System.Drawing.Point(257, 28);
        this.btnBrowseSource.Name = "btnBrowseSource";
        this.btnBrowseSource.Size = new System.Drawing.Size(75, 23);
        this.btnBrowseSource.TabIndex = 2;
        this.btnBrowseSource.Text = "Browse...";
        this.btnBrowseSource.UseVisualStyleBackColor = true;
        this.btnBrowseSource.Click += new System.EventHandler(this.btnBrowseSource_Click);
        // 
        // btnBrowseDestination
        // 
        this.btnBrowseDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnBrowseDestination.Location = new System.Drawing.Point(257, 68);
        this.btnBrowseDestination.Name = "btnBrowseDestination";
        this.btnBrowseDestination.Size = new System.Drawing.Size(75, 23);
        this.btnBrowseDestination.TabIndex = 5;
        this.btnBrowseDestination.Text = "Browse...";
        this.btnBrowseDestination.UseVisualStyleBackColor = true;
        this.btnBrowseDestination.Click += new System.EventHandler(this.btnBrowseDestination_Click);
        // 
        // txtDestination
        // 
        this.txtDestination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.txtDestination.Location = new System.Drawing.Point(13, 70);
        this.txtDestination.Name = "txtDestination";
        this.txtDestination.ReadOnly = true;
        this.txtDestination.Size = new System.Drawing.Size(238, 20);
        this.txtDestination.TabIndex = 4;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(10, 54);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(95, 13);
        this.label2.TabIndex = 3;
        this.label2.Text = "Destination Folder:";
        // 
        // btnResize
        // 
        this.btnResize.Location = new System.Drawing.Point(16, 161);
        this.btnResize.Name = "btnResize";
        this.btnResize.Size = new System.Drawing.Size(75, 23);
        this.btnResize.TabIndex = 14;
        this.btnResize.Text = "&Resize!";
        this.btnResize.UseVisualStyleBackColor = true;
        this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(80, 98);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(61, 13);
        this.label3.TabIndex = 7;
        this.label3.Text = "Max Width:";
        // 
        // txtMaxHeight
        // 
        this.txtMaxHeight.Location = new System.Drawing.Point(16, 114);
        this.txtMaxHeight.MaxLength = 4;
        this.txtMaxHeight.Name = "txtMaxHeight";
        this.txtMaxHeight.Size = new System.Drawing.Size(58, 20);
        this.txtMaxHeight.TabIndex = 8;
        this.txtMaxHeight.Text = "50";
        // 
        // txtMaxWidth
        // 
        this.txtMaxWidth.Location = new System.Drawing.Point(83, 114);
        this.txtMaxWidth.MaxLength = 4;
        this.txtMaxWidth.Name = "txtMaxWidth";
        this.txtMaxWidth.Size = new System.Drawing.Size(58, 20);
        this.txtMaxWidth.TabIndex = 9;
        this.txtMaxWidth.Text = "50";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(13, 98);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(64, 13);
        this.label4.TabIndex = 9;
        this.label4.Text = "Max Height:";
        // 
        // lblFileCount
        // 
        this.lblFileCount.AutoSize = true;
        this.lblFileCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblFileCount.Location = new System.Drawing.Point(92, 9);
        this.lblFileCount.Name = "lblFileCount";
        this.lblFileCount.Size = new System.Drawing.Size(53, 13);
        this.lblFileCount.TabIndex = 11;
        this.lblFileCount.Text = "No Files";
        // 
        // txtPercentage
        // 
        this.txtPercentage.Location = new System.Drawing.Point(150, 114);
        this.txtPercentage.MaxLength = 4;
        this.txtPercentage.Name = "txtPercentage";
        this.txtPercentage.Size = new System.Drawing.Size(58, 20);
        this.txtPercentage.TabIndex = 10;
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Location = new System.Drawing.Point(147, 98);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(68, 13);
        this.label6.TabIndex = 12;
        this.label6.Text = "% of Original:";
        // 
        // chkKeepAspect
        // 
        this.chkKeepAspect.AutoSize = true;
        this.chkKeepAspect.Checked = true;
        this.chkKeepAspect.CheckState = System.Windows.Forms.CheckState.Checked;
        this.chkKeepAspect.Location = new System.Drawing.Point(16, 140);
        this.chkKeepAspect.Name = "chkKeepAspect";
        this.chkKeepAspect.Size = new System.Drawing.Size(79, 17);
        this.chkKeepAspect.TabIndex = 12;
        this.chkKeepAspect.Text = "Keep Ratio";
        this.chkKeepAspect.UseVisualStyleBackColor = true;
        // 
        // btnExit
        // 
        this.btnExit.Location = new System.Drawing.Point(97, 161);
        this.btnExit.Name = "btnExit";
        this.btnExit.Size = new System.Drawing.Size(75, 23);
        this.btnExit.TabIndex = 15;
        this.btnExit.Text = "E&xit";
        this.btnExit.UseVisualStyleBackColor = true;
        this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
        // 
        // trkThreadCount
        // 
        this.trkThreadCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.trkThreadCount.Location = new System.Drawing.Point(178, 161);
        this.trkThreadCount.Maximum = 16;
        this.trkThreadCount.Minimum = 1;
        this.trkThreadCount.Name = "trkThreadCount";
        this.trkThreadCount.Size = new System.Drawing.Size(154, 45);
        this.trkThreadCount.TabIndex = 16;
        this.trkThreadCount.Value = 2;
        this.trkThreadCount.ValueChanged += new System.EventHandler(this.trkThreadCount_ValueChanged);
        // 
        // label7
        // 
        this.label7.AutoSize = true;
        this.label7.Location = new System.Drawing.Point(178, 142);
        this.label7.Name = "label7";
        this.label7.Size = new System.Drawing.Size(83, 13);
        this.label7.TabIndex = 18;
        this.label7.Text = "Threads to Use:";
        // 
        // lblThreads
        // 
        this.lblThreads.AutoSize = true;
        this.lblThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblThreads.Location = new System.Drawing.Point(267, 142);
        this.lblThreads.Name = "lblThreads";
        this.lblThreads.Size = new System.Drawing.Size(14, 13);
        this.lblThreads.TabIndex = 19;
        this.lblThreads.Text = "4";
        // 
        // txtPrefix
        // 
        this.txtPrefix.Location = new System.Drawing.Point(224, 114);
        this.txtPrefix.MaxLength = 50;
        this.txtPrefix.Name = "txtPrefix";
        this.txtPrefix.Size = new System.Drawing.Size(58, 20);
        this.txtPrefix.TabIndex = 11;
        this.txtPrefix.Text = "thumb-";
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point(221, 98);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(80, 13);
        this.label5.TabIndex = 21;
        this.label5.Text = "New File Prefix:";
        // 
        // chkStretch
        // 
        this.chkStretch.AutoSize = true;
        this.chkStretch.Location = new System.Drawing.Point(97, 140);
        this.chkStretch.Name = "chkStretch";
        this.chkStretch.Size = new System.Drawing.Size(60, 17);
        this.chkStretch.TabIndex = 13;
        this.chkStretch.Text = "Stretch";
        this.chkStretch.UseVisualStyleBackColor = true;
        // 
        // frmMain
        // 
        this.ClientSize = new System.Drawing.Size(344, 196);
        this.Controls.Add(this.chkStretch);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.txtPrefix);
        this.Controls.Add(this.lblThreads);
        this.Controls.Add(this.label7);
        this.Controls.Add(this.trkThreadCount);
        this.Controls.Add(this.btnExit);
        this.Controls.Add(this.chkKeepAspect);
        this.Controls.Add(this.txtPercentage);
        this.Controls.Add(this.label6);
        this.Controls.Add(this.lblFileCount);
        this.Controls.Add(this.txtMaxWidth);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.txtMaxHeight);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.btnResize);
        this.Controls.Add(this.btnBrowseDestination);
        this.Controls.Add(this.txtDestination);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.btnBrowseSource);
        this.Controls.Add(this.txtSource);
        this.Controls.Add(this.label1);
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.MinimumSize = new System.Drawing.Size(352, 230);
        this.Name = "frmMain";
        this.Text = "ThumbsUp!";
        ((System.ComponentModel.ISupportInitialize)(this.trkThreadCount)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtSource;
    private System.Windows.Forms.Button btnBrowseSource;
    private System.Windows.Forms.Button btnBrowseDestination;
    private System.Windows.Forms.TextBox txtDestination;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnResize;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtMaxHeight;
    private System.Windows.Forms.TextBox txtMaxWidth;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label lblFileCount;
    private System.Windows.Forms.TextBox txtPercentage;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.CheckBox chkKeepAspect;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.TrackBar trkThreadCount;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label lblThreads;
    private System.Windows.Forms.TextBox txtPrefix;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.CheckBox chkStretch;
}