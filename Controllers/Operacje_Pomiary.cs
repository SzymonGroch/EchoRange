using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EchoRange.Model;
namespace EchoRange.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class Operacje_Pomiary
    {
        private readonly MyDbContext _context;
        public Operacje_Pomiary(MyDbContext context)
        {
            _context = context;
        }
        // GET: api/Odleglosc
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Odleglosci>>> GetOdleglosc()
        {
            return await _context.Odleglosc.ToListAsync();
        }
        // Other CRUD operations (POST, PUT, DELETE) go here...

        // POST: api/Odleglosci
        // POST: api/Odleglosci
        [HttpPost]
        public async Task<ActionResult<Odleglosci>> PostOdleglosc(Odleglosci odleglosc)
        {
            _context.Odleglosc.Add(odleglosc);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetOdleglosc), new { id = odleglosc.IdOdleglosc }, odleglosc);
        }

        private ActionResult<Odleglosci> CreatedAtAction(string v, object value, Odleglosci odleglosc)
        {
            throw new NotImplementedException();
        }

        // PUT: api/Odleglosci/5
        [HttpPut]
        public async Task<IActionResult> PutOdleglosc(int id, Odleglosci odleglosc)
        {
            var odlegloscToUpdate = await _context.Odleglosc.FindAsync(id);
            if (odlegloscToUpdate == null)
            {
                return NotFound();
            }

            odlegloscToUpdate = odleglosc;
            _context.Entry(odlegloscToUpdate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

            }

            return NoContent();
        }

   

        private IActionResult NotFound()
        {
            throw new NotImplementedException();
        }

        private IActionResult NoContent()
        {
            throw new NotImplementedException();
        }

        // DELETE: api/Odleglosci/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOdleglosc(int id)
        {
            var odleglosc = await _context.Odleglosc.FindAsync(id);
            if (odleglosc == null)
            {
                return NotFound();
            }

            _context.Odleglosc.Remove(odleglosc);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }

}
