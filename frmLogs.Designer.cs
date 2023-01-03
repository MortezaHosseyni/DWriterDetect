namespace DWriterDetect
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.LO_Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LO_Op = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LogsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_LogsTable
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_LogsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_LogsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LogsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LO_ID,
            this.LO_Name,
            this.LO_Date,
            this.LO_Path,
            this.LO_Op});
            this.dgv_LogsTable.Location = new System.Drawing.Point(15, 71);
            this.dgv_LogsTable.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgv_LogsTable.Name = "dgv_LogsTable";
            this.dgv_LogsTable.Size = new System.Drawing.Size(670, 332);
            this.dgv_LogsTable.TabIndex = 0;
            // 
            // txt_SearchByName
            // 
            this.txt_SearchByName.Location = new System.Drawing.Point(82, 33);
            this.txt_SearchByName.Name = "txt_SearchByName";
            this.txt_SearchByName.Size = new System.Drawing.Size(243, 29);
            this.txt_SearchByName.TabIndex = 1;
            // 
            // lbl_SearchByName
            // 
            this.lbl_SearchByName.AutoSize = true;
            this.lbl_SearchByName.Location = new System.Drawing.Point(15, 36);
            this.lbl_SearchByName.Name = "lbl_SearchByName";
            this.lbl_SearchByName.Size = new System.Drawing.Size(61, 24);
            this.lbl_SearchByName.TabIndex = 2;
            this.lbl_SearchByName.Text = "Name";
            // 
            // txt_SearchByDate
            // 
            this.txt_SearchByDate.Location = new System.Drawing.Point(392, 33);
            this.txt_SearchByDate.Name = "txt_SearchByDate";
            this.txt_SearchByDate.Size = new System.Drawing.Size(243, 29);
            this.txt_SearchByDate.TabIndex = 1;
            // 
            // lbl_SearchByDate
            // 
            this.lbl_SearchByDate.AutoSize = true;
            this.lbl_SearchByDate.Location = new System.Drawing.Point(338, 36);
            this.lbl_SearchByDate.Name = "lbl_SearchByDate";
            this.lbl_SearchByDate.Size = new System.Drawing.Size(48, 24);
            this.lbl_SearchByDate.TabIndex = 2;
            this.lbl_SearchByDate.Text = "Date";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(641, 33);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(44, 29);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "🔎";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // LO_ID
            // 
            this.LO_ID.HeaderText = "LogID";
            this.LO_ID.Name = "LO_ID";
            this.LO_ID.Visible = false;
            // 
            // LO_Name
            // 
            this.LO_Name.HeaderText = "Name";
            this.LO_Name.Name = "LO_Name";
            this.LO_Name.Width = 130;
            // 
            // LO_Date
            // 
            this.LO_Date.HeaderText = "Date";
            this.LO_Date.Name = "LO_Date";
            // 
            // LO_Path
            // 
            this.LO_Path.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LO_Path.HeaderText = "Path";
            this.LO_Path.Name = "LO_Path";
            // 
            // LO_Op
            // 
            this.LO_Op.HeaderText = "Operate";
            this.LO_Op.Name = "LO_Op";
            // 
            // frmLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 418);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lbl_SearchByDate);
            this.Controls.Add(this.lbl_SearchByName);
            this.Controls.Add(this.txt_SearchByDate);
            this.Controls.Add(this.txt_SearchByName);
            this.Controls.Add(this.dgv_LogsTable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmLogs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn LO_Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn LO_Op;
    }
}