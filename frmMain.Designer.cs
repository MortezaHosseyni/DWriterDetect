namespace DWriterDetect
{
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
            this.lbl_AppTitle = new System.Windows.Forms.Label();
            this.lbl_Programmer = new System.Windows.Forms.Label();
            this.txt_SavePath = new System.Windows.Forms.TextBox();
            this.lbl_SavePath = new System.Windows.Forms.Label();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.txt_SaveName = new System.Windows.Forms.TextBox();
            this.lbl_SaveName = new System.Windows.Forms.Label();
            this.sst_BottomBar = new System.Windows.Forms.StatusStrip();
            this.lbl_WriterStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctx_WriterStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.pgb_SaveProgress = new System.Windows.Forms.ProgressBar();
            this.sst_BottomBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_AppTitle
            // 
            this.lbl_AppTitle.AutoSize = true;
            this.lbl_AppTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_AppTitle.Location = new System.Drawing.Point(174, 25);
            this.lbl_AppTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_AppTitle.Name = "lbl_AppTitle";
            this.lbl_AppTitle.Size = new System.Drawing.Size(169, 29);
            this.lbl_AppTitle.TabIndex = 0;
            this.lbl_AppTitle.Text = "DWriter Detect";
            // 
            // lbl_Programmer
            // 
            this.lbl_Programmer.AutoSize = true;
            this.lbl_Programmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Programmer.Location = new System.Drawing.Point(256, 52);
            this.lbl_Programmer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Programmer.Name = "lbl_Programmer";
            this.lbl_Programmer.Size = new System.Drawing.Size(136, 17);
            this.lbl_Programmer.TabIndex = 0;
            this.lbl_Programmer.Text = "by Morteza Hosseini";
            // 
            // txt_SavePath
            // 
            this.txt_SavePath.Location = new System.Drawing.Point(113, 124);
            this.txt_SavePath.Name = "txt_SavePath";
            this.txt_SavePath.Size = new System.Drawing.Size(335, 29);
            this.txt_SavePath.TabIndex = 1;
            // 
            // lbl_SavePath
            // 
            this.lbl_SavePath.AutoSize = true;
            this.lbl_SavePath.Location = new System.Drawing.Point(13, 127);
            this.lbl_SavePath.Name = "lbl_SavePath";
            this.lbl_SavePath.Size = new System.Drawing.Size(94, 24);
            this.lbl_SavePath.TabIndex = 2;
            this.lbl_SavePath.Text = "Save Path";
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(454, 124);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(34, 29);
            this.btn_Browse.TabIndex = 3;
            this.btn_Browse.Text = "...";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // txt_SaveName
            // 
            this.txt_SaveName.Location = new System.Drawing.Point(113, 159);
            this.txt_SaveName.Name = "txt_SaveName";
            this.txt_SaveName.Size = new System.Drawing.Size(335, 29);
            this.txt_SaveName.TabIndex = 2;
            // 
            // lbl_SaveName
            // 
            this.lbl_SaveName.AutoSize = true;
            this.lbl_SaveName.Location = new System.Drawing.Point(46, 162);
            this.lbl_SaveName.Name = "lbl_SaveName";
            this.lbl_SaveName.Size = new System.Drawing.Size(61, 24);
            this.lbl_SaveName.TabIndex = 2;
            this.lbl_SaveName.Text = "Name";
            // 
            // sst_BottomBar
            // 
            this.sst_BottomBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_WriterStatus,
            this.ctx_WriterStatus});
            this.sst_BottomBar.Location = new System.Drawing.Point(0, 334);
            this.sst_BottomBar.Name = "sst_BottomBar";
            this.sst_BottomBar.Size = new System.Drawing.Size(522, 22);
            this.sst_BottomBar.TabIndex = 4;
            this.sst_BottomBar.Text = "statusStrip1";
            // 
            // lbl_WriterStatus
            // 
            this.lbl_WriterStatus.Name = "lbl_WriterStatus";
            this.lbl_WriterStatus.Size = new System.Drawing.Size(77, 17);
            this.lbl_WriterStatus.Text = "Writer Status:";
            // 
            // ctx_WriterStatus
            // 
            this.ctx_WriterStatus.ActiveLinkColor = System.Drawing.Color.Purple;
            this.ctx_WriterStatus.ForeColor = System.Drawing.Color.Red;
            this.ctx_WriterStatus.Name = "ctx_WriterStatus";
            this.ctx_WriterStatus.Size = new System.Drawing.Size(77, 17);
            this.ctx_WriterStatus.Text = "Not Detected";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(12, 232);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(497, 33);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // pgb_SaveProgress
            // 
            this.pgb_SaveProgress.Location = new System.Drawing.Point(12, 271);
            this.pgb_SaveProgress.Name = "pgb_SaveProgress";
            this.pgb_SaveProgress.Size = new System.Drawing.Size(497, 33);
            this.pgb_SaveProgress.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 356);
            this.Controls.Add(this.pgb_SaveProgress);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.sst_BottomBar);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.lbl_SaveName);
            this.Controls.Add(this.lbl_SavePath);
            this.Controls.Add(this.txt_SaveName);
            this.Controls.Add(this.txt_SavePath);
            this.Controls.Add(this.lbl_Programmer);
            this.Controls.Add(this.lbl_AppTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmMain";
            this.Text = "Dwriter Detect";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.sst_BottomBar.ResumeLayout(false);
            this.sst_BottomBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AppTitle;
        private System.Windows.Forms.Label lbl_Programmer;
        private System.Windows.Forms.TextBox txt_SavePath;
        private System.Windows.Forms.Label lbl_SavePath;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.TextBox txt_SaveName;
        private System.Windows.Forms.Label lbl_SaveName;
        private System.Windows.Forms.StatusStrip sst_BottomBar;
        private System.Windows.Forms.ToolStripStatusLabel lbl_WriterStatus;
        private System.Windows.Forms.ToolStripStatusLabel ctx_WriterStatus;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ProgressBar pgb_SaveProgress;
    }
}

