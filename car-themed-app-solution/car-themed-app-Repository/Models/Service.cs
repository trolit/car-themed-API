using System;

namespace car_themed_app_Repository.Models
{
    public class Service
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public string Price { get; set; }

        public DateTime DateOfService { get; set; }

        public int MechanicId { get; set; }

        public virtual Mechanic Mechanic { get; set; }

        public int CarId { get; set; }

        public virtual Car Car { get; set; }
    }
}
