﻿// <auto-generated />
using System;
using GeoSpace.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GeoSpace.Infrastructure.Migrations
{
    [DbContext(typeof(GeoSpaceContext))]
    [Migration("20211003190153_RiskLevelColumn1")]
    partial class RiskLevelColumn1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GeoSpace.Core.Entities.ActiveEarthQuake", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("EpicentralDistanceKm")
                        .HasColumnType("int");

                    b.Property<double>("Lattitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<int>("Magnitude")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ActiveEarthQuakes");
                });

            modelBuilder.Entity("GeoSpace.Core.Entities.ActiveRainFall", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Hours")
                        .HasColumnType("float");

                    b.Property<double>("Lattitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("ActiveRainFalls");
                });

            modelBuilder.Entity("GeoSpace.Core.Entities.Landslide", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Casualities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Damages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Depth")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("DistanceFromFaults")
                        .HasColumnType("int");

                    b.Property<int>("DistanceFromRivers")
                        .HasColumnType("int");

                    b.Property<int>("Elevation")
                        .HasColumnType("int");

                    b.Property<int>("GeneralRiskLevel")
                        .HasColumnType("int");

                    b.Property<int>("GeologyPermeability")
                        .HasColumnType("int");

                    b.Property<string>("GovernmentId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LandUse")
                        .HasColumnType("int");

                    b.Property<string>("LandslideForcesDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandslideMaterialType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandslideMovementType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("LatitudeCenter")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Length")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("LinearMovement")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("LongitudeCenter")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RainfallCorrelation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReportedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("SlopeAngle")
                        .HasColumnType("real");

                    b.Property<int>("SlopeAspect")
                        .HasColumnType("int");

                    b.Property<decimal>("SlopeSteepness")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Volume")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Width")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Landslides");
                });

            modelBuilder.Entity("GeoSpace.Core.Entities.UserReport", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Latitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Longitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("NearbyCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReporterContact")
                        .HasColumnType("int");

                    b.Property<string>("ReporterName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserReport");
                });
#pragma warning restore 612, 618
        }
    }
}
