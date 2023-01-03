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
    public partial class frmPaths : Form
    {
        Database db = new Database();
        public frmPaths()
        {
            InitializeComponent();
        }

        private void frmPaths_Load(object sender, EventArgs e)
        {
            showPath();
        }

        public void showPath()
        {
            lsv_PathList.Clear();
            lsv_PathList.Refresh();

            SQLiteDataReader paths = db.readData("TB_Paths");
            while (paths.Read())
            {
                lsv_PathList.Items.Add(paths.GetString(1));
            }
        }

        private void btn_DeletePath_Click(object sender, EventArgs e)
        {
            string delVal = lsv_PathList.SelectedItems[0].Text;
            if (db.deleteData("TB_Paths", $"PT_Path = '{delVal}'"))
            {
                MessageBox.Show("Path delete successfuly!", "Delete Path", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                showPath();
            }
        }

        private void btn_BrowsePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog savePath = new FolderBrowserDialog();
            savePath.Description = "Select DVD Save path";
            savePath.ShowDialog();

            txt_NewPath.Text = savePath.SelectedPath;
        }

        private void btn_AddPath_Click(object sender, EventArgs e)
        {
            if (txt_NewPath.Text.Trim() == "")
            {
                MessageBox.Show("Plaese select save path", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!txt_NewPath.Text.Trim().Contains("\\") || !txt_NewPath.Text.Trim().Contains(":"))
            {
                MessageBox.Show("Plaese select valid path", "Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lsv_PathList.Items.Count > 0)
            {
                sbyte ex = 0;
                
                for (int i = 0; i < lsv_PathList.Items.Count; i++)
                {
                    if (lsv_PathList.Items[i].Text == txt_NewPath.Text.Trim())
                    {
                        ex = 1;
                    }
                }

                if (ex == 0)
                {
                    if (db.addData("TB_Paths", "PT_Path", $"'{txt_NewPath.Text.Trim()}'"))
                    {
                        MessageBox.Show("Path save successfuly!", "Save Path", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        showPath();
                    }
                }
                else
                {
                    MessageBox.Show("Plaese select another path.", "Path Exsist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (db.addData("TB_Paths", "PT_Path", $"'{txt_NewPath.Text.Trim()}'"))
                {
                    MessageBox.Show("Path save successfuly!", "Save Path", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    showPath();
                }
            }
        }
    }
}
