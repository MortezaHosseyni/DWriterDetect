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
        SaveFileDialog saveExcel = new SaveFileDialog();

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
                    logs.GetValue(4)
                });
            }
        }
        private void btn_ExportExcel_Click(object sender, EventArgs e)
        {
            saveExcel.Title = "Save DWriter Logs";
            saveExcel.Filter = "Excel File | *.xls; *.xlsx";
            saveExcel.FileName = "Dwriter_Logs";
            saveExcel.ShowDialog();


            saveToExcel();
        }

        public void saveToExcel()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
             
            app.Visible = true;
             
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            
            worksheet.Name = "Exported DWriterDetect";
             
            for (int i = 1; i < dgv_LogsTable.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgv_LogsTable.Columns[i - 1].HeaderText;
            }
            
            for (int i = 0; i < dgv_LogsTable.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgv_LogsTable.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgv_LogsTable.Rows[i].Cells[j].Value.ToString();
                }
            }

            workbook.SaveAs(saveExcel.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            app.Quit();

            MessageBox.Show("Logs exported successfuly!", "Export Log", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
