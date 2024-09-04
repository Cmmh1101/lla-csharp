using Microsoft.AspNetCore.Mvc;
using LearningLanguageApp.Models;
using System.Collections.Generic;

namespace LearningLanguageApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SetsController : ControllerBase
    {
        // Placeholder for a database or in-memory data storage
        private static List<Set> sets = new List<Set>();

        // GET: api/sets
        [HttpGet]
        public ActionResult<IEnumerable<Set>> GetSets()
        {
            return Ok(sets);
        }

        // GET: api/sets/5
        [HttpGet("{id}")]
        public ActionResult<Set> GetSet(int id)
        {
            var set = sets.Find(s => s.Id == id);

            if (set == null)
            {
                return NotFound();
            }

            return Ok(set);
        }

        // POST: api/sets
        [HttpPost]
        public ActionResult<Set> CreateSet(Set newSet)
        {
            // Example: Auto-increment ID for simplicity
            newSet.Id = sets.Count + 1;
            sets.Add(newSet);
            return CreatedAtAction(nameof(GetSet), new { id = newSet.Id }, newSet);
        }

        // PUT: api/sets/5
        [HttpPut("{id}")]
        public IActionResult UpdateSet(int id, Set updatedSet)
        {
            var set = sets.Find(s => s.Id == id);

            if (set == null)
            {
                return NotFound();
            }

            // Update the set details
            set.Name = updatedSet.Name;
            set.Visibility = updatedSet.Visibility;
            set.Language1 = updatedSet.Language1;
            set.Language2 = updatedSet.Language2;
            set.Difficulty = updatedSet.Difficulty;
            set.Questions = updatedSet.Questions;
            set.Tags = updatedSet.Tags;
            set.Games = updatedSet.Games;

            return NoContent();
        }

        // DELETE: api/sets/5
        [HttpDelete("{id}")]
        public IActionResult DeleteSet(int id)
        {
            var set = sets.Find(s => s.Id == id);

            if (set == null)
            {
                return NotFound();
            }

            sets.Remove(set);
            return NoContent();
        }
    }
}
