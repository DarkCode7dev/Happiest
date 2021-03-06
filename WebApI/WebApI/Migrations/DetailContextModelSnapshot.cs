﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApI.Models;

namespace WebApI.Migrations
{
    [DbContext(typeof(DetailContext))]
    partial class DetailContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("WebApI.Models.Members", b =>
                {
                    b.Property<int>("GMId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardOwnerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Money")
                        .HasColumnType("int");

                    b.HasKey("GMId");

                    b.ToTable("Members");
                });
#pragma warning restore 612, 618
        }
    }
}
