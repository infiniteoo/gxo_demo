﻿// <auto-generated />
using InventoryAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InventoryAPI.Migrations
{
    [DbContext(typeof(InventoryContext))]
    [Migration("20241027174604_ResetDatabase")]
    partial class ResetDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SupplierId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ItemId");

                    b.ToTable("Items");
                });
#pragma warning restore 612, 618
        }
    }
}