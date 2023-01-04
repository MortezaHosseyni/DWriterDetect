using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWriterDetect
{
    public partial class frmOpenForm : Form
    {
        Database db = new Database();
        public sbyte formID;
        public frmOpenForm()
        {
            InitializeComponent();
        }

        private void frmOpenForm_Load(object sender, EventArgs e)
        {
            if (formID == 0)
            {
                lbl_FormTitle.Text = "Paths";
                btn_OpenForm.Text = "Open Paths";
            }
            else
            {
                lbl_FormTitle.Text = "Logs";
                btn_OpenForm.Text = "Open Logs";
            }
        }

        private void btn_OpenForm_Click(object sender, EventArgs e)
        {
            SQLiteDataReader user = db.readData("TB_User", "US_ID = 1");
            if (!user.Read()) { MessageBox.Show("We have a Unexpected error!", "Unexpected error"); return; }
            string pass = user.GetString(1);
            user.Close();
            if (pass == PassHash.passHasher(txt_Password.Text.Trim()))
            {
                if (formID == 0)
                {
                    frmPaths fPath = new frmPaths();
                    fPath.Show();
                    this.Close();
                }
                else
                {
                    frmLogs fLog = new frmLogs();
                    fLog.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Password is incorrect", "Incorrect Password");
                return;
            }
        }
    }
}
