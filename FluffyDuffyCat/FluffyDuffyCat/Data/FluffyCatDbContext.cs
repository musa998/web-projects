using FluffyDuffyCat.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluffyDuffyCat.Models;

namespace FluffyDuffyCat.Data
{
    public class FluffyCatDbContext : DbContext
    {
        public FluffyCatDbContext()
        {
        }

        public FluffyCatDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Cat> Cats { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=FluffyCatDB;Integrated Security=True");
        }
    }
}
