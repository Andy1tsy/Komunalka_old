using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Komunalka.DAL.KomunalContext;
using Komunalka.DAL.Model;

namespace Komunalka.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PayingFixedSummasController : ControllerBase
    {
        private readonly KomunalContext _context;

        public PayingFixedSummasController(KomunalContext context)
        {
            _context = context;
        }

        // GET: api/PayingFixedSummas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PayingFixedSumma>>> GetPayingFixedSumma()
        {
            return await _context.PayingFixedSumma.ToListAsync();
        }

        // GET: api/PayingFixedSummas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PayingFixedSumma>> GetPayingFixedSumma(int id)
        {
            var payingFixedSumma = await _context.PayingFixedSumma.FindAsync(id);

            if (payingFixedSumma == null)
            {
                return NotFound();
            }

            return payingFixedSumma;
        }

        // PUT: api/PayingFixedSummas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPayingFixedSumma(int id, PayingFixedSumma payingFixedSumma)
        {
            if (id != payingFixedSumma.Id)
            {
                return BadRequest();
            }

            _context.Entry(payingFixedSumma).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PayingFixedSummaExists(id))
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

        // POST: api/PayingFixedSummas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PayingFixedSumma>> PostPayingFixedSumma(PayingFixedSumma payingFixedSumma)
        {
            _context.PayingFixedSumma.Add(payingFixedSumma);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PayingFixedSummaExists(payingFixedSumma.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPayingFixedSumma", new { id = payingFixedSumma.Id }, payingFixedSumma);
        }

        // DELETE: api/PayingFixedSummas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PayingFixedSumma>> DeletePayingFixedSumma(int id)
        {
            var payingFixedSumma = await _context.PayingFixedSumma.FindAsync(id);
            if (payingFixedSumma == null)
            {
                return NotFound();
            }

            _context.PayingFixedSumma.Remove(payingFixedSumma);
            await _context.SaveChangesAsync();

            return payingFixedSumma;
        }

        private bool PayingFixedSummaExists(int id)
        {
            return _context.PayingFixedSumma.Any(e => e.Id == id);
        }
    }
}
