namespace TaxiPark
{
    public class Car
    {
        public Car() { }
        public Int64 Id { get; set; }
        public string CarBrand { get; set; }
        public string StateNumber { get; set; }
        public string Color { get; set; }
        public string GradYear { get; set; }
        public string Repair { get; set; }
        public string Info { get; set; } 

        public Car(Int64 id, string carBrand, string stateNumber, string color, string gradYear, string repair)
        {
            Id = id;
            CarBrand = carBrand;
            StateNumber = stateNumber;
            Color = color;
            GradYear = gradYear;
            Repair = repair;
            Info = CarBrand + " " + GradYear;
        }
    }

}