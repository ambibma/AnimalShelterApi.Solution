using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public DbSet<Animal> Animals {get;set;}

    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options ) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
              .HasData(
                new Animal {AnimalId = 1, AnimalName = "Sparkles",  AnimalSex = "Female", AnimalType = "Cat", AnimalWeight = 17.5, AnimalNote = "Loves Yarn a bit too much"},
                new Animal {AnimalId = 2, AnimalName = "Lizzy",  AnimalSex = "Male", AnimalType = "Cat", AnimalWeight = 17.5, AnimalNote = "Loves Yarn a bit too much"},
                new Animal {AnimalId = 3, AnimalName = "Sparkles",  AnimalSex = "Female", AnimalType = "Cat", AnimalWeight = 17.5, AnimalNote = "Loves Yarn a bit too much"},
                new Animal {AnimalId = 4, AnimalName = "Sparkles",  AnimalSex = "Female", AnimalType = "Cat", AnimalWeight = 17.5, AnimalNote = "Loves Yarn a bit too much"},
                new Animal {AnimalId = 5, AnimalName = "Sparkles", AnimalSex = "Female", AnimalType = "Cat", AnimalWeight = 17.5, AnimalNote = "Loves Yarn a bit too much"},
                
              );
    }

    
  }
}