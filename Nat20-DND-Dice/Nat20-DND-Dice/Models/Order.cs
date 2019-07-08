using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Nat20_DND_Dice.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        [Required (ErrorMessage = "You must enter a username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "You must enter a First Name")]
        [StringLength(20)]
        [Display(Name = "*First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "You must enter a Last Name")]
        [StringLength(20)]
        [Display(Name = "*Last Name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [StringLength(10, MinimumLength = 5)]
        [Display(Name = "Zip")]
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Not a valid email address")]
        public string Email { get; set; }
        [Required]
        [Compare("Email")]
        [Display(Name = "Confirm Email")]
        public string EmailConfirm { get; set; }
        public decimal Total { get; set; }
    }
}