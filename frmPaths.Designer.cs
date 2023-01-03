namespace DWriterDetect
{
    partial class frmPaths
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaths));
            this.btn_AddPath = new System.Windows.Forms.Button();
            this.lsv_PathList = new System.Windows.Forms.ListView();
            this.txt_NewPath = new System.Windows.Forms.TextBox();
            this.btn_BrowsePath = new System.Windows.Forms.Button();
            this.cms_PathRightMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_DeletePath = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_PathRightMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AddPath
            // 
            this.btn_AddPath.Location = new System.Drawing.Point(12, 431);
            this.btn_AddPath.Name = "btn_AddPath";
            this.btn_AddPath.Size = new System.Drawing.Size(366, 31);
            this.btn_AddPath.TabIndex = 0;
            this.btn_AddPath.Text = "Add Path";
            this.btn_AddPath.UseVisualStyleBackColor = true;
            // 
            // lsv_PathList
            // 
            this.lsv_PathList.ContextMenuStrip = this.cms_PathRightMenu;
            this.lsv_PathList.HideSelection = false;
            this.lsv_PathList.Location = new System.Drawing.Point(12, 12);
            this.lsv_PathList.Name = "lsv_PathList";
            this.lsv_PathList.Size = new System.Drawing.Size(366, 381);
            this.lsv_PathList.TabIndex = 1;
            this.lsv_PathList.UseCompatibleStateImageBehavior = false;
            this.lsv_PathList.View = System.Windows.Forms.View.List;
            // 
            // txt_NewPath
            // 
            this.txt_NewPath.Location = new System.Drawing.Point(12, 399);
            this.txt_NewPath.Name = "txt_NewPath";
            this.txt_NewPath.Size = new System.Drawing.Size(326, 26);
            this.txt_NewPath.TabIndex = 2;
            // 
            // btn_BrowsePath
            // 
            this.btn_BrowsePath.Location = new System.Drawing.Point(344, 399);
            this.btn_BrowsePath.Name = "btn_BrowsePath";
            this.btn_BrowsePath.Size = new System.Drawing.Size(34, 26);
            this.btn_BrowsePath.TabIndex = 3;
            this.btn_BrowsePath.Text = "...";
            this.btn_BrowsePath.UseVisualStyleBackColor = true;
            // 
            // cms_PathRightMenu
            // 
            this.cms_PathRightMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_DeletePath});
            this.cms_PathRightMenu.Name = "cms_PathRightMenu";
            this.cms_PathRightMenu.Size = new System.Drawing.Size(181, 48);
            // 
            // btn_DeletePath
            // 
            this.btn_DeletePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_DeletePath.Name = "btn_DeletePath";
            this.btn_DeletePath.Size = new System.Drawing.Size(180, 22);
            this.btn_DeletePath.Text = "Delete";
            this.btn_DeletePath.Click += new System.EventHandler(this.btn_DeletePath_Click);
            // 
            // frmPaths
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 474);
            this.Controls.Add(this.btn_BrowsePath);
            this.Controls.Add(this.txt_NewPath);
            this.Controls.Add(this.lsv_PathList);
            this.Controls.Add(this.btn_AddPath);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPaths";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paths";
            this.Load += new System.EventHandler(this.frmPaths_Load);
            this.cms_PathRightMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddPath;
        private System.Windows.Forms.ListView lsv_PathList;
        private System.Windows.Forms.TextBox txt_NewPath;
        private System.Windows.Forms.Button btn_BrowsePath;
        private System.Windows.Forms.ContextMenuStrip cms_PathRightMenu;
        private System.Windows.Forms.ToolStripMenuItem btn_DeletePath;
    }
}