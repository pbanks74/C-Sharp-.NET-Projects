using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            // sets base quote
            int quote = 50;

            //determines insuree age
            var today = DateTime.Today;
            var age = today.Year - insuree.DateOfBirth.Year;

            // adds $50 if user is 18 or younger
            if (age <= 18)
            {
                quote = quote + 100;
            }
            // adds $50 if under 25 but over 18
            else if (age < 25 && age >= 19)
            {
                quote = quote + 50;
            }
            // adds $25 if user is over 25
            else if (age > 25)
            {
                quote = quote + 25;
            }
            //adds $25 if car's year is before 2000
            if (insuree.CarYear < 2000)
            {
                quote = quote + 25;
            }
            //adds $25 if car's year is after 2015
            else if (insuree.CarYear > 2015)
            {
                quote = quote + 25;
            }
            // adds $25 if car's Make is a Porsche
            if (insuree.CarMake == "Porsche")
            {
                quote = quote + 25;
            }
            // adds additional $25 if car's make is a Porsche and model is 911 Carrera
            else if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera")
            {
                quote = quote + 25;
            }
            // Adds $10 for every speeding ticket
            for (int i = 0; i < insuree.SpeedingTickets; i++)
            {
                quote = quote + 10;
            }
            // Adds 25% if user has had DUI
            if (insuree.DUI == true)
            {
                double duiCost = quote * .25;
                int intDuiCost = Convert.ToInt32(duiCost);
                quote = quote + intDuiCost;
            }
            // Adds 50% for full coverage 
            if (insuree.CoverageType == true)
            {
                double coverageCost = quote * .50;
                int intCoverageCost = Convert.ToInt32(coverageCost);
                quote = quote + intCoverageCost;
            }
           
            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("Quote", insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
