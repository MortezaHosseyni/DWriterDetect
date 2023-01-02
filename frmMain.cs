using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWriterDetect
{
    public partial class frmMain : Form
    {
        public string dvdRoot = "";
        public string toDay = "";
        PersianCalendar pc = new PersianCalendar();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var driveWatcher = new DriveWatcher();
            driveWatcher.OpticalDiskArrived += DriveWatcherOnOpticalDiskArrived;
            driveWatcher.Start();
            toDay = $"{pc.GetYear(DateTime.Now)}_{pc.GetMonth(DateTime.Now)}_{pc.GetDayOfMonth(DateTime.Now)}";
        }

        private void DriveWatcherOnOpticalDiskArrived(object sender, OpticalDiskArrivedEventArgs e)
        {
            ctx_WriterStatus.ForeColor = Color.Green;
            ctx_WriterStatus.Text = "Detected";

            dvdRoot = e.Drive.RootDirectory.FullName;
            pgb_SaveProgress.Maximum = e.Drive.RootDirectory.GetFiles().Length;
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog savePath = new FolderBrowserDialog();
            savePath.Description = "DVD Save path";
            savePath.ShowDialog();
            
            txt_SavePath.Text = savePath.SelectedPath;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (checkField() && dvdRoot != "")
            {
                string name = txt_SaveName.Text.Replace(" ", "_");
                string target = $"{txt_SavePath.Text.Trim()}\\{toDay}_{name}";
                CopyFilesRecursively(dvdRoot, target);
            }
        }


        private void CopyFilesRecursively(string sourcePath, string targetPath)
        {
            try
            {
                foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
                }

                foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
                {
                    File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                    pgb_SaveProgress.Value = +1;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Copy error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool checkField()
        {
            if (txt_SaveName.Text.Trim() == "" || txt_SavePath.Text.Trim() == "")
            {
                MessageBox.Show("Name or path filed is empty", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
