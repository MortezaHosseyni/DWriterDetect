using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWriterDetect
{
    public partial class frmMain : Form
    {
        string dvdRoot = "";

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var driveWatcher = new DriveWatcher();
            driveWatcher.OpticalDiskArrived += DriveWatcherOnOpticalDiskArrived;
            driveWatcher.Start();
        }

        private void DriveWatcherOnOpticalDiskArrived(object sender, OpticalDiskArrivedEventArgs e)
        {
            ctx_WriterStatus.ForeColor = Color.Green;
            ctx_WriterStatus.Text = "Detected";

            dvdRoot = e.Drive.RootDirectory.FullName;
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
