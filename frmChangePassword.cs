using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWriterDetect
{
    public partial class frmChangePassword : Form
    {
        Database db = new Database();
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btn_SavePassword_Click(object sender, EventArgs e)
        {
            if (checkEmptyField())
            {
                if (checkNewPass())
                {
                    SQLiteDataReader user = db.readData("TB_User", "US_ID = 1");
                    if (user.Read() && user.GetString(1) == PassHash.passHasher(txt_OldPassword.Text.Trim()))
                    {
                        if (db.updateData("TB_User", $"US_Password = '{PassHash.passHasher(txt_NewPassword.Text.Trim())}'", "US_ID = 1"))
                        {
                            MessageBox.Show("Password saved successfuly!", "New Password Saved");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Old password is incorrect!", "Old Password Incorrect");
                        return;
                    }
                }
            }
        }

        private bool checkEmptyField()
        {
            if (txt_OldPassword.Text.Trim() == "" || txt_NewPassword.Text.Trim() == "" || txt_RePassword.Text.Trim() == "")
            {
                MessageBox.Show("Please fill empty fields", "Empty Fields");
                return false;
            }
            return true;
        }

        private bool checkNewPass()
        {
            if (txt_NewPassword.Text.Trim() != txt_RePassword.Text.Trim())
            {
                MessageBox.Show("New password and re-password are not the same", "New Password Error");
                return false;
            }
            return true;
        }
    }
}
