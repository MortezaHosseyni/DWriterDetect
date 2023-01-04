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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lbl_AppTitle = new System.Windows.Forms.Label();
            this.lbl_Programmer = new System.Windows.Forms.Label();
            this.lbl_SavePath = new System.Windows.Forms.Label();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.txt_SaveName = new System.Windows.Forms.TextBox();
            this.lbl_SaveName = new System.Windows.Forms.Label();
            this.sst_BottomBar = new System.Windows.Forms.StatusStrip();
            this.lbl_WriterStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctx_WriterStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Between = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_CurrentFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctx_CurrentFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_CurrentFolder = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctx_CurrentFolder = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.pgb_SaveFileProgress = new System.Windows.Forms.ProgressBar();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.pgb_SaveFolderProgress = new System.Windows.Forms.ProgressBar();
            this.checkTimer = new System.Windows.Forms.Timer(this.components);
            this.txt_SavePath = new System.Windows.Forms.ComboBox();
            this.msp_TopMenu = new System.Windows.Forms.MenuStrip();
            this.archiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Paths = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Logs = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Break = new System.Windows.Forms.ToolStripSeparator();
            this.btn_About = new System.Windows.Forms.ToolStripMenuItem();
            this.sst_BottomBar.SuspendLayout();
            this.msp_TopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_AppTitle
            // 
            this.lbl_AppTitle.AutoSize = true;
            this.lbl_AppTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_AppTitle.Location = new System.Drawing.Point(268, 29);
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
            this.lbl_Programmer.Location = new System.Drawing.Point(350, 56);
            this.lbl_Programmer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Programmer.Name = "lbl_Programmer";
            this.lbl_Programmer.Size = new System.Drawing.Size(136, 17);
            this.lbl_Programmer.TabIndex = 0;
            this.lbl_Programmer.Text = "by Morteza Hosseini";
            // 
            // lbl_SavePath
            // 
            this.lbl_SavePath.AutoSize = true;
            this.lbl_SavePath.Location = new System.Drawing.Point(18, 125);
            this.lbl_SavePath.Name = "lbl_SavePath";
            this.lbl_SavePath.Size = new System.Drawing.Size(94, 24);
            this.lbl_SavePath.TabIndex = 2;
            this.lbl_SavePath.Text = "Save Path";
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(621, 122);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(34, 32);
            this.btn_Browse.TabIndex = 2;
            this.btn_Browse.Text = "...";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // txt_SaveName
            // 
            this.txt_SaveName.Location = new System.Drawing.Point(118, 160);
            this.txt_SaveName.Name = "txt_SaveName";
            this.txt_SaveName.Size = new System.Drawing.Size(497, 29);
            this.txt_SaveName.TabIndex = 3;
            // 
            // lbl_SaveName
            // 
            this.lbl_SaveName.AutoSize = true;
            this.lbl_SaveName.Location = new System.Drawing.Point(51, 163);
            this.lbl_SaveName.Name = "lbl_SaveName";
            this.lbl_SaveName.Size = new System.Drawing.Size(61, 24);
            this.lbl_SaveName.TabIndex = 2;
            this.lbl_SaveName.Text = "Name";
            // 
            // sst_BottomBar
            // 
            this.sst_BottomBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_WriterStatus,
            this.ctx_WriterStatus,
            this.lbl_Between,
            this.lbl_CurrentFile,
            this.ctx_CurrentFile,
            this.lbl_CurrentFolder,
            this.ctx_CurrentFolder});
            this.sst_BottomBar.Location = new System.Drawing.Point(0, 334);
            this.sst_BottomBar.Name = "sst_BottomBar";
            this.sst_BottomBar.Size = new System.Drawing.Size(743, 22);
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
            // lbl_Between
            // 
            this.lbl_Between.Name = "lbl_Between";
            this.lbl_Between.Size = new System.Drawing.Size(10, 17);
            this.lbl_Between.Text = "|";
            // 
            // lbl_CurrentFile
            // 
            this.lbl_CurrentFile.Name = "lbl_CurrentFile";
            this.lbl_CurrentFile.Size = new System.Drawing.Size(28, 17);
            this.lbl_CurrentFile.Text = "File:";
            // 
            // ctx_CurrentFile
            // 
            this.ctx_CurrentFile.Name = "ctx_CurrentFile";
            this.ctx_CurrentFile.Size = new System.Drawing.Size(36, 17);
            this.ctx_CurrentFile.Text = "None";
            // 
            // lbl_CurrentFolder
            // 
            this.lbl_CurrentFolder.Name = "lbl_CurrentFolder";
            this.lbl_CurrentFolder.Size = new System.Drawing.Size(43, 17);
            this.lbl_CurrentFolder.Text = "Folder:";
            // 
            // ctx_CurrentFolder
            // 
            this.ctx_CurrentFolder.Name = "ctx_CurrentFolder";
            this.ctx_CurrentFolder.Size = new System.Drawing.Size(36, 17);
            this.ctx_CurrentFolder.Text = "None";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(12, 233);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(719, 33);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // pgb_SaveFileProgress
            // 
            this.pgb_SaveFileProgress.Location = new System.Drawing.Point(12, 272);
            this.pgb_SaveFileProgress.Name = "pgb_SaveFileProgress";
            this.pgb_SaveFileProgress.Size = new System.Drawing.Size(359, 33);
            this.pgb_SaveFileProgress.TabIndex = 6;
            // 
            // bgWorker
            // 
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            // 
            // pgb_SaveFolderProgress
            // 
            this.pgb_SaveFolderProgress.Location = new System.Drawing.Point(377, 272);
            this.pgb_SaveFolderProgress.Name = "pgb_SaveFolderProgress";
            this.pgb_SaveFolderProgress.Size = new System.Drawing.Size(354, 33);
            this.pgb_SaveFolderProgress.TabIndex = 6;
            // 
            // checkTimer
            // 
            this.checkTimer.Tick += new System.EventHandler(this.checkTimer_Tick);
            // 
            // txt_SavePath
            // 
            this.txt_SavePath.FormattingEnabled = true;
            this.txt_SavePath.Location = new System.Drawing.Point(118, 122);
            this.txt_SavePath.Name = "txt_SavePath";
            this.txt_SavePath.Size = new System.Drawing.Size(497, 32);
            this.txt_SavePath.TabIndex = 1;
            // 
            // msp_TopMenu
            // 
            this.msp_TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archiveToolStripMenuItem});
            this.msp_TopMenu.Location = new System.Drawing.Point(0, 0);
            this.msp_TopMenu.Name = "msp_TopMenu";
            this.msp_TopMenu.Size = new System.Drawing.Size(743, 24);
            this.msp_TopMenu.TabIndex = 7;
            this.msp_TopMenu.Text = "menuStrip1";
            // 
            // archiveToolStripMenuItem
            // 
            this.archiveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Paths,
            this.btn_Logs,
            this.lbl_Break,
            this.btn_About});
            this.archiveToolStripMenuItem.Name = "archiveToolStripMenuItem";
            this.archiveToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.archiveToolStripMenuItem.Text = "Archive";
            // 
            // btn_Paths
            // 
            this.btn_Paths.Name = "btn_Paths";
            this.btn_Paths.Size = new System.Drawing.Size(107, 22);
            this.btn_Paths.Text = "Paths";
            this.btn_Paths.Click += new System.EventHandler(this.btn_Paths_Click);
            // 
            // btn_Logs
            // 
            this.btn_Logs.Name = "btn_Logs";
            this.btn_Logs.Size = new System.Drawing.Size(107, 22);
            this.btn_Logs.Text = "Logs";
            this.btn_Logs.Click += new System.EventHandler(this.btn_Logs_Click);
            // 
            // lbl_Break
            // 
            this.lbl_Break.Name = "lbl_Break";
            this.lbl_Break.Size = new System.Drawing.Size(104, 6);
            // 
            // btn_About
            // 
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(107, 22);
            this.btn_About.Text = "About";
            this.btn_About.Click += new System.EventHandler(this.btn_About_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 356);
            this.Controls.Add(this.txt_SavePath);
            this.Controls.Add(this.pgb_SaveFolderProgress);
            this.Controls.Add(this.pgb_SaveFileProgress);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.sst_BottomBar);
            this.Controls.Add(this.msp_TopMenu);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.lbl_SaveName);
            this.Controls.Add(this.lbl_SavePath);
            this.Controls.Add(this.txt_SaveName);
            this.Controls.Add(this.lbl_Programmer);
            this.Controls.Add(this.lbl_AppTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msp_TopMenu;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(759, 395);
            this.MinimumSize = new System.Drawing.Size(759, 395);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dwriter Detect";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.sst_BottomBar.ResumeLayout(false);
            this.sst_BottomBar.PerformLayout();
            this.msp_TopMenu.ResumeLayout(false);
            this.msp_TopMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AppTitle;
        private System.Windows.Forms.Label lbl_Programmer;
        private System.Windows.Forms.Label lbl_SavePath;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.TextBox txt_SaveName;
        private System.Windows.Forms.Label lbl_SaveName;
        private System.Windows.Forms.StatusStrip sst_BottomBar;
        private System.Windows.Forms.ToolStripStatusLabel lbl_WriterStatus;
        private System.Windows.Forms.ToolStripStatusLabel ctx_WriterStatus;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ProgressBar pgb_SaveFileProgress;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Between;
        private System.Windows.Forms.ToolStripStatusLabel lbl_CurrentFile;
        private System.Windows.Forms.ToolStripStatusLabel ctx_CurrentFile;
        private System.Windows.Forms.ToolStripStatusLabel lbl_CurrentFolder;
        private System.Windows.Forms.ToolStripStatusLabel ctx_CurrentFolder;
        private System.Windows.Forms.ProgressBar pgb_SaveFolderProgress;
        private System.Windows.Forms.Timer checkTimer;
        private System.Windows.Forms.ComboBox txt_SavePath;
        private System.Windows.Forms.MenuStrip msp_TopMenu;
        private System.Windows.Forms.ToolStripMenuItem archiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_Paths;
        private System.Windows.Forms.ToolStripMenuItem btn_Logs;
        private System.Windows.Forms.ToolStripSeparator lbl_Break;
        private System.Windows.Forms.ToolStripMenuItem btn_About;
    }
}

