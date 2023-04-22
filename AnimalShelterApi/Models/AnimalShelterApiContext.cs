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
                new Animal {AnimalId = 1, Name = "Sparkles",  Sex = "Female", Type = "Cat", Weight = 17.5, Note = "Loves Yarn a bit too much"},
                new Animal {AnimalId = 2, Name = "Lizzy",  Sex = "Male", Type = "Iguana", Weight = 5, Note = "Loves baking in the sun"},
                new Animal {AnimalId = 3, Name = "Daisy",  Sex = "Female", Type = "Dog", Weight = 50.5, Note = "Has no thoughts"},
                new Animal {AnimalId = 4, Name = "Hank",  Sex = "male", Type = "Chicken", Weight = 6.5, Note = "Needs anger management"},
                new Animal {AnimalId = 5, Name = "Beatrice", Sex = "Female", Type = "Cat", Weight = 40.5, Note = "Loves eating living her best life"}
                
              );
    }

    
  }
}