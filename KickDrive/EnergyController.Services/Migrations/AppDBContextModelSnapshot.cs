﻿// <auto-generated />
using System;
using EnergyController.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EnergyController.Services.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EnergyController.Models.Driver", b =>
                {
                    b.Property<int>("DriverId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DriverName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FrontPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("INE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("License")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NSS")
                        .HasColumnType("int");

                    b.Property<string>("ProfilePhoto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DriverId");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("EnergyController.Models.Routes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adults")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateAT")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DriverId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Incidents")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NYES")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameSup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumSup")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateAT")
                        .HasColumnType("datetime2");

                    b.Property<int?>("VehicleId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("timeE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("timeS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DriverId");

                    b.HasIndex("VehicleId");

                    b.ToTable("Route");
                });

            modelBuilder.Entity("EnergyController.Models.Vehicles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CapPerson")
                        .HasColumnType("int");

                    b.Property<int>("CapTon")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("DocLeg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NMotor")
                        .HasColumnType("int");

                    b.Property<int>("NProp")
                        .HasColumnType("int");

                    b.Property<int>("NRegist")
                        .HasColumnType("int");

                    b.Property<int>("NSerie")
                        .HasColumnType("int");

                    b.Property<string>("OfExp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Placas")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("TComb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipLlantas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipServ")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateAT")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("EnergyController.Models.Routes", b =>
                {
                    b.HasOne("EnergyController.Models.Driver", "Driver")
                        .WithMany("Route")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnergyController.Models.Vehicles", "Vehicles")
                        .WithMany("Route")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
