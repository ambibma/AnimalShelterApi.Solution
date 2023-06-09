using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelterApi.Models;

namespace AnimalShelterApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private readonly AnimalShelterApiContext _db;
    public AnimalsController(AnimalShelterApiContext db)
    {
      _db =db;
    }
    // Get api/animals
    // Refactored to create paged responses
    // Available for use at https://localhost:5001/swagger/index.html under GET
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Animal>>>GetAnimals([FromQuery] PaginationFilter filter)
    {
      var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
      List<Animal> PagedResponse = await _db.Animals
          .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
          .Take(validFilter.PageSize)
          .ToListAsync();
      return Ok(new PagedResponse<List<Animal>>(PagedResponse, validFilter.PageNumber, validFilter.PageSize));
      
    }
    // GET: api/Animals/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Animal>>GetAnimal(int id)
    {
      Animal animal = await _db.Animals.FindAsync(id);
      if (animal == null)
      {
        return NotFound();
      }
      return animal;
    }

    // POST api/animals
    [HttpPost]
    public async Task<ActionResult<Animal>> Post(Animal animal)
    {
      _db.Animals.Add(animal);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetAnimal), new{ id= animal.AnimalId}, animal);
    }
    // PUT: api/Animals/1
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Animal animal)
    {
      if(id != animal.AnimalId)
      {
        return BadRequest();
      }
      _db.Animals.Update(animal);
      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if(!AnimalExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
       }
        return NoContent();
      }
      private bool AnimalExists(int id)
      {
        return _db.Animals.Any(e=> e.AnimalId ==id);
      }
      //DELETE: api/Animals/5
      [HttpDelete("{id}")]
      public async Task<IActionResult> DeleteAnimal(int id)
      {
        Animal animal = await _db.Animals.FindAsync(id);
        if(animal == null)
        {
          return NotFound();
        }
        _db.Animals.Remove(animal);
        await _db.SaveChangesAsync();

        return NoContent();
      }
  }
}