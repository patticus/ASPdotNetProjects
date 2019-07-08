using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Nat20_DND_Dice.Models;

namespace Nat20_DND_Dice.Controllers
{
    public class StoreManagerController : Controller
    {
        private Nat20StoreDB db = new Nat20StoreDB();

        // GET: StoreManager
        public ActionResult Index()
        {
            var dicePacks = db.DicePacks.Include(d => d.Design).Include(d => d.Material);
            return View(dicePacks.ToList());
        }

        // GET: StoreManager/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DicePack dicePack = db.DicePacks.Find(id);
            if (dicePack == null)
            {
                return HttpNotFound();
            }
            return View(dicePack);
        }

        // GET: StoreManager/Create
        public ActionResult Create()
        {
            ViewBag.DesignId = new SelectList(db.Designs, "DesignId", "Name");
            ViewBag.MaterialId = new SelectList(db.Materials, "MaterialId", "MaterialType");
            return View();
        }

        // POST: StoreManager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DicePackId,MaterialId,DesignId,Color,Bag,Price")] DicePack dicePack)
        {
            if (ModelState.IsValid)
            {
                db.DicePacks.Add(dicePack);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DesignId = new SelectList(db.Designs, "DesignId", "Name", dicePack.DesignId);
            ViewBag.MaterialId = new SelectList(db.Materials, "MaterialId", "MaterialType", dicePack.MaterialId);
            return View(dicePack);
        }

        // GET: StoreManager/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DicePack dicePack = db.DicePacks.Find(id);
            if (dicePack == null)
            {
                return HttpNotFound();
            }
            ViewBag.DesignId = new SelectList(db.Designs, "DesignId", "Name", dicePack.DesignId);
            ViewBag.MaterialId = new SelectList(db.Materials, "MaterialId", "MaterialType", dicePack.MaterialId);
            return View(dicePack);
        }

        // POST: StoreManager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DicePackId,MaterialId,DesignId,Color,Bag,Price")] DicePack dicePack)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dicePack).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DesignId = new SelectList(db.Designs, "DesignId", "Name", dicePack.DesignId);
            ViewBag.MaterialId = new SelectList(db.Materials, "MaterialId", "MaterialType", dicePack.MaterialId);
            return View(dicePack);
        }

        // GET: StoreManager/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DicePack dicePack = db.DicePacks.Find(id);
            if (dicePack == null)
            {
                return HttpNotFound();
            }
            return View(dicePack);
        }

        // POST: StoreManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DicePack dicePack = db.DicePacks.Find(id);
            db.DicePacks.Remove(dicePack);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
