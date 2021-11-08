using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleStatusController : ControllerBase
    {
        private readonly DataContext _context;

        public VehicleStatusController(DataContext context)
        {
            _context = context;
        }

        // GET: api/VehicleStatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VehicleStatus>>> GettblVehicleStatuse()
        {
            return await _context.tblVehicleStatuse.ToListAsync();
        }

        // GET: api/VehicleStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VehicleStatus>> GetVehicleStatus(int id)
        {
            var vehicleStatus = await _context.tblVehicleStatuse.FindAsync(id);

            if (vehicleStatus == null)
            {
                return NotFound();
            }

            return vehicleStatus;
        }

        // PUT: api/VehicleStatus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicleStatus(int id, VehicleStatus vehicleStatus)
        {
            if (id != vehicleStatus.StatusId)
            {
                return BadRequest();
            }

            _context.Entry(vehicleStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehicleStatusExists(id))
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

        // POST: api/VehicleStatus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VehicleStatus>> PostVehicleStatus(VehicleStatus vehicleStatus)
        {
            _context.tblVehicleStatuse.Add(vehicleStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVehicleStatus", new { id = vehicleStatus.StatusId }, vehicleStatus);
        }

        // DELETE: api/VehicleStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicleStatus(int id)
        {
            var vehicleStatus = await _context.tblVehicleStatuse.FindAsync(id);
            if (vehicleStatus == null)
            {
                return NotFound();
            }

            _context.tblVehicleStatuse.Remove(vehicleStatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VehicleStatusExists(int id)
        {
            return _context.tblVehicleStatuse.Any(e => e.StatusId == id);
        }
    }
}
