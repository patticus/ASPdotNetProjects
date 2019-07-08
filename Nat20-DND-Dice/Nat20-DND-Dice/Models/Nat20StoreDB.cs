using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Nat20_DND_Dice.Models
{
    public class Nat20StoreDB : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Nat20StoreDB() : base("name=Nat20StoreDB")
        {
        }

        public System.Data.Entity.DbSet<Nat20_DND_Dice.Models.DicePack> DicePacks { get; set; }

        public System.Data.Entity.DbSet<Nat20_DND_Dice.Models.Design> Designs { get; set; }

        public System.Data.Entity.DbSet<Nat20_DND_Dice.Models.Material> Materials { get; set; }

        public System.Data.Entity.DbSet<Nat20_DND_Dice.Models.Order> Orders { get; set; }
    }
}
