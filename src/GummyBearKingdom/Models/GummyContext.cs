using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GummyBearKingdom.Models
{
    public class GummyContext : DbContext
    {
        public GummyContext()
        {
        }

        public DbSet<Gummy> Gummies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Gummies;integrated security=True");
        }

        public GummyContext(DbContextOptions<GummyContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
