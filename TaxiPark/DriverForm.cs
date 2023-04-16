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
    public partial class DriverForm : Form
    {
        public DriverForm(Driver driver)
        {
            InitializeComponent();
            textBoxId.Text = driver.Id.ToString();
            textBoxName.Text = driver.Name.ToString();
            textBoxPass.Text = driver.PassID.ToString();
            textBoxAdress.Text = driver.Address.ToString();
            textBoxCity.Text = driver.City.ToString();
            textBoxRegion.Text = driver.Region.ToString();
            textBoxZipcode.Text = driver.ZipCode.ToString();
            textBoxNumber.Text = driver.Number.ToString();
            textBoxEmail.Text = driver.Email.ToString();
        }
    }
}
