using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsSystem.Data.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public EngineType TypeOfEngine { get; set; }

        public string RegistrationNumber { get; set; }

        public string VINNumber { get; set; }

        public byte CountOfTyres { get; set; }

        public byte CountOfDoors { get; set; }

        public CarType TypeOfCar { get; set; }

        public DateTime YearOfManufacturing { get; set; }

        public DateTime ValidUntilAnnualCheckUp { get; set; }

        public DateTime ValidUntilVignette { get; set; }

        public DateTime ValidUntilInsurance { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
