﻿// <auto-generated />
using System;
using MVCHOT2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVCHOT2.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20230227202427_Migration02-Categories")]
    partial class Migration02Categories
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MVCHOT2.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Accessories"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Bikes"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Clothing"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Components"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Car racks"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryName = "Wheels"
                        });
                });

            modelBuilder.Entity("MVCHOT2.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"));

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("ProductDescLong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDescShort")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductQty")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            CategoryID = 4,
                            ProductDescLong = "",
                            ProductDescShort = "",
                            ProductImage = "",
                            ProductName = "AeroFlo ATB Wheels",
                            ProductPrice = 189m,
                            ProductQty = 40
                        },
                        new
                        {
                            ProductID = 2,
                            CategoryID = 1,
                            ProductDescLong = "",
                            ProductDescShort = "",
                            ProductImage = "",
                            ProductName = "Clear Shade 85-T Glasses",
                            ProductPrice = 45m,
                            ProductQty = 14
                        },
                        new
                        {
                            ProductID = 3,
                            CategoryID = 4,
                            ProductDescLong = "",
                            ProductDescShort = "",
                            ProductImage = "",
                            ProductName = "Cosmic Elite Road Warrior Wheels",
                            ProductPrice = 165m,
                            ProductQty = 22
                        },
                        new
                        {
                            ProductID = 4,
                            CategoryID = 1,
                            ProductDescLong = "",
                            ProductDescShort = "",
                            ProductImage = "",
                            ProductName = "Cycle-Doc Pro Repair Stand",
                            ProductPrice = 166m,
                            ProductQty = 12
                        },
                        new
                        {
                            ProductID = 5,
                            CategoryID = 1,
                            ProductDescLong = "",
                            ProductDescShort = "",
                            ProductImage = "",
                            ProductName = "Dog Ear Aero-Flow Floor Pump",
                            ProductPrice = 5m,
                            ProductQty = 25
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
