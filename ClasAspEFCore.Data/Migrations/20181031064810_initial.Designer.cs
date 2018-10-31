﻿// <auto-generated />
using System;
using ClasAspEFCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClasAspEFCore.Data.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20181031064810_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspEFCore.Domain.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AreaCode");

                    b.Property<string>("Name");

                    b.Property<int>("ProviceId");

                    b.Property<int?>("ProvinceId");

                    b.HasKey("Id");

                    b.HasIndex("ProvinceId");

                    b.ToTable("Cites");
                });

            modelBuilder.Entity("AspEFCore.Domain.Province", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("Population");

                    b.HasKey("Id");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("AspEFCore.Domain.City", b =>
                {
                    b.HasOne("AspEFCore.Domain.Province", "Province")
                        .WithMany("Cites")
                        .HasForeignKey("ProvinceId");
                });
#pragma warning restore 612, 618
        }
    }
}
