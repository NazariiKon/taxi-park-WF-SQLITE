using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiPark
{
    public partial class AddOrderForm : Form
    {
        public AddOrderForm(List<Car> cars, List<Driver> drivers)
        {
            InitializeComponent();
            comboBoxCars.Items.AddRange(cars.ToArray());
            comboBoxCars.ValueMember = "Info";
            comboBoxDrivers.Items.AddRange(drivers.ToArray());
            comboBoxDrivers.ValueMember = "Name";
            comboBoxCars.SelectedIndex = 0;
            comboBoxDrivers.SelectedIndex = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Car selectedCar = (Car)comboBoxCars.SelectedItem;
            Driver selectedDriver = (Driver)comboBoxDrivers.SelectedItem;
            Int64 carId = selectedCar.Id;
            Int64 driverId = selectedDriver.Id;
            string address = textBoxAdress.Text;
            string route = textBoxRoute.Text;
            Int64 distance = decimal.ToInt64(numericUpDownDistance.Value);
            Int64 price = decimal.ToInt64(numericUpDownPrice.Value);
            string date = dateTimePicker.Value.ToShortDateString();
            string time = dateTimePickerTime.Value.ToShortTimeString();

            string query = @"INSERT INTO 'Order'" +
            "(CarId, DriverId, CarAddress, Route, Distance, Price, Date, Time) " +
            "VALUES (@CarId, @DriverId, @CarAddress, @Route, @Distance, @Price, @Date, @Time)";
            SQLiteReaderHelper.Request(query, carId, driverId, address, route, distance, price, date, time);

            MessageBox.Show("Замовлення додане!");
            this.Close();
        }
    }
}
