﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SharpNS.Models.Database;

namespace SharpNS.Migrations
{
    [DbContext(typeof(DNSContext))]
    partial class DNSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6");

            modelBuilder.Entity("SharpNS.Models.Database.Record", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Domain")
                        .HasColumnType("TEXT");

                    b.Property<string>("IpAddress")
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Domain", "Type")
                        .IsUnique();

                    b.ToTable("Records");
                });
#pragma warning restore 612, 618
        }
    }
}
