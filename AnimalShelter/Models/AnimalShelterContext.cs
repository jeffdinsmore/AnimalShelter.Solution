using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
      : base(options)
    {
    }
    public DbSet<Animal> Animals { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Macy", Species = "Dog", Breed = "Cavapoo", AgeYears = 0, AgeMonths = 4, Gender = "Female" },
          new Animal { AnimalId = 2, Name = "Lucy", Species = "Dog", Breed = "Cocker Spaniel", AgeYears = 0, AgeMonths = 6, Gender = "Female" },
          new Animal { AnimalId = 3, Name = "River", Species = "Cat", Breed = "Tabby", AgeYears = 1, AgeMonths = 2, Gender = "Female" },
          new Animal { AnimalId = 4, Name = "Zeus", Species = "Dog", Breed = "German Sheppard", AgeYears = 0, AgeMonths = 3, Gender = "Male" },
          new Animal { AnimalId = 5, Name = "Dave", Species = "Cat", Breed = "Birman", AgeYears = 1, AgeMonths = 3, Gender = "Male" },
          new Animal { AnimalId = 6, Name = "Carl", Species = "Cat", Breed = "American Bobtail", AgeYears = 1, AgeMonths = 4, Gender = "Male" },
          new Animal { AnimalId = 7, Name = "Suzie", Species = "Cat", Breed = "Bengal", AgeYears = 1, AgeMonths = 0, Gender = "Female" },
          new Animal { AnimalId = 8, Name = "Rex", Species = "Dog", Breed = "Australian Kelpie", AgeYears = 0, AgeMonths = 2, Gender = "Male" },
          new Animal { AnimalId = 9, Name = "Winnie", Species = "Cat", Breed = "Bombay", AgeYears = 0, AgeMonths = 9, Gender = "Female" },
          new Animal { AnimalId = 10, Name = "Cocoa", Species = "Cat", Breed = "Burmese", AgeYears = 0, AgeMonths = 8, Gender = "Male" },
          new Animal { AnimalId = 11, Name = "Coffee", Species = "Dog", Breed = "Apple Head Chihuahua", AgeYears = 3, AgeMonths = 8, Gender = "Female" },
          new Animal { AnimalId = 12, Name = "Mocha", Species = "Dog", Breed = "Miniature Pinscher", AgeYears = 4, AgeMonths = 4, Gender = "Male" }
        );
    }
  }
}