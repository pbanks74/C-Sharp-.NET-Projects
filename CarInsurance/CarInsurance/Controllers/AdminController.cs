using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                //linq
                var quotes = (from c in db.Insurees
                              select c).ToList();
                var insurees = new List<Insuree>();
                foreach (var quote in quotes)
                {
                    var insuree = new Insuree();
                    insuree.FirstName = quote.FirstName;
                    insuree.LastName = quote.FirstName;
                    insuree.EmailAddress = quote.EmailAddress;
                    insuree.Quote = quote.Quote;
                    insurees.Add(insuree);
                }
                return View(insurees);
            }
        }
    }
}