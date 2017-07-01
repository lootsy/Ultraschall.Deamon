using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Ultraschall.Deamon.Data;

namespace Ultraschall.Deamon.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170701214945_AddValueStore")]
    partial class AddValueStore
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("Ultraschall.Deamon.Data.Models.Value", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.HasKey("Id");

                    b.ToTable("Values");
                });
        }
    }
}
