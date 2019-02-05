using Cozy.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CozyData.Context
{
    public class CozyDbContext : DbContext
    {
       
        public DbSet<Landlord> Landlords { get; set; }
        public DbSet<Home> Homes { get; set; }
        public DbSet<Lease> Leases { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<MaintenanceStatus> MaintenanceStatuses { get; set; }

        // Setting up the provider (SQL server) and location of the Database
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Server=(localdb)\projectsv13;Database=cozy;Trusted_Connection=True");
        }
        // Seeding - populate db with initial data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MaintenanceStatus>().HasData(
                new MaintenanceStatus { Id = 1, Description = "New" },
                new MaintenanceStatus { Id = 2, Description = "In Progress" },
                new MaintenanceStatus { Id = 3, Description = "Closed" },
                new MaintenanceStatus { Id = 4, Description = "Cancelled" }
                );

        }
    }
}
