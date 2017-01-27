using CarsSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsSystem.Data
{
    public class CarsSystemDbContext : DbContext
    {
        public CarsSystemDbContext()
            : base("CarsSystem")
        {

        }

        public virtual IDbSet<User> Users { get; set; }

        public virtual IDbSet<Car> Cars { get; set; }
    }
}
