using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WardrobeProject.Models;

namespace WardrobeProject.Controllers
{
    public class TypeOfClothingsController : Controller
    {
        private WardrobeProjectContext db = new WardrobeProjectContext();

        // GET: TypeOfClothings
        public ActionResult Index()
        {
            return View(db.TypeOfClothings.ToList());
        }

        // GET: TypeOfClothings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeOfClothing typeOfClothing = db.TypeOfClothings.Find(id);
            if (typeOfClothing == null)
            {
                return HttpNotFound();
            }
            return View(typeOfClothing);
        }

        // GET: TypeOfClothings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TypeOfClothings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TypeOfClothingID,ClothingType")] TypeOfClothing typeOfClothing)
        {
            if (ModelState.IsValid)
            {
                db.TypeOfClothings.Add(typeOfClothing);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(typeOfClothing);
        }

        // GET: TypeOfClothings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeOfClothing typeOfClothing = db.TypeOfClothings.Find(id);
            if (typeOfClothing == null)
            {
                return HttpNotFound();
            }
            return View(typeOfClothing);
        }

        // POST: TypeOfClothings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TypeOfClothingID,ClothingType")] TypeOfClothing typeOfClothing)
        {
            if (ModelState.IsValid)
            {
                db.Entry(typeOfClothing).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(typeOfClothing);
        }

        // GET: TypeOfClothings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeOfClothing typeOfClothing = db.TypeOfClothings.Find(id);
            if (typeOfClothing == null)
            {
                return HttpNotFound();
            }
            return View(typeOfClothing);
        }

        // POST: TypeOfClothings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TypeOfClothing typeOfClothing = db.TypeOfClothings.Find(id);
            db.TypeOfClothings.Remove(typeOfClothing);
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
