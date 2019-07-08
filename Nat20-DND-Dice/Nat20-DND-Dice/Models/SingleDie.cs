using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nat20_DND_Dice.Models
{
    public class SingleDie
    {
        public int SingleDieId { get; set; }
        public int MaterialId { get; set; }
        public int DesignId { get; set; }
        public int SideNumber { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public Material Material { get; set; }
        public Design Design { get; set; }
    }
}