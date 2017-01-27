﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsSystem.Data.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Manufacturer { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Model { get; set; }

        [Required]
        public EngineType TypeOfEngine { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(10)]
        public string RegistrationNumber { get; set; }

        [Required]
        [Index(IsUnique =true)]
        [Range(17,17)]
        public string VINNumber { get; set; }

        [Range(2,10)]
        public byte CountOfTyres { get; set; }

        [Range(2,6)]
        public byte CountOfDoors { get; set; }

        [Required]
        public CarType TypeOfCar { get; set; }

        [Required]
        public DateTime YearOfManufacturing { get; set; }

        [Required]
        public DateTime ValidUntilAnnualCheckUp { get; set; }

        [Required]
        public DateTime ValidUntilVignette { get; set; }

        [Required]
        public DateTime ValidUntilInsurance { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}