using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var quoteinfo = db.Insurees;
                var quotes = new List<Insuree>();
                foreach (var quote in quoteinfo)
                {
                    var quoteInfo = new Insuree();
                    quoteInfo.Id = quote.Id;
                    quoteInfo.FirstName = quote.FirstName;
                    quoteInfo.LastName = quote.LastName;
                    quoteInfo.EmailAddress = quote.EmailAddress;
                    quoteInfo.Quote = quote.Quote;
                    quotes.Add(quoteInfo);
                }

                return View(quotes);
            }
        }
    }
}