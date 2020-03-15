using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test_qr_code.Models;

namespace test_qr_code.EF
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }

        public DbSet<Market> Market { get; set; }
        public DbSet<Sema> Sema { get; set; }
    }
}
