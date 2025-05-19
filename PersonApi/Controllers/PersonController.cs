using PersonApi.Helpers; // The extension method
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonApi.Data;

namespace PersonApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public PersonController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Protos.Person>>> GetAllPersons()
        {
            var persons = await _applicationDbContext.Persons.ToListAsync();

            // Ensure LINQ is resolving 'p' as PersonApi.Models.Person
            return Ok(persons.Select(p => p.ToProto()));
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Protos.Person>> GetPerson(int id)
        {
            var person = await _applicationDbContext.Persons.FindAsync(id);
            if (person == null)
                return NotFound();

            // 'person' here is of type PersonApi.Models.Person
            return Ok(person.ToProto());
        }


        [HttpPost]
        public async Task<ActionResult<Protos.Person>> CreatePerson([FromBody] Protos.Person proto)
        {
            var person = proto.ToEntity();
            _applicationDbContext.Persons.Add(person);
            await _applicationDbContext.SaveChangesAsync();

            proto.Id = person.Id; // Set generated ID
            return CreatedAtAction(nameof(GetPerson), new { id = person.Id }, proto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePerson(int id, [FromBody] Protos.Person proto)
        {
            if (id != proto.Id)
                return BadRequest();

            var existing = await _applicationDbContext.Persons.FindAsync(id);
            if (existing == null)
                return NotFound();

            existing.Name = proto.Name;
            existing.FamilyName = proto.FamilyName;
            existing.SocialNumber = proto.SocialNumber;
            existing.BirthDate = DateTime.Parse(proto.BirthDate);

            await _applicationDbContext.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePerson(int id)
        {
            var person = await _applicationDbContext.Persons.FindAsync(id);
            if (person == null)
                return NotFound();

            _applicationDbContext.Persons.Remove(person);
            await _applicationDbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
