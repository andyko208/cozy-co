﻿// <auto-generated />
using System;
using CozyData.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CozyData.Migrations
{
    [DbContext(typeof(CozyDbContext))]
    [Migration("20190205024251_added-model-seeding")]
    partial class addedmodelseeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cozy.Domain.Models.Home", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<int>("HomeId");

                    b.Property<string>("ImageURL");

                    b.Property<string>("LandlordId");

                    b.Property<string>("State");

                    b.HasKey("Id");

                    b.HasIndex("LandlordId");

                    b.ToTable("Homes");
                });

            modelBuilder.Entity("Cozy.Domain.Models.Landlord", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Firstname");

                    b.Property<string>("Lastname");

                    b.HasKey("Id");

                    b.ToTable("Landlords");
                });

            modelBuilder.Entity("Cozy.Domain.Models.Lease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate");

                    b.Property<int>("HomeId");

                    b.Property<double>("RentPrice");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("HomeId");

                    b.HasIndex("TenantId");

                    b.ToTable("Leases");
                });

            modelBuilder.Entity("Cozy.Domain.Models.Maintenance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<int>("HomeId");

                    b.Property<int>("MaintenanceStatusId");

                    b.Property<int>("State");

                    b.Property<string>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("HomeId");

                    b.HasIndex("MaintenanceStatusId");

                    b.HasIndex("TenantId");

                    b.ToTable("Maintenances");
                });

            modelBuilder.Entity("Cozy.Domain.Models.MaintenanceStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("MaintenanceStatuses");

                    b.HasData(
                        new { Id = 1, Description = "New" },
                        new { Id = 2, Description = "In Progress" },
                        new { Id = 3, Description = "Closed" },
                        new { Id = 4, Description = "Cancelled" }
                    );
                });

            modelBuilder.Entity("Cozy.Domain.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount");

                    b.Property<int>("LeaseId");

                    b.Property<DateTime>("PaidOn");

                    b.Property<string>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("LeaseId");

                    b.HasIndex("TenantId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Cozy.Domain.Models.Tenant", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<double>("Income");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("Tenants");
                });

            modelBuilder.Entity("Cozy.Domain.Models.Home", b =>
                {
                    b.HasOne("Cozy.Domain.Models.Landlord", "Landlord")
                        .WithMany("Homes")
                        .HasForeignKey("LandlordId");
                });

            modelBuilder.Entity("Cozy.Domain.Models.Lease", b =>
                {
                    b.HasOne("Cozy.Domain.Models.Home", "Home")
                        .WithMany()
                        .HasForeignKey("HomeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Cozy.Domain.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId");
                });

            modelBuilder.Entity("Cozy.Domain.Models.Maintenance", b =>
                {
                    b.HasOne("Cozy.Domain.Models.Home", "Home")
                        .WithMany()
                        .HasForeignKey("HomeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Cozy.Domain.Models.MaintenanceStatus", "MaintenanceStatus")
                        .WithMany()
                        .HasForeignKey("MaintenanceStatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Cozy.Domain.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId");
                });

            modelBuilder.Entity("Cozy.Domain.Models.Payment", b =>
                {
                    b.HasOne("Cozy.Domain.Models.Lease", "Lease")
                        .WithMany()
                        .HasForeignKey("LeaseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Cozy.Domain.Models.Tenant")
                        .WithMany("Payments")
                        .HasForeignKey("TenantId");
                });
#pragma warning restore 612, 618
        }
    }
}
