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
    public partial class AddOrderForm : Form
    {
        public AddOrderForm(List<Car> cars, List<Driver> drivers)
        {
            InitializeComponent();
            comboBoxCars.Items.AddRange(cars.ToArray());
            comboBoxCars.ValueMember = "Info";
            comboBoxDrivers.Items.AddRange(drivers.ToArray());
            comboBoxDrivers.ValueMember = "Name";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
