using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWriterDetect
{
    public partial class frmMain : Form
    {
        public string dvdRoot = "";
        public string toDay = "";

        public string sourcePath, targetPath;

        PersianCalendar pc = new PersianCalendar();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            if (File.Exists("paths.txt"))
            {
                foreach (var line in File.ReadLines("paths.txt"))
                {
                    txt_SavePath.Items.Add(line);
                }
            }

            checkTimer.Tick += new EventHandler(checkTimer_Tick);
            checkTimer.Interval = 1000; // in miliseconds
            checkTimer.Start();

            var drive = DriveInfo.GetDrives().Where(d => d.DriveType == DriveType.CDRom).SingleOrDefault();
            if (Directory.Exists(drive.RootDirectory.FullName))
            {
                ctx_WriterStatus.ForeColor = Color.Green;
                ctx_WriterStatus.Text = "Detected";
                dvdRoot = drive.RootDirectory.FullName;
                pgb_SaveFileProgress.Maximum = System.IO.Directory.GetFiles(drive.RootDirectory.FullName, "*.*", SearchOption.AllDirectories).Count();
                pgb_SaveFolderProgress.Maximum = System.IO.Directory.GetDirectories(drive.RootDirectory.FullName, "*", SearchOption.AllDirectories).Count();
            }

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
            pgb_SaveFileProgress.Maximum = System.IO.Directory.GetFiles(e.Drive.RootDirectory.FullName, "*.*", SearchOption.AllDirectories).Count();
            pgb_SaveFolderProgress.Maximum = System.IO.Directory.GetDirectories(e.Drive.RootDirectory.FullName, "*", SearchOption.AllDirectories).Count();

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
            if (File.Exists("paths.txt"))
            {
                foreach (var line in File.ReadLines("paths.txt"))
                {
                    if (line != txt_SavePath.Text.Trim())
                    {
                        File.AppendAllText("paths.txt", txt_SavePath.Text.Trim() + "\n");
                    }
                }
            }
            else
            {
                File.Create("paths.txt");
            }

            if (ctx_WriterStatus.Text != "Detected")
            {
                MessageBox.Show("Enter your dvd in dvd writer", "DVD Not Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (checkField() && dvdRoot != "")
            {
                if (btn_Save.Text == "Save")
                {
                    string name = txt_SaveName.Text.Replace(" ", "_");
                    string target = $"{txt_SavePath.Text.Trim()}\\{toDay}\\{pc.GetHour(DateTime.Now)}_{pc.GetMinute(DateTime.Now)}_{pc.GetSecond(DateTime.Now)}__{name}\\";
                    sourcePath = dvdRoot;
                    targetPath = target;
                    btn_Save.Text = "Cancel";

                    bgWorker = new BackgroundWorker();
                    bgWorker.WorkerReportsProgress = true;
                    bgWorker.WorkerSupportsCancellation = true;
                    bgWorker.DoWork += new DoWorkEventHandler(bgWorker_DoWork);
                    bgWorker.RunWorkerAsync();
                }
                else
                {
                    if (MessageBox.Show("Are you sure?", "Cancel Progress", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bgWorker.CancelAsync();
                        btn_Save.Text = "Save";
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Name or path field is empty", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }


        private bool checkField()
        {
            if (txt_SaveName.Text.Trim() == "" || txt_SavePath.Text.Trim() == "")
            {
                return false;
            }
            return true;
        }

        private void checkTimer_Tick(object sender, EventArgs e)
        {
            if (!Directory.Exists(dvdRoot))
            {
                ctx_WriterStatus.ForeColor = Color.Red;
                ctx_WriterStatus.Text = "Not Detected";
            }
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
                {
                    Thread.Sleep(60);
                    this.Invoke(new Action(() => { pgb_SaveFolderProgress.Value += 1; }));
                    this.Invoke(new Action(() => { ctx_CurrentFolder.Text = dirPath.Split('\\').Last(); }));
                    if (this.bgWorker.CancellationPending)
                    {
                        e.Cancel = true;
                        this.Invoke(new Action(() => { btn_Save.Text = "Save"; }));
                        this.Invoke(new Action(() => { pgb_SaveFolderProgress.Value = 0; }));
                        this.Invoke(new Action(() => { pgb_SaveFileProgress.Value = 0; }));
                        Application.Restart();
                        Environment.Exit(0);
                        return;
                    }
                    Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
                }

                this.Invoke(new Action(() => { ctx_CurrentFolder.Text = "Folders loaded!"; }));


                foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
                {
                    Thread.Sleep(40);
                    this.Invoke(new Action(() => { pgb_SaveFileProgress.Value += 1; }));
                    var fileSize = new FileInfo(newPath).Length * Math.Pow(10, -6);
                    this.Invoke(new Action(() => { ctx_CurrentFile.Text = $"{newPath.Split('\\').Last()}({Math.Round(fileSize, 2)} MB)"; }));

                    if (this.bgWorker.CancellationPending)
                    {
                        e.Cancel = true;
                        this.Invoke(new Action(() => { btn_Save.Text = "Save"; }));
                        this.Invoke(new Action(() => { pgb_SaveFolderProgress.Value = 0; }));
                        this.Invoke(new Action(() => { pgb_SaveFileProgress.Value = 0; }));
                        Application.Restart();
                        Environment.Exit(0);
                        return;
                    }
                    File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                }

                this.Invoke(new Action(() => { ctx_CurrentFile.Text = "Files loaded!"; }));
                this.Invoke(new Action(() => { btn_Save.Text = "Save"; }));
                this.Invoke(new Action(() => { pgb_SaveFolderProgress.Value = 0; }));
                this.Invoke(new Action(() => { pgb_SaveFileProgress.Value = 0; }));

                if (MessageBox.Show("All files saved!\nDo you want the DVD writer to be ejected?", "Files Saved", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    closeDvd();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Copy error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static void RestartApp(int pid, string applicationName)
        {
            // Wait for the process to terminate
            Process process = null;
            try
            {
                process = Process.GetProcessById(pid);
                process.WaitForExit(1000);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Cannot restart app.", "Restart Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Process.Start(applicationName, "");
        }

        private static void closeDvd()
        {
            int ret = mciSendString("set cdaudio door open", null, 0, IntPtr.Zero);
        }

        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi)]
        protected static extern int mciSendString(string lpstrCommand,
                                                   StringBuilder lpstrReturnString,
                                                   int uReturnLength,
                                                   IntPtr hwndCallback);
    }

    
}
