﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TargetDataBase.Data;

#nullable disable

namespace TargetDataBase.Migrations
{
    [DbContext(typeof(TargetDataBaseContext))]
    [Migration("20220801190801_CycloCode")]
    partial class CycloCode
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TargetDataBase.Models.CS30", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime?>("BombardingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BombardingName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CyclotronCode")
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

                    b.ToTable("CS30", (string)null);
                });

            modelBuilder.Entity("TargetDataBase.Models.CS30Test", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("CS30ID")
                        .HasColumnType("int");

                    b.Property<string>("HNum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Result")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CS30ID");

                    b.ToTable("CS30Test", (string)null);
                });

            modelBuilder.Entity("TargetDataBase.Models.IBA", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime?>("BombardingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BombardingName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CyclotronCode")
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

                    b.Property<string>("WarehouseCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("WarehouseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("WarehouseLotNum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WarehouseName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("IBA", (string)null);
                });

            modelBuilder.Entity("TargetDataBase.Models.IBATest", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("HNum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IBAID")
                        .HasColumnType("int");

                    b.Property<string>("Result")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("IBAID");

                    b.ToTable("IBATest", (string)null);
                });

            modelBuilder.Entity("TargetDataBase.Models.TR30", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime?>("BombardingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BombardingName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CFaceCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CycloCode")
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

                    b.Property<string>("WBodyCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WBodyLotNum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WFaceCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WFaceLotNum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("WarehouseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("WarehouseName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TR30", (string)null);
                });

            modelBuilder.Entity("TargetDataBase.Models.TR30Test", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("HNum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Result")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TR30ID")
                        .HasColumnType("int");

                    b.Property<string>("TestType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("TR30ID");

                    b.ToTable("TR30Test", (string)null);
                });

            modelBuilder.Entity("TargetDataBase.Models.CS30Test", b =>
                {
                    b.HasOne("TargetDataBase.Models.CS30", "CS30")
                        .WithMany("CS30Tests")
                        .HasForeignKey("CS30ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CS30");
                });

            modelBuilder.Entity("TargetDataBase.Models.IBATest", b =>
                {
                    b.HasOne("TargetDataBase.Models.IBA", "IBA")
                        .WithMany("IBATests")
                        .HasForeignKey("IBAID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IBA");
                });

            modelBuilder.Entity("TargetDataBase.Models.TR30Test", b =>
                {
                    b.HasOne("TargetDataBase.Models.TR30", "TR30")
                        .WithMany("TR30Tests")
                        .HasForeignKey("TR30ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TR30");
                });

            modelBuilder.Entity("TargetDataBase.Models.CS30", b =>
                {
                    b.Navigation("CS30Tests");
                });

            modelBuilder.Entity("TargetDataBase.Models.IBA", b =>
                {
                    b.Navigation("IBATests");
                });

            modelBuilder.Entity("TargetDataBase.Models.TR30", b =>
                {
                    b.Navigation("TR30Tests");
                });
#pragma warning restore 612, 618
        }
    }
}