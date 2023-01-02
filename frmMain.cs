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
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog savePath = new FolderBrowserDialog();
            savePath.Description = "DVD Save path";
            savePath.ShowDialog();

            txt_SavePath.Text = savePath.SelectedPath;
        }
    }
}
