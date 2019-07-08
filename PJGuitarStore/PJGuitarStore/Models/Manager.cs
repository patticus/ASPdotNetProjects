using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PJGuitarStore.Models
{
    public class Manager
    {
        public string ManagerId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public decimal Salary { get; set; }
    }
}