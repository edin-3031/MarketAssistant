using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using test_qr_code.EF;
using test_qr_code.Models;

namespace test_qr_code.Controllers
{
    public class MarketController : Controller
    {
        private readonly MyContext db;

        public MarketController(MyContext _db)
        {
            db = _db;
        }

        public IActionResult test()
        {
            return View();
        }

        public IActionResult Index(int id)
        {
            ViewData["test"] = db.Market.Where(a => a.MarketID == id).FirstOrDefault();

            return View();
        }

        public IActionResult DodajSema(int id)
        {
            ViewData["market"] = db.Market.Where(a => a.MarketID == id).FirstOrDefault();

            return View();
        }

        public IActionResult Sema(int marketId)
        {
            ViewData["sema"] = db.Sema.Where(a => a.Market_FK == marketId).FirstOrDefault();

            return View();
        }

        public IActionResult DodajSnimiSema(int marketId, string sema)
        {
            Sema tmp = new Sema
            {
                Market_FK=marketId,
                Sadrzaj=sema
            };


            db.Sema.Add(tmp);
            db.SaveChanges();

            return Redirect("/Market/Sema?marketId=" + marketId);
        }
    }
}