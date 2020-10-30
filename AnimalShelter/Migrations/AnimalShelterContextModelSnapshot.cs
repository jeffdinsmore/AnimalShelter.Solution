﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace animalshelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    partial class AnimalShelterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AgeMonths");

                    b.Property<int>("AgeYears");

                    b.Property<string>("Breed")
                        .IsRequired();

                    b.Property<string>("Gender")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Species")
                        .IsRequired();

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            AgeMonths = 4,
                            AgeYears = 0,
                            Breed = "Cavapoo",
                            Gender = "Female",
                            Name = "Macy",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 2,
                            AgeMonths = 6,
                            AgeYears = 0,
                            Breed = "Cocker Spaniel",
                            Gender = "Female",
                            Name = "Lucy",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 3,
                            AgeMonths = 2,
                            AgeYears = 1,
                            Breed = "Tabby",
                            Gender = "Female",
                            Name = "River",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 4,
                            AgeMonths = 3,
                            AgeYears = 0,
                            Breed = "German Sheppard",
                            Gender = "Male",
                            Name = "Zeus",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 5,
                            AgeMonths = 3,
                            AgeYears = 1,
                            Breed = "Birman",
                            Gender = "Male",
                            Name = "Dave",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 6,
                            AgeMonths = 4,
                            AgeYears = 1,
                            Breed = "American Bobtail",
                            Gender = "Male",
                            Name = "Carl",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 7,
                            AgeMonths = 0,
                            AgeYears = 1,
                            Breed = "Bengal",
                            Gender = "Female",
                            Name = "Suzie",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 8,
                            AgeMonths = 2,
                            AgeYears = 0,
                            Breed = "Australian Kelpie",
                            Gender = "Male",
                            Name = "Rex",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 9,
                            AgeMonths = 9,
                            AgeYears = 0,
                            Breed = "Bombay",
                            Gender = "Female",
                            Name = "Winnie",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 10,
                            AgeMonths = 8,
                            AgeYears = 0,
                            Breed = "Burmese",
                            Gender = "Male",
                            Name = "Cocoa",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 11,
                            AgeMonths = 8,
                            AgeYears = 3,
                            Breed = "Apple Head Chihuahua",
                            Gender = "Female",
                            Name = "Coffee",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 12,
                            AgeMonths = 4,
                            AgeYears = 4,
                            Breed = "Miniature Pinscher",
                            Gender = "Male",
                            Name = "Mocha",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 13,
                            AgeMonths = 7,
                            AgeYears = 22,
                            Breed = "Siamese",
                            Gender = "Female",
                            Name = "Randoveer",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 14,
                            AgeMonths = 7,
                            AgeYears = 1,
                            Breed = "Bassett Hound",
                            Gender = "Male",
                            Name = "Mr. Bassett Hound",
                            Species = "Dog"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
