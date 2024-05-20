using Blog.Data.Context;
using Blog.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly AppDbContext _db;

        public AdminController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet(Name = "GetAdmins")]
        public async Task<ActionResult<IEnumerable<Admin>>> GetAdmins()
        {
            return await _db.Admins.ToListAsync();
        }

        [HttpGet("GetAdmin/{id}")]
        public async Task<ActionResult<Admin>> GetAdmin(int id)
        {
            var admin = await _db.Admins.FindAsync(id);

            if (admin == null)
            {
                return NotFound();
            }

            return admin;
        }

        [HttpPost("PostAdmin")]
        public async Task<ActionResult<Admin>> PostAdmin(Admin admin)
        {
            _db.Admins.Add(admin);
            await _db.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAdmin), new { id = admin.Id }, admin);
        }

        [HttpPut("PutAdmin")]
        public async Task<IActionResult> PutAdmin(Guid id, Admin admin)
        {
            if (id != admin.Id)
            {
                return BadRequest();
            }

            _db.Entry(admin).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdminExists(id))
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

        [HttpDelete("DeleteAdmin")]
        public async Task<IActionResult> DeleteAdmin(Guid id)
        {
            var admin = await _db.Admins.FindAsync(id);
            if (admin == null)
            {
                return NotFound();
            }

            _db.Admins.Remove(admin);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        private bool AdminExists(Guid id)
        {
            return _db.Admins.Any(e => e.Id == id);
        }

    }
}
