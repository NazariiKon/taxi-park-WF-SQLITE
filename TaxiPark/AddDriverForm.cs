using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiPark
{
    public partial class AddDriverForm : Form
    {
        public AddDriverForm(List<Car> cars)
        {
            InitializeComponent();
            comboBoxCars.Items.AddRange(cars.ToArray());
            comboBoxCars.ValueMember = "Info";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string passId = textBoxPass.Text;
            string address = textBoxAdress.Text;
            string city = textBoxCity.Text;
            string region = textBoxRegion.Text;
            string zipcode = textBoxRegion.Text;
            string number = textBoxNumber.Text;
            string email = textBoxEmail.Text;
            Car selectedCar = (Car)comboBoxCars.SelectedItem;
            long carId = selectedCar.Id;

            string query = @"INSERT INTO Driver " +
                "(Name, PassID, Address, City, Region, ZipCode, Number, Email, CarId) " +
                "VALUES(@Name, @PassID, @Address, @City, @Region, @ZipCode, @Number, @Email, @CarId)";
            SQLiteReaderHelper.Request(query, name, passId, address, city, region, zipcode, number, email, carId);

            MessageBox.Show("Авто додане!");
            this.Close();
        }
    }
}
