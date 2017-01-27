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

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string LastName { get; set; }

        public long EGN { get; set; }

        public int NumberOfIdCard { get; set; }

        public DateTime DateOfIssue { get; set; }

        public int PhoneNumber { get; set; }

        public Role Role { get; set; }

        public virtual ICollection<Car> Cars
        {
            get { return this.cars; }
            set { this.cars = value; }
        }
    }
}
