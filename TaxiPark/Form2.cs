using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiPark
{
    record Taxi(Order Order, Car Car, Driver Driver);

    public partial class Form2 : Form
    {
        List<Order> orders = new List<Order>();
        List<Car> cars = new List<Car>();
        List<Driver> drivers = new List<Driver>();
        List<Taxi> taxi = new List<Taxi>();

        public Form2()
        {
            InitializeComponent();
            SQLiteDataReader reader = SQLiteReaderHelper.Request(@"SELECT * FROM 'Order'");
            if (reader != null)
            {
                while (reader.Read())
                {
                    orders.Add(CreateObject<Order>(reader,
                                                   "Id",
                                                   "CarId",
                                                   "DriverId",
                                                   "CarAddress",
                                                   "Route",
                                                   "Distance",
                                                   "Price",
                                                   "Date",
                                                   "Time"));
                }
            }
            listBoxOrders.ValueMember = "CarAddress";
            listBoxOrders.Items.AddRange(orders.ToArray());

            reader = SQLiteReaderHelper.Request(@"SELECT * FROM 'Car'");
            if (reader != null)
            {
                while (reader.Read())
                {
                    cars.Add(CreateObject<Car>(reader,
                                               "Id",
                                               "CarBrand",
                                               "StateNumber",
                                               "Color",
                                               "GradYear",
                                               "Repair"));
                }
            }

            reader = SQLiteReaderHelper.Request(@"SELECT * FROM 'Driver'");
            if (reader != null)
            {
                while (reader.Read())
                {
                    drivers.Add(CreateObject<Driver>(reader,
                                                "Id",
                                                "Name",
                                                "PassID",
                                                "Address",
                                                "City",
                                                "Region",
                                                "ZipCode",
                                                "Number",
                                                "Email",
                                                "CarId"));
                }
            }
        }

        public T CreateObject<T>(SQLiteDataReader reader, params object[] args) where T : new()
        {
            T obj = new T();
            Type type = typeof(T);
            for (int i = 0; i < args.Length; i++)
            {
                PropertyInfo prop = type.GetProperty(args[i].ToString());
                if (prop != null)
                {
                    prop.SetValue(obj, reader.GetValue(i));
                }
            }
            return obj;
        }


        private void listBoxOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order order = listBoxOrders.SelectedItem as Order;
            textBoxId.Text = order.Id.ToString();
            foreach (Car car in cars)
            {
                if (order.CarId == car.Id)
                {
                    buttonCar.Text = car.CarBrand.ToString();
                    break;
                }
            }

            foreach (Driver driver in drivers)
            {
                if (order.DriverId == driver.Id)
                {
                    buttonDriver.Text = driver.Name.ToString();
                    break;
                }
            }

            textBoxAdress.Text = order.CarAddress.ToString();
            textBoxRoute.Text = order.Route.ToString();
            textBoxDistance.Text = order.Distance.ToString();
            textBoxPrice.Text = order.Price.ToString();
            textBoxDate.Text = order.Date.ToString();
            textBoxTime.Text = order.Time.ToString();
        }

        private void buttonCar_Click(object sender, EventArgs e)
        {
            Order order = listBoxOrders.SelectedItem as Order;

            foreach (Car car in cars)
            {
                if (order.CarId == car.Id)
                {
                    CarForm carForm = new CarForm(car);
                    carForm.Show();
                    break;
                }
            }
        }

        private void buttonDriver_Click(object sender, EventArgs e)
        {
            Order order = listBoxOrders.SelectedItem as Order;

            foreach (Driver driver in drivers)
            {
                if (order.DriverId == driver.Id)
                {
                    DriverForm driverForm = new DriverForm(driver);
                    driverForm.Show();
                    break;
                }
            }
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            AddOrderForm addOrderForm = new AddOrderForm(cars, drivers);
            addOrderForm.Show();
        }
    }
}
