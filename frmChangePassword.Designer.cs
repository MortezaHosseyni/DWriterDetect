namespace DWriterDetect
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.txt_OldPassword = new System.Windows.Forms.TextBox();
            this.lbl_PassTitle = new System.Windows.Forms.Label();
            this.lbl_OldPassword = new System.Windows.Forms.Label();
            this.txt_NewPassword = new System.Windows.Forms.TextBox();
            this.lbl_NewPassword = new System.Windows.Forms.Label();
            this.txt_RePassword = new System.Windows.Forms.TextBox();
            this.lbl_RepetPassword = new System.Windows.Forms.Label();
            this.btn_SavePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_OldPassword
            // 
            this.txt_OldPassword.Location = new System.Drawing.Point(124, 67);
            this.txt_OldPassword.Name = "txt_OldPassword";
            this.txt_OldPassword.PasswordChar = '#';
            this.txt_OldPassword.Size = new System.Drawing.Size(254, 26);
            this.txt_OldPassword.TabIndex = 1;
            // 
            // lbl_PassTitle
            // 
            this.lbl_PassTitle.AutoSize = true;
            this.lbl_PassTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_PassTitle.Location = new System.Drawing.Point(82, 23);
            this.lbl_PassTitle.Name = "lbl_PassTitle";
            this.lbl_PassTitle.Size = new System.Drawing.Size(209, 24);
            this.lbl_PassTitle.TabIndex = 1;
            this.lbl_PassTitle.Text = "Change Your Password";
            // 
            // lbl_OldPassword
            // 
            this.lbl_OldPassword.AutoSize = true;
            this.lbl_OldPassword.Location = new System.Drawing.Point(12, 70);
            this.lbl_OldPassword.Name = "lbl_OldPassword";
            this.lbl_OldPassword.Size = new System.Drawing.Size(106, 20);
            this.lbl_OldPassword.TabIndex = 2;
            this.lbl_OldPassword.Text = "Old Password";
            // 
            // txt_NewPassword
            // 
            this.txt_NewPassword.Location = new System.Drawing.Point(124, 124);
            this.txt_NewPassword.Name = "txt_NewPassword";
            this.txt_NewPassword.PasswordChar = '#';
            this.txt_NewPassword.Size = new System.Drawing.Size(254, 26);
            this.txt_NewPassword.TabIndex = 2;
            // 
            // lbl_NewPassword
            // 
            this.lbl_NewPassword.AutoSize = true;
            this.lbl_NewPassword.Location = new System.Drawing.Point(5, 127);
            this.lbl_NewPassword.Name = "lbl_NewPassword";
            this.lbl_NewPassword.Size = new System.Drawing.Size(113, 20);
            this.lbl_NewPassword.TabIndex = 2;
            this.lbl_NewPassword.Text = "New Password";
            // 
            // txt_RePassword
            // 
            this.txt_RePassword.Location = new System.Drawing.Point(124, 156);
            this.txt_RePassword.Name = "txt_RePassword";
            this.txt_RePassword.PasswordChar = '#';
            this.txt_RePassword.Size = new System.Drawing.Size(254, 26);
            this.txt_RePassword.TabIndex = 3;
            // 
            // lbl_RepetPassword
            // 
            this.lbl_RepetPassword.AutoSize = true;
            this.lbl_RepetPassword.Location = new System.Drawing.Point(14, 159);
            this.lbl_RepetPassword.Name = "lbl_RepetPassword";
            this.lbl_RepetPassword.Size = new System.Drawing.Size(104, 20);
            this.lbl_RepetPassword.TabIndex = 2;
            this.lbl_RepetPassword.Text = "Re-Password";
            // 
            // btn_SavePassword
            // 
            this.btn_SavePassword.Location = new System.Drawing.Point(75, 208);
            this.btn_SavePassword.Name = "btn_SavePassword";
            this.btn_SavePassword.Size = new System.Drawing.Size(228, 29);
            this.btn_SavePassword.TabIndex = 4;
            this.btn_SavePassword.Text = "Save Password";
            this.btn_SavePassword.UseVisualStyleBackColor = true;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 262);
            this.Controls.Add(this.btn_SavePassword);
            this.Controls.Add(this.lbl_RepetPassword);
            this.Controls.Add(this.lbl_NewPassword);
            this.Controls.Add(this.lbl_OldPassword);
            this.Controls.Add(this.lbl_PassTitle);
            this.Controls.Add(this.txt_RePassword);
            this.Controls.Add(this.txt_NewPassword);
            this.Controls.Add(this.txt_OldPassword);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(406, 301);
            this.MinimumSize = new System.Drawing.Size(406, 301);
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_OldPassword;
        private System.Windows.Forms.Label lbl_PassTitle;
        private System.Windows.Forms.Label lbl_OldPassword;
        private System.Windows.Forms.TextBox txt_NewPassword;
        private System.Windows.Forms.Label lbl_NewPassword;
        private System.Windows.Forms.TextBox txt_RePassword;
        private System.Windows.Forms.Label lbl_RepetPassword;
        private System.Windows.Forms.Button btn_SavePassword;
    }
}