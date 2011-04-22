partial class frmProcess
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
        this.components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcess));
        this.lblProcessing = new System.Windows.Forms.Label();
        this.pgbStatusBar = new System.Windows.Forms.ProgressBar();
        this.lblElapsedTime = new System.Windows.Forms.Label();
        this.btnCancel = new System.Windows.Forms.Button();
        this.lblProcessTime = new System.Windows.Forms.Label();
        this.tmrStatus = new System.Windows.Forms.Timer(this.components);
        this.SuspendLayout();
        // 
        // lblProcessing
        // 
        this.lblProcessing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblProcessing.Location = new System.Drawing.Point(12, 9);
        this.lblProcessing.Name = "lblProcessing";
        this.lblProcessing.Size = new System.Drawing.Size(347, 29);
        this.lblProcessing.TabIndex = 1;
        this.lblProcessing.Text = "Starting process...";
        // 
        // pgbStatusBar
        // 
        this.pgbStatusBar.Location = new System.Drawing.Point(12, 41);
        this.pgbStatusBar.Name = "pgbStatusBar";
        this.pgbStatusBar.Size = new System.Drawing.Size(347, 23);
        this.pgbStatusBar.TabIndex = 2;
        // 
        // lblElapsedTime
        // 
        this.lblElapsedTime.Location = new System.Drawing.Point(12, 67);
        this.lblElapsedTime.Name = "lblElapsedTime";
        this.lblElapsedTime.Size = new System.Drawing.Size(76, 20);
        this.lblElapsedTime.TabIndex = 3;
        this.lblElapsedTime.Text = "Elapsed Time:";
        // 
        // btnCancel
        // 
        this.btnCancel.Location = new System.Drawing.Point(284, 90);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new System.Drawing.Size(75, 23);
        this.btnCancel.TabIndex = 4;
        this.btnCancel.Text = "C&ancel";
        this.btnCancel.UseVisualStyleBackColor = true;
        this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
        // 
        // lblProcessTime
        // 
        this.lblProcessTime.AutoSize = true;
        this.lblProcessTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblProcessTime.Location = new System.Drawing.Point(95, 67);
        this.lblProcessTime.Name = "lblProcessTime";
        this.lblProcessTime.Size = new System.Drawing.Size(73, 13);
        this.lblProcessTime.TabIndex = 5;
        this.lblProcessTime.Text = "Preparing...";
        // 
        // tmrStatus
        // 
        this.tmrStatus.Interval = 500;
        this.tmrStatus.Tick += new System.EventHandler(this.tmrStatus_Tick);
        // 
        // frmProcess
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(371, 118);
        this.Controls.Add(this.lblProcessTime);
        this.Controls.Add(this.btnCancel);
        this.Controls.Add(this.lblElapsedTime);
        this.Controls.Add(this.pgbStatusBar);
        this.Controls.Add(this.lblProcessing);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "frmProcess";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Processing Images...";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProcess_FormClosing);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblProcessing;
    private System.Windows.Forms.ProgressBar pgbStatusBar;
    private System.Windows.Forms.Label lblElapsedTime;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Label lblProcessTime;
    private System.Windows.Forms.Timer tmrStatus;
}