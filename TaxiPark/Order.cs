using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiPark
{
    public class Order
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int DriverId { get; set; }
        public string CarAddress { get; set; }
        public string Route { get; set; }
        public int Distance { get; set; }
        public int Price { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }

        public Order(int id, int carId, int driverId, string carAddress, string route, int distance, int price, string date, string time)
        {
            Id = id;
            CarId = carId;
            DriverId = driverId;
            CarAddress = carAddress;
            Route = route;
            Distance = distance;
            Price = price;
            Date = date;
            Time = time;
        }
    }

}
