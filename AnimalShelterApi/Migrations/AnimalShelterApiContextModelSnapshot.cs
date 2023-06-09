﻿// <auto-generated />
using AnimalShelterApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AnimalShelterApi.Migrations
{
    [DbContext(typeof(AnimalShelterApiContext))]
    partial class AnimalShelterApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelterApi.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Note")
                        .HasColumnType("longtext");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Weight")
                        .HasColumnType("double");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Name = "Sparkles",
                            Note = "Loves Yarn a bit too much",
                            Sex = "Female",
                            Type = "Cat",
                            Weight = 17.5
                        },
                        new
                        {
                            AnimalId = 2,
                            Name = "Lizzy",
                            Note = "Loves baking in the sun",
                            Sex = "Male",
                            Type = "Iguana",
                            Weight = 5.0
                        },
                        new
                        {
                            AnimalId = 3,
                            Name = "Daisy",
                            Note = "Has no thoughts",
                            Sex = "Female",
                            Type = "Dog",
                            Weight = 50.5
                        },
                        new
                        {
                            AnimalId = 4,
                            Name = "Hank",
                            Note = "Needs anger management",
                            Sex = "male",
                            Type = "Chicken",
                            Weight = 6.5
                        },
                        new
                        {
                            AnimalId = 5,
                            Name = "Beatrice",
                            Note = "Loves eating living her best life",
                            Sex = "Female",
                            Type = "Cat",
                            Weight = 40.5
                        },
                        new
                        {
                            AnimalId = 6,
                            Name = "Turty",
                            Note = "Loves lettuce and riding in the basket of a bicycle",
                            Sex = "Female",
                            Type = "Turtle",
                            Weight = 1.5
                        },
                        new
                        {
                            AnimalId = 7,
                            Name = "Rabby",
                            Note = "Meows sometimes",
                            Sex = "Male",
                            Type = "Rabbit",
                            Weight = 2.0
                        },
                        new
                        {
                            AnimalId = 8,
                            Name = "Hank II",
                            Note = "Hanks Daughter",
                            Sex = "Female",
                            Type = "Chicken",
                            Weight = 5.5
                        },
                        new
                        {
                            AnimalId = 9,
                            Name = "Raphael",
                            Note = "Why we have a tree at our shelter we don't know but its available",
                            Sex = "male",
                            Type = "Ficus",
                            Weight = 1.5
                        },
                        new
                        {
                            AnimalId = 10,
                            Name = "Napoleon",
                            Note = "Rumored to be the reincarnation of the French General",
                            Sex = "male",
                            Type = "Mouse",
                            Weight = 1.5
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
