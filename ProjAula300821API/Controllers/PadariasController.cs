using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjAula300821API.Controllers.Model;
using ProjAula300821API.Models;

namespace ProjAula300821API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PadariasController : ControllerBase
    {
        private readonly ProjAula300821APIContext _context;

        public PadariasController(ProjAula300821APIContext context)
        {
            _context = context;
        }

        // GET: api/Padarias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Padaria>>> GetPadaria()
        {
            return await _context.Padaria.ToListAsync();
        }

        // GET: api/Padarias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Padaria>> GetPadaria(int id)
        {
            var padaria = await _context.Padaria.FindAsync(id);

            if (padaria == null)
            {
                return NotFound();
            }

            return padaria;
        }

        // PUT: api/Padarias/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPadaria(int id, Padaria padaria)
        {
            if (id != padaria.Id)
            {
                return BadRequest();
            }

            _context.Entry(padaria).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PadariaExists(id))
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

        // POST: api/Padarias
        [HttpPost]
        public async Task<ActionResult<Padaria>> PostPadaria(Padaria padaria)
        {
            _context.Padaria.Add(padaria);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPadaria", new { id = padaria.Id }, padaria);
        }

        // DELETE: api/Padarias/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Padaria>> DeletePadaria(int id)
        {
            var padaria = await _context.Padaria.FindAsync(id);
            if (padaria == null)
            {
                return NotFound();
            }

            _context.Padaria.Remove(padaria);
            await _context.SaveChangesAsync();

            return padaria;
        }

        private bool PadariaExists(int id)
        {
            return _context.Padaria.Any(e => e.Id == id);
        }
    }
}
