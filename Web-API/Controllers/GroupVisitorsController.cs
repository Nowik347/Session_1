using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web_API.Models;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupVisitorsController : ControllerBase
    {
        private readonly VisitationContext _context;

        public GroupVisitorsController(VisitationContext context)
        {
            _context = context;
        }

        // GET: api/GroupVisitors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GroupVisitor>>> GetGroups()
        {
            return await _context.Groups.ToListAsync();
        }

        // GET: api/GroupVisitors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GroupVisitor>> GetGroupVisitor(int id)
        {
            var groupVisitor = await _context.Groups.FindAsync(id);

            if (groupVisitor == null)
            {
                return NotFound();
            }

            return groupVisitor;
        }

        // PUT: api/GroupVisitors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGroupVisitor(int id, GroupVisitor groupVisitor)
        {
            if (id != groupVisitor.Id)
            {
                return BadRequest();
            }

            _context.Entry(groupVisitor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GroupVisitorExists(id))
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

        // POST: api/GroupVisitors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GroupVisitor>> PostGroupVisitor(GroupVisitor groupVisitor)
        {
            _context.Groups.Add(groupVisitor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGroupVisitor", new { id = groupVisitor.Id }, groupVisitor);
        }

        // DELETE: api/GroupVisitors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGroupVisitor(int id)
        {
            var groupVisitor = await _context.Groups.FindAsync(id);
            if (groupVisitor == null)
            {
                return NotFound();
            }

            _context.Groups.Remove(groupVisitor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GroupVisitorExists(int id)
        {
            return _context.Groups.Any(e => e.Id == id);
        }
    }
}
