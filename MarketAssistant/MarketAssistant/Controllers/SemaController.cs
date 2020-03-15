using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarketAssistant.EF;
using MarketAssistant.Models;
using MarketAssistant.Models.VM;
using MarketAssistant.VM;
using Microsoft.AspNetCore.Mvc;

namespace MarketAssistant.Controllers
{
    public class SemaController : Controller
    {
        private readonly MyContext db;
        
        public SemaController(MyContext _db)
        {
            db = _db;
        }

        public IActionResult KreiranjeSeme()
        {
            List<MarketSemaVM> poadci = db.Market.Select(a => new MarketSemaVM
            {
                marketId = a.MarketID,
                naziv = a.Naziv
            }).ToList();

            MarketSemaVM_lista model = new MarketSemaVM_lista
            {
                lista = poadci
            };

            return View(model);
        }

        public class test
        {
            public int? idMarket { get; set; }
            public string Shema { get; set; }
        }

        public IActionResult SnimiSemu(test proba)
        {
            Sema temp = new Sema
            {
                Market_FK = proba.idMarket,
                sema = proba.Shema
            };

            db.Add(temp);
            db.SaveChanges();

            CoordinatesVM temp2 = new CoordinatesVM
            {
                marketId = proba.idMarket.Value,
                sema = proba.Shema
            };

            return RedirectToAction("DodajKoordinate", "Sema", new { content = temp2 });
        }


        public IActionResult DodajKoordinate(CoordinatesVM content2)
        {
            return View("DodajKoordinate",content2);
        }

        public class test2
        {
            public int marketId { get; set; }
            public string coord { get; set; }
            public string Shema { get; set; }
        }

        public IActionResult SnimiKoordinate(test2 t)
        {
            if (t.coord != null && t.marketId > 0)
            {
                Sema temp = new Sema
                {
                    Market_FK = t.marketId,
                    koordinatiZidova = t.coord
                };

                int d = t.Shema.Length - 167130;

                t.Shema = t.Shema.Remove(d);

                bool posjeduje = true, ulazi = true;

                while (ulazi && posjeduje)
                {
                    if (t.Shema.Contains("table"))
                    {
                        posjeduje = true;
                        ulazi = true;
                        d = t.Shema.Length - 10;
                        t.Shema = t.Shema.Remove(d);
                    }
                    else
                    {
                        posjeduje = false;
                        ulazi = false;
                    }
                    
                }

                temp.sema = t.Shema;
                db.Sema.Add(temp);
                db.SaveChanges();

                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index", "Home");
        }
    }
}