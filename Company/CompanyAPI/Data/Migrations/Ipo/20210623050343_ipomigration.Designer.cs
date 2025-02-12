﻿// <auto-generated />
using CompanyAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CompanyAPI.Data.Migrations.Ipo
{
    [DbContext(typeof(IpoContext))]
    [Migration("20210623050343_ipomigration")]
    partial class ipomigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CompanyAPI.Entities.Ipo", b =>
                {
                    b.Property<int>("IpoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BiddingDates")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IssueSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManagingDirector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PriceRange")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IpoId");

                    b.ToTable("Ipo");
                });
#pragma warning restore 612, 618
        }
    }
}
