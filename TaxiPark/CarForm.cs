using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaxiPark
{
    public partial class CarForm : Form
    {
        public CarForm(Car car)
        {
            InitializeComponent();
            textBoxId.Text = car.Id.ToString();
            textBoxCar.Text = car.CarBrand.ToString();
            textBoxNumber.Text = car.StateNumber.ToString();
            textBoxColor.Text = car.Color.ToString();
            textBoxYear.Text = car.GradYear.ToString();
            textBoxRepair.Text = car.Repair.ToString();
        }
    }
}
