using MarketAssistant.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketAssistant.EF
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }

        public DbSet<Administrator> Administrator { get; set; }
        public DbSet<Brend> Brend { get; set; }
        public DbSet<KorisnickiRacun> KorisnickiRacun { get; set; }
        public DbSet<Market> Market{ get; set; }
        public DbSet<market_proizvod> market_proizvod { get; set; }
        public DbSet<Proizvod> Proizvod{ get; set; }
        public DbSet<QR_Code> QR_Code { get; set; }
        public DbSet<Sema> Sema{ get; set; }
        public DbSet<Vrsta> Vrsta { get; set; }
    }
}
