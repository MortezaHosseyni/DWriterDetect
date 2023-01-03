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
    public partial class frmLogs : Form
    {
        Database db = new Database();
        public frmLogs()
        {
            InitializeComponent();
        }

        private void frmLogs_Load(object sender, EventArgs e)
        {
            dgv_LogsTable.ScrollBars = ScrollBars.Both;
            showLogs("1 = 1");
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            showLogs($"LO_Name LIKE '%{txt_SearchByName.Text.Trim()}%' AND LO_Date LIKE '%{txt_SearchByDate.Text.Trim()}%'");
        }

        public void showLogs(string search)
        {
            SQLiteDataReader logs = db.readData("TB_Log", search);
            dgv_LogsTable.Rows.Clear();
            dgv_LogsTable.Refresh();

            while (logs.Read())
            {
                dgv_LogsTable.Rows.Add(new object[] {
                    logs.GetValue(0),  
                    logs.GetValue(1),  
                    logs.GetValue(2),
                    (Convert.ToInt32(logs.GetValue(3)) == 1 ? "Success" : "Canceled"),
                    logs.GetValue(4),
                    "Delete"
                });
            }
        }
    }
}
