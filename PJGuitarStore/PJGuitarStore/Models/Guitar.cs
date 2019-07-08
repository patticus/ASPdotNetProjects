using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PJGuitarStore.Models
{
    public class Guitar
    {
        public int GuitarId { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public string GuitarName { get; set; }
        public string Condition { get; set; }
        public decimal Price { get; set; }
        public Brand Brand { get; set; }
        public Category Category { get; set; }
    }
}