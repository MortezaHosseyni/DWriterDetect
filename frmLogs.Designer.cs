﻿namespace DWriterDetect
{
    partial class frmLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogs));
            this.dgv_LogsTable = new System.Windows.Forms.DataGridView();
            this.txt_SearchByName = new System.Windows.Forms.TextBox();
            this.lbl_SearchByName = new System.Windows.Forms.Label();
            this.txt_SearchByDate = new System.Windows.Forms.TextBox();
            this.lbl_SearchByDate = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.LO_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LO_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LO_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LO_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LO_Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LogsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_LogsTable
            // 
            this.dgv_LogsTable.AllowUserToAddRows = false;
            this.dgv_LogsTable.AllowUserToDeleteRows = false;
            this.dgv_LogsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LogsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LO_ID,
            this.LO_Name,
            this.LO_Date,
            this.LO_Type,
            this.LO_Path});
            this.dgv_LogsTable.Location = new System.Drawing.Point(12, 59);
            this.dgv_LogsTable.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgv_LogsTable.Name = "dgv_LogsTable";
            this.dgv_LogsTable.ReadOnly = true;
            this.dgv_LogsTable.Size = new System.Drawing.Size(895, 376);
            this.dgv_LogsTable.TabIndex = 0;
            // 
            // txt_SearchByName
            // 
            this.txt_SearchByName.Location = new System.Drawing.Point(228, 26);
            this.txt_SearchByName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_SearchByName.Name = "txt_SearchByName";
            this.txt_SearchByName.Size = new System.Drawing.Size(200, 26);
            this.txt_SearchByName.TabIndex = 1;
            // 
            // lbl_SearchByName
            // 
            this.lbl_SearchByName.AutoSize = true;
            this.lbl_SearchByName.Location = new System.Drawing.Point(174, 28);
            this.lbl_SearchByName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SearchByName.Name = "lbl_SearchByName";
            this.lbl_SearchByName.Size = new System.Drawing.Size(51, 20);
            this.lbl_SearchByName.TabIndex = 2;
            this.lbl_SearchByName.Text = "Name";
            // 
            // txt_SearchByDate
            // 
            this.txt_SearchByDate.Location = new System.Drawing.Point(482, 26);
            this.txt_SearchByDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_SearchByDate.Name = "txt_SearchByDate";
            this.txt_SearchByDate.Size = new System.Drawing.Size(200, 26);
            this.txt_SearchByDate.TabIndex = 1;
            // 
            // lbl_SearchByDate
            // 
            this.lbl_SearchByDate.AutoSize = true;
            this.lbl_SearchByDate.Location = new System.Drawing.Point(438, 28);
            this.lbl_SearchByDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SearchByDate.Name = "lbl_SearchByDate";
            this.lbl_SearchByDate.Size = new System.Drawing.Size(44, 20);
            this.lbl_SearchByDate.TabIndex = 2;
            this.lbl_SearchByDate.Text = "Date";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(686, 26);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(36, 24);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "🔎";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // LO_ID
            // 
            this.LO_ID.HeaderText = "LogID";
            this.LO_ID.Name = "LO_ID";
            this.LO_ID.ReadOnly = true;
            this.LO_ID.Visible = false;
            // 
            // LO_Name
            // 
            this.LO_Name.HeaderText = "Name";
            this.LO_Name.Name = "LO_Name";
            this.LO_Name.ReadOnly = true;
            this.LO_Name.Width = 200;
            // 
            // LO_Date
            // 
            this.LO_Date.HeaderText = "Date";
            this.LO_Date.Name = "LO_Date";
            this.LO_Date.ReadOnly = true;
            this.LO_Date.Width = 180;
            // 
            // LO_Type
            // 
            this.LO_Type.HeaderText = "Status";
            this.LO_Type.Name = "LO_Type";
            this.LO_Type.ReadOnly = true;
            // 
            // LO_Path
            // 
            this.LO_Path.HeaderText = "Path";
            this.LO_Path.Name = "LO_Path";
            this.LO_Path.ReadOnly = true;
            this.LO_Path.Width = 400;
            // 
            // frmLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 449);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lbl_SearchByDate);
            this.Controls.Add(this.lbl_SearchByName);
            this.Controls.Add(this.txt_SearchByDate);
            this.Controls.Add(this.txt_SearchByName);
            this.Controls.Add(this.dgv_LogsTable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmLogs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log";
            this.Load += new System.EventHandler(this.frmLogs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LogsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_LogsTable;
        private System.Windows.Forms.TextBox txt_SearchByName;
        private System.Windows.Forms.Label lbl_SearchByName;
        private System.Windows.Forms.TextBox txt_SearchByDate;
        private System.Windows.Forms.Label lbl_SearchByDate;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn LO_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LO_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn LO_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn LO_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn LO_Path;
    }
}