using System;

namespace car_themed_app_Repository.Models
{
    public class Mechanic
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime WorkingSince { get; set; }
    }
}
