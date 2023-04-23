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
                new Animal {AnimalId = 5, Name = "Beatrice", Sex = "Female", Type = "Cat", Weight = 40.5, Note = "Loves eating living her best life"},

                new Animal {AnimalId = 6, Name = "Turty",  Sex = "Female", Type = "Turtle", Weight = 1.5, Note = "Loves lettuce and riding in the basket of a bicycle"},
                new Animal {AnimalId = 7, Name = "Rabby",  Sex = "Male", Type = "Rabbit", Weight = 2, Note = "Meows sometimes"},
                new Animal {AnimalId = 8, Name = "Hank II",  Sex = "Female", Type = "Chicken", Weight = 5.5, Note = "Hanks Daughter"},
                new Animal {AnimalId = 9, Name = "Raphael",  Sex = "male", Type = "Ficus", Weight = 1.5, Note = "Why we have a tree at our shelter we don't know but its available"},
                new Animal {AnimalId = 10, Name = "Napoleon", Sex = "male", Type = "Mouse", Weight = 1.5, Note = "Rumored to be the reincarnation of the French General"}
                
              );
    }

    
  }
}