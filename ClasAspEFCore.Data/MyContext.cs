﻿using AspEFCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClasAspEFCore.Data
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasOne(x => x.Province).WithMany(x => x.Cites)
                .HasForeignKey(x => x.ProviceId);
            modelBuilder.Entity<CityCompany>()
                .HasKey(x => new{x.CityId,x.CompanyId});
            modelBuilder.Entity<CityCompany>()
                .HasOne(x => x.City).WithMany(x => x.CityCompanies).HasForeignKey(x => x.CityId);
            modelBuilder.Entity<CityCompany>()
                .HasOne(x => x.Company).WithMany(x => x.CityCompanies).HasForeignKey(x => x.CompanyId);
            modelBuilder.Entity<Mayor>()
                .HasOne(x => x.City).WithOne(x => x.Mayor).HasForeignKey<Mayor>(x => x.CityId);
                
        }
        public DbSet<City> Cites { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<CityCompany> CityCompanies { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Mayor> Mayors { get; set; }
        
    }
}
