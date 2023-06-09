﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using health_fitness.Models;

#nullable disable

namespace health_fitness.Migrations
{
    [DbContext(typeof(stepscontext))]
    partial class stepscontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("health_fitness.Models.StepInfo", b =>
                {
                    b.Property<DateTime>("time")
                        .HasColumnType("datetime2");

                    b.Property<int>("stepsnumber")
                        .HasColumnType("int");

                    b.HasKey("time");

                    b.ToTable("StepSInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
