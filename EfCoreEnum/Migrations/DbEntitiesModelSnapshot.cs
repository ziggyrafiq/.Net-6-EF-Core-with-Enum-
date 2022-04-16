﻿// <auto-generated />
using System;
using EnumWithEfCoreDemo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EnumWithEfCoreDemo.Migrations
{
    [DbContext(typeof(DbEntities))]
    partial class DbEntitiesModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EnumWithEfCoreDemo.Models.Task", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b4dcd04a-0572-403a-bb53-1a4dc6aa7bc2"),
                            Description = "This is my 1st Task Description",
                            Name = "My 1st Task",
                            Priority = 3,
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("89bdf257-4e21-47c7-a92d-47efbfd1cd54"),
                            Description = "This is my 2nd Task Description",
                            Name = "My 2nd Task",
                            Priority = 3,
                            Status = 3
                        },
                        new
                        {
                            Id = new Guid("525d343f-dfd2-44fc-b1fd-ae9e7ab087cf"),
                            Description = "This is my 3rd Task Description",
                            Name = "My 3rd Task",
                            Priority = 3,
                            Status = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
