using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PiePizza4.Models
{
    public class PiePizzariaContext : DbContext
    {
        public PiePizzariaContext(DbContextOptions<PiePizzariaContext> options)
            : base(options)
        {
        }

        public DbSet<PiePizza4.Models.Pie> Pie { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pie>().ToTable("Pie");


        }
    }
}
