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
    public partial class AddCarForm : Form
    {
        public AddCarForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string car = textBoxCar.Text;
            string number = textBoxNumber.Text;
            string color = textBoxColor.Text;
            string repair = textBoxRepair.Text;
            long year = decimal.ToInt64(numericUpDownYear.Value);

            string query = @"INSERT INTO Car " +
                "(CarBrand, StateNumber, Color, GradYear, Repair) " +
                "VALUES(@CarBrand, @StateNumber, @Color, @GradYear, @Repair); ";
            SQLiteReaderHelper.Request(query, car, number, color, year, repair);

            MessageBox.Show("Авто додане!");
            this.Close();
        }
    }
}
