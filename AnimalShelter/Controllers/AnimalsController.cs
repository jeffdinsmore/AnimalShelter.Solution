using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AnimalShelter.Models;
using Microsoft.OpenApi.Models;
using System.Text;

namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

    // GET api/animals
    [HttpGet]
    public ActionResult<IEnumerable<Animal>> Get(string name,string species, string breed, int ageYears, int ageMonths, string gender, int page, int size)
    {
      var query = _db.Animals.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name.Contains(name));
      }
      if (species != null)
      {
        query = query.Where(entry => entry.Species == species);
      }
      if (breed != null)
      {
        query = query.Where(entry => entry.Breed.Contains(breed));
      }
      if (ageYears != 0)
      {
        query = query.Where(entry => entry.AgeYears == ageYears);
      }
      if (ageMonths != 0)
      {
        query = query.Where(entry => entry.AgeMonths == ageMonths);
      }
      if (gender != null)
      {
        query = query.Where(entry => entry.Gender == gender);
      }
      
      if (page != 0)
      {
        if (size != 0)
        {
        }
        else
        {
          size = 3;
        }
        var entries = query.OrderBy(o => o.Breed).Skip((page - 1) * size).Take(size).ToList(); //finds the entries to be displayed
        query = entries.AsQueryable();
      }

      return query.ToList();
    }
    // POST api/animals
    [HttpPost]
    public void Post([FromBody] Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
    }

    // GET api/animals/5
    [HttpGet("{id}")]
    public ActionResult<Animal> Get(int id)
    {
      return _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
    }
    // GET api/animals/5
    [HttpGet("Random")]
    public ActionResult<Animal> Get()
    {
      List<Animal> model = _db.Animals.ToList();
      var sortedList = model.OrderByDescending(x => x.AnimalId);
      var maxValue = sortedList.First().AnimalId;
      var minValue = model.First().AnimalId;
      int minimumValue = minValue;
      int maximumValue = maxValue + 1;
      Random random = new Random();
      int randomId = random.Next(minimumValue, maximumValue);
      
      return _db.Animals.FirstOrDefault(entry => entry.AnimalId == randomId);
    }

    // PUT api/animals/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Animal animal)
    {
      animal.AnimalId = id;
      _db.Entry(animal).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/animals/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var animalToDelete = _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
      _db.Animals.Remove(animalToDelete);
      _db.SaveChanges();
    }

  }
}