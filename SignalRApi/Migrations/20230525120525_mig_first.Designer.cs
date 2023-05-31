﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SignalRApi.DAL;

#nullable disable

namespace SignalRApi.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230525120525_mig_first")]
    partial class mig_first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SignalRApi.DAL.Visitor", b =>
                {
                    b.Property<int>("VisitorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("VisitorID"));

                    b.Property<int>("City")
                        .HasColumnType("integer");

                    b.Property<int>("CityVisitCount")
                        .HasColumnType("integer");

                    b.Property<DateTime>("VisitDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("VisitorID");

                    b.ToTable("Visitors");
                });
#pragma warning restore 612, 618
        }
    }
}
