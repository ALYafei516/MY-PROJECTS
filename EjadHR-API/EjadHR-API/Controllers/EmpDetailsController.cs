using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EjadHR_API.Models;

namespace EjadHR_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpDetailsController : ControllerBase
    {
        private readonly EmpDetailContext _context;

        public EmpDetailsController(EmpDetailContext context)
        {
            _context = context;
        }

        // GET: api/EmpDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmpDetails>>> GetEmpDetails()
        {
            return await _context.EmpDetails.ToListAsync();
        }

        // GET: api/EmpDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmpDetails>> GetEmpDetails(int id)
        {
            var empDetails = await _context.EmpDetails.FindAsync(id);

            if (empDetails == null)
            {
                return NotFound();
            }

            return empDetails;
        }

        // PUT: api/EmpDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmpDetails(int id, EmpDetails empDetails)
        {
            if (id != empDetails.EmployeeId)
            {
                return BadRequest();
            }

            _context.Entry(empDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpDetailsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(await _context.EmpDetails.ToListAsync());
        }

        // POST: api/EmpDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EmpDetails>> PostEmpDetails(EmpDetails empDetails)
        {
            _context.EmpDetails.Add(empDetails);
            await _context.SaveChangesAsync();

            return Ok(await _context.EmpDetails.ToListAsync());
        }

        // DELETE: api/EmpDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmpDetails(int id)
        {
            var empDetails = await _context.EmpDetails.FindAsync(id);
            if (empDetails == null)
            {
                return NotFound();
            }

            _context.EmpDetails.Remove(empDetails);
            await _context.SaveChangesAsync();

            return Ok(await _context.EmpDetails.ToListAsync());
        }

        private bool EmpDetailsExists(int id)
        {
            return _context.EmpDetails.Any(e => e.EmployeeId == id);
        }
    }
}
