﻿// <auto-generated />
using System;
using MenuApp.MenuService.EntityFramework.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MenuApp.MenuService.EntityFramework.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210323134002_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("MenuApp.MenuService.Logic.Entities.Ingredient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("MenuItemId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("MenuItemId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("MenuApp.MenuService.Logic.Entities.MenuItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("MenuItems");
                });

            modelBuilder.Entity("MenuApp.MenuService.Logic.Entities.Ingredient", b =>
                {
                    b.HasOne("MenuApp.MenuService.Logic.Entities.MenuItem", null)
                        .WithMany("Ingredients")
                        .HasForeignKey("MenuItemId");
                });

            modelBuilder.Entity("MenuApp.MenuService.Logic.Entities.MenuItem", b =>
                {
                    b.Navigation("Ingredients");
                });
#pragma warning restore 612, 618
        }
    }
}