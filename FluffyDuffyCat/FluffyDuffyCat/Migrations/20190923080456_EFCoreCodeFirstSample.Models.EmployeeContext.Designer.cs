﻿// <auto-generated />
using FluffyDuffyCat.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FluffyDuffyCat.Migrations
{
    [DbContext(typeof(FluffyCatDbContext))]
    [Migration("20190923080456_EFCoreCodeFirstSample.Models.EmployeeContext")]
    partial class EFCoreCodeFirstSampleModelsEmployeeContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FluffyDuffyCat.Data.Models.Cat", b =>
                {
                    b.Property<int>("CatId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<string>("Breed");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name");

                    b.HasKey("CatId");

                    b.ToTable("Cats");
                });
#pragma warning restore 612, 618
        }
    }
}
