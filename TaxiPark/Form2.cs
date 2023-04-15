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

namespace TaxiPark
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            SQLiteDataReader reader = SQLiteReaderHelper.Request(
                "SELECT * FROM Order");
            if (reader != null)
            {
                createOrder(reader);
            }
        }
        public Order createOrder(SQLiteDataReader reader)
        {
            int id = reader.GetInt16(0);
            int carId = reader.GetInt16(1);
            int driverId = reader.GetInt16(2);
            string carAdress = reader.GetString(3);
            string route = reader.GetString(4);
            int distance = reader.GetInt16(5);
            int price = reader.GetInt16(6);
            string data = reader.GetString(7);
            string time = reader.GetString(8);

            Order order = new Order(id, carId, driverId, carAdress, route, distance, price, data, time);
            return order;
        }
    }
}
