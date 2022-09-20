﻿// <auto-generated />
using System;
using InsertRekrutacja.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InsertRekrutacja.Migrations
{
    [DbContext(typeof(CurrencyDbContext))]
    partial class CurrencyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("InsertRekrutacja.Models.CurrencyRate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<double>("AvgRate")
                        .HasColumnType("REAL");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CurrencyRates");
                });
#pragma warning restore 612, 618
        }
    }
}