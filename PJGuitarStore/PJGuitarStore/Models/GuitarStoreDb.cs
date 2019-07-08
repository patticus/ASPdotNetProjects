using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PJGuitarStore.Models
{
    public class GuitarStoreDb : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public GuitarStoreDb() : base("name=GuitarStoreDb")
        {
        }

        public System.Data.Entity.DbSet<PJGuitarStore.Models.Guitar> Guitars { get; set; }

        public System.Data.Entity.DbSet<PJGuitarStore.Models.Brand> Brands { get; set; }

        public System.Data.Entity.DbSet<PJGuitarStore.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<PJGuitarStore.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<PJGuitarStore.Models.Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<PJGuitarStore.Models.Manager> Managers { get; set; }

        public System.Data.Entity.DbSet<PJGuitarStore.Models.Order> Orders { get; set; }
    }
}
