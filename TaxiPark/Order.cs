using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiPark
{
    public class Order
    {
        public Order() { }

        public Int64 Id { get; set; }
        public Int64 CarId { get; set; }
        public Int64 DriverId { get; set; }
        public string CarAddress { get; set; }
        public string Route { get; set; }
        public Int64 Distance { get; set; }
        public Int64 Price { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Info { get; set; }

        public Order(Int64 id, Int64 carId, Int64 driverId, string carAddress, string route, 
            Int64 distance, Int64 price, string date, string time)
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
