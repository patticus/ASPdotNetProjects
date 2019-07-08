using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
/*
 * LINK TO AZURE WEB APP: https://pjguitarstore20190605051605.azurewebsites.net/ 
 */
namespace PJGuitarStore.Models
{
    public class GuitarStoreDbInitializer
    : System.Data.Entity.DropCreateDatabaseAlways<GuitarStoreDb>
    {
        protected override void Seed(GuitarStoreDb context)
        {

            context.Guitars.Add(new Guitar
            {
                GuitarId = 1,
                Brand = new Brand { BrandName = "Epiphone" },
                Category = new Category { CategoryName = "Electric" },
                Price = 599.99m,
                GuitarName = "Les Paul",
                Condition = "Used"
            });

            context.Guitars.Add(new Guitar
            {
                GuitarId = 2,
                Brand = new Brand { BrandName = "Gibson" },
                Category = new Category { CategoryName = "Electric" },
                Price = 3899.99m,
                GuitarName = "Les Paul Silverburst",
                Condition = "Used"
            });

            context.Guitars.Add(new Guitar
            {
                GuitarId = 3,
                Brand = new Brand { BrandName = "Fender" },
                Category = new Category { CategoryName = "Electric" },
                Price = 599.99m,
                GuitarName = "Stratocaster",
                Condition = "New"
            });

            context.Guitars.Add(new Guitar
            {
                GuitarId = 4,
                Brand = new Brand { BrandName = "Ibanez" },
                Category = new Category { CategoryName = "Acoustic" },
                Price = 699.99m,
                GuitarName = "Talman",
                Condition = "Used"
            });

            context.Guitars.Add(new Guitar
            {
                GuitarId = 5,
                Brand = new Brand { BrandName = "Martin" },
                Category = new Category { CategoryName = "Classical" },
                Price = 2299.99m,
                GuitarName = "Vintage 1970",
                Condition = "Used"
            });

            context.Guitars.Add(new Guitar
            {
                GuitarId = 6,
                Brand = new Brand { BrandName = "Taylor" },
                Category = new Category { CategoryName = "Acoustic" },
                Price = 1399.99m,
                GuitarName = "DLX Grand Auditorium",
                Condition = "New"
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

            context.Customers.Add(new Customer
            {
                CustomerId = "1",
                Username = "stinkyhead",
                Email = "stinker@gmail.com",
                FirstName = "Mister",
                LastName = "Stinkyface",
                Street = "123 Dookieshire",
                City = "State College",
                State = "PA",
                Zip = 16801
            });

            context.Customers.Add(new Customer
            {
                CustomerId = "2",
                Username = "awesomesauce",
                Email = "superman@gmail.com",
                FirstName = "Clark",
                LastName = "Kent",
                Street = "445 Krypton Ave",
                City = "State College",
                State = "PA",
                Zip = 16801
            });

            context.Customers.Add(new Customer
            {
                CustomerId = "3",
                Username = "satan",
                Email = "lucifer@gmail.com",
                FirstName = "Mister",
                LastName = "Satan",
                Street = "666 Hell Ave",
                City = "State College",
                State = "PA",
                Zip = 16801
            });

            context.Customers.Add(new Customer
            {
                CustomerId = "4",
                Username = "holyman99",
                Email = "savior@gmail.com",
                FirstName = "Jesus",
                LastName = "Christ",
                Street = "999 Heaven Road",
                City = "State College",
                State = "PA",
                Zip = 16801
            });

            context.Customers.Add(new Customer
            {
                CustomerId = "5",
                Username = "cashmaster",
                Email = "thecash@gmail.com",
                FirstName = "Johnny",
                LastName = "Cash",
                Street = "1001 Ring of Fire",
                City = "State College",
                State = "PA",
                Zip = 16801
            });

            context.Employees.Add(new Employee
            {
                EmployeeId = "1",
                Email = "kakarot@gmail.com",
                FirstName = "Goku",
                LastName = "Son",
                Street = "345 Turtle Island",
                City = "State College",
                State = "PA",
                Zip = 16801,
                Payrate = 25
            });

            context.Employees.Add(new Employee
            {
                EmployeeId = "2",
                Email = "krillin@gmail.com",
                FirstName = "Krillin",
                LastName = "Kuririn",
                Street = "345 Turtle Island",
                City = "State College",
                State = "PA",
                Zip = 16801,
                Payrate = 15
            });

            context.Employees.Add(new Employee
            {
                EmployeeId = "3",
                Email = "alwaysdead@gmail.com",
                FirstName = "Yamucha",
                LastName = "Dies",
                Street = "345 Turtle Island",
                City = "State College",
                State = "PA",
                Zip = 16801,
                Payrate = 9
            });

            context.Managers.Add(new Manager
            {
                ManagerId = "1",
                Email = "princeofsaiyans@gmail.com",
                FirstName = "Prince",
                LastName = "Vegeta",
                Street = "9999 Planet Vegeta Ave",
                City = "State College",
                State = "PA",
                Zip = 16801,
                Salary = 50000
            });

            context.Managers.Add(new Manager
            {
                ManagerId = "2",
                Email = "masteroftheuniverse@gmail.com",
                FirstName = "Freeza",
                LastName = "Cold",
                Street = "444 Destruction Rd",
                City = "State College",
                State = "PA",
                Zip = 16801,
                Salary = 1000000
            });

        }
    }
}