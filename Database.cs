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
			catch (Exception)
			{
				return null;
			}
        }

		public bool addData(string tbName, string fields, string values)
		{
            try
            {
                SQLiteCommand cmd = new SQLiteCommand($"INSERT INTO {tbName} ({fields}) VALUES ({values})");
                cmd.ExecuteReader();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
