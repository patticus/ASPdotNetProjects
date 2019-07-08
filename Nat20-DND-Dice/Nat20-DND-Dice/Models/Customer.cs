using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nat20_DND_Dice.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public int DicePackId { get; set; }
        public int SingleDieId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}