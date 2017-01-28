using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsSystem.Data.Models
{
    public class User
    {
        private ICollection<Car> cars;

        public User()
        {
            this.cars = new HashSet<Car>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        public string SecondName { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        public long EGN { get; set; }

        [Required]
        public int NumberOfIdCard { get; set; }

        [Required]
        public DateTime DateOfIssue { get; set; }

        [Required]
        [MinLength(0)]
        [MaxLength(20)]
        public string City { get; set; }

        [Required]
        public int PhoneNumber { get; set; }

        public Role Role { get; set; }

        public virtual ICollection<Car> Cars
        {
            get { return this.cars; }
            set { this.cars = value; }
        }
    }
}
