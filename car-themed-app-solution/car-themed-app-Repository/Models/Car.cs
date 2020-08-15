namespace car_themed_app_Repository.Models
{
    public class Car
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string YearOfProduction { get; set; }

        public string VIN { get; set; }

        public string LicensePlate { get; set; }

        public int DriverId { get; set; }

        public virtual Driver Driver { get; set; }
    }
}
