using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWriterDetect
{
    internal class Database
    {
        public SQLiteDataReader readData(string tbName, string search = "1 = 1")
        {
			try
			{
				SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM {tbName} WHERE {search}");
				SQLiteDataReader reader = cmd.ExecuteReader();

				return reader;
			}
			catch (Exception err)
			{
				return null;
				throw;
			}
        }
    }
}
