using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using PJGuitarStore.Models;

namespace PJGuitarStore.Controllers
{
    public class StoreController : Controller
    {
        public ActionResult Index()
        {
            var guitars = GetGuitars();

            return View(guitars);
        }

        [Authorize]
        public ActionResult Buy(int id)
        {
            var guitar = GetGuitars().Single(a => a.GuitarId == id);

            return View(guitar);
        }

        private static List<Guitar> GetGuitars()
        {
            var guitars = new List<Guitar>{
                new Guitar { GuitarId = 1, GuitarName = "Epiphone Les Paul", Price = 599.99M},
                new Guitar { GuitarId = 2, GuitarName = "Gibson Les Paul Silverburst", Price = 3899.99M},
                new Guitar { GuitarId = 3, GuitarName = "Fender Stratocaster", Price = 599.99M },
                new Guitar { GuitarId = 4, GuitarName = "Ibanez Talman", Price = 699.99M },
                new Guitar { GuitarId = 5, GuitarName = "Martin Vintage 1970", Price = 2299.99M },
                new Guitar { GuitarId = 6, GuitarName = "Taylor DLX Grand Auditorium", Price = 1399.99M },
            };
            return guitars;
        }
    }
}
