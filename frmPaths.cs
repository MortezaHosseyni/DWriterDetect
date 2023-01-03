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
            lsv_PathList.Clear();
            lsv_PathList.Refresh();

            SQLiteDataReader paths = db.readData("TB_Paths");
            while (paths.Read())
            {
                lsv_PathList.Items.Add(paths.GetString(1));
            }
        }
    }
}
