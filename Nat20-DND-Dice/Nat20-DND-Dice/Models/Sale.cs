using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nat20_DND_Dice.Models
{
    public class Sale
    {
        public int SaleId { get; set; }
        public int DicePackId { get; set; }
        public int CustomerId { get; set; }
        public string Date { get; set; }
        public string DeliveryType { get; set; }
    
    }
}