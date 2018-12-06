using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AspNetMvcDemo.Data;

namespace AspNetMvcDemo.WebApp.Controllers.Api {
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase {
        private readonly AnimalDbContext _context;

        public AnimalsController(AnimalDbContext context) {
            _context = context;
        }

        // GET: api/Animals
        [HttpGet]
        public IEnumerable<Animal> GetAnimals() {
            return _context.Animals;
        }

        // GET: api/Animals/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAnimal([FromRoute] Guid id) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            var animal = await _context.Animals.FindAsync(id);

            if (animal == null) {
                return NotFound();
            }

            return Ok(animal);
        }

        // PUT: api/Animals/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnimal([FromRoute] Guid id, [FromBody] Animal animal) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            if (id != animal.AnimalId) {
                return BadRequest();
            }

            _context.Entry(animal).State = EntityState.Modified;

            try {
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!AnimalExists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Animals
        [HttpPost]
        public async Task<IActionResult> PostAnimal([FromBody] Animal animal) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            _context.Animals.Add(animal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAnimal", new { id = animal.AnimalId }, animal);
        }

        // DELETE: api/Animals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnimal([FromRoute] Guid id) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            var animal = await _context.Animals.FindAsync(id);
            if (animal == null) {
                return NotFound();
            }

            _context.Animals.Remove(animal);
            await _context.SaveChangesAsync();

            return Ok(animal);
        }

        private bool AnimalExists(Guid id) {
            return _context.Animals.Any(e => e.AnimalId == id);
        }
    }
}