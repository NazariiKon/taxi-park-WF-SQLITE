using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiPark
{
    internal class SQLiteReaderHelper
    {
        public static SQLiteDataReader Request(string query, object param = null)
        {
            SQLiteConnection _con = new SQLiteConnection(@"Data Source=ParkTaxi.db");
            _con.Open();
            SQLiteCommand command = new SQLiteCommand(query, _con);
            if (param != null)
            {
                command.Parameters.AddWithValue("@param", param);
            }
            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.HasRows) // если есть данные
            {
                return reader;
            }
            else
            {
                return null;
            }
        }
    }
}
