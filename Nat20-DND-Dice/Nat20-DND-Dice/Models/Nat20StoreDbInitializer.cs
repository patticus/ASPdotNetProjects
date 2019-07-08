using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nat20_DND_Dice.Models
{
    public class Nat20StoreDbInitializer
        : System.Data.Entity.DropCreateDatabaseAlways<Nat20StoreDB>
    {
        protected override void Seed(Nat20StoreDB context)
        {
            context.Designs.Add(new Design { Name = "Forest" });
            context.Designs.Add(new Design { Name = "Mountain" });
            context.Designs.Add(new Design { Name = "Volcano" });
            context.Designs.Add(new Design { Name = "Desert" });
            context.Materials.Add(new Material { MaterialType = "Wood" });
            context.Materials.Add(new Material { MaterialType = "Granite" });
            context.Materials.Add(new Material { MaterialType = "Obsidian" });
            context.Materials.Add(new Material { MaterialType = "Crystal" });
            context.DicePacks.Add(new DicePack
            {
                Design = new Design { Name = "Mountain" },
                Material = new Material { MaterialType = "Granite" },
                Price = 59.99m,
                Color = "Gray",
                Bag = "Leather"
            });

            context.Orders.Add(new Order
            {
                OrderId = 1,
                OrderDate = DateTime.Now,
                Username = "chonkchonk99",
                FirstName = "Big Ol'",
                LastName = "Chonker",
                Address = "9999 Chonker Ave",
                City = "State College",
                State = "PA",
                PostalCode = "16801",
                Country = "Albania",
                Phone = "814-555-9999",
                Email = "thebiggestchonk@stuff.org",
                EmailConfirm = "thebiggestchonk@stuff.org",
                Total = 1         
            });
        }
    }
}