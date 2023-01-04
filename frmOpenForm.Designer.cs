namespace DWriterDetect
{
    partial class frmOpenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpenForm));
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_FormTitle = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_OpenForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(17, 58);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(78, 20);
            this.lbl_Password.TabIndex = 5;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_FormTitle
            // 
            this.lbl_FormTitle.AutoSize = true;
            this.lbl_FormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_FormTitle.Location = new System.Drawing.Point(118, 9);
            this.lbl_FormTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_FormTitle.Name = "lbl_FormTitle";
            this.lbl_FormTitle.Size = new System.Drawing.Size(95, 24);
            this.lbl_FormTitle.TabIndex = 3;
            this.lbl_FormTitle.Text = "Form Title";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(103, 55);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(215, 26);
            this.txt_Password.TabIndex = 4;
            // 
            // btn_OpenForm
            // 
            this.btn_OpenForm.Location = new System.Drawing.Point(52, 107);
            this.btn_OpenForm.Name = "btn_OpenForm";
            this.btn_OpenForm.Size = new System.Drawing.Size(228, 29);
            this.btn_OpenForm.TabIndex = 6;
            this.btn_OpenForm.Text = "Open Form";
            this.btn_OpenForm.UseVisualStyleBackColor = true;
            this.btn_OpenForm.Click += new System.EventHandler(this.btn_OpenForm_Click);
            // 
            // frmOpenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 161);
            this.Controls.Add(this.btn_OpenForm);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_FormTitle);
            this.Controls.Add(this.txt_Password);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmOpenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Form";
            this.Load += new System.EventHandler(this.frmOpenForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_FormTitle;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_OpenForm;
    }
}