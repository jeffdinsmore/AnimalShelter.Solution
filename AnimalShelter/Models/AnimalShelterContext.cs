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
          new Animal { AnimalId = 1, Name = "Macy", Species = "Dog", Breed = "Cavapoo", Age = 4, Gender = "Female" },
          new Animal { AnimalId = 2, Name = "Lucy", Species = "Dog", Breed = "Cocker Spaniel", Age = 2, Gender = "Female" },
          new Animal { AnimalId = 3, Name = "River", Species = "Cat", Breed = "Tabby", Age = 1, Gender = "Female" },
          new Animal { AnimalId = 4, Name = "Zeus", Species = "Dog", Breed = "German Sheppard", Age = 3, Gender = "Male" },
          new Animal { AnimalId = 5, Name = "Dave", Species = "Cat", Breed = "Birman", Age = 1, Gender = "Male" },
          new Animal { AnimalId = 6, Name = "Carl", Species = "Cat", Breed = "American Bobtail", Age = 1, Gender = "Male" },
          new Animal { AnimalId = 7, Name = "Suzie", Species = "Cat", Breed = "Bengal", Age = 1, Gender = "Female" },
          new Animal { AnimalId = 8, Name = "Rex", Species = "Dog", Breed = "Australian Kelpie", Age = 2, Gender = "Male" },
          new Animal { AnimalId = 9, Name = "Winnie", Species = "Cat", Breed = "Bombay", Age = 1, Gender = "Female" },
          new Animal { AnimalId = 10, Name = "Cocoa", Species = "Cat", Breed = "Burmese", Age = 1, Gender = "Male" }
        );
    }
  }
}