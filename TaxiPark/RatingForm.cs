using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class RatingForm : Form
    {
        public RatingForm(List<Driver> drivers)
        {
            InitializeComponent();
            drivers.Sort(delegate (Driver us1, Driver us2)
            { return us2.Count.CompareTo(us1.Count); });
            listBoxRating.DataSource = drivers;
            //listBoxRating.DisplayMember = "ToString";
        }
    }
}
