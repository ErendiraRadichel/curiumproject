﻿// <auto-generated />
using System;
using APIHotProducts.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIHotProducts.Migrations
{
    [DbContext(typeof(APIHotProductsContext))]
    [Migration("20220711145628_IntToStr")]
    partial class IntToStr
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("APIHotProducts.Models.Target", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime?>("BombardingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BombardingName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CyclotronDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CyclotronName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlatingCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PlatingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PlatingLotNum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlatingName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ProcessingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProcessingLotNum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProcessingName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Quantity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TargetNum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TargetType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WarehouseCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("WarehouseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("WarehouseLotNum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WarehouseName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Target");
                });
#pragma warning restore 612, 618
        }
    }
}