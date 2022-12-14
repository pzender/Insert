// <auto-generated />
using System;
using InsertRekrutacja.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InsertRekrutacja.Migrations
{
    [DbContext(typeof(CurrencyDbContext))]
    [Migration("20220915055359_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("InsertRekrutacja.Models.CurrencyRate", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("TEXT");

                    b.Property<double>("AvgRate")
                        .HasColumnType("REAL");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("TEXT");

                    b.HasKey("Code");

                    b.ToTable("CurrencyRates");
                });
#pragma warning restore 612, 618
        }
    }
}
