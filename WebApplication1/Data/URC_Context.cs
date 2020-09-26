using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class URC_Context : DbContext
    {
        public URC_Context(DbContextOptions<URC_Context> options)
            : base(options)
        {
        }

        public DbSet<Opportunity> Opportunity { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Opportunity>().ToTable("Opportunity");
        }
    }
}
