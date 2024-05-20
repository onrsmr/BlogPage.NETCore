using Blog.Data.Context;
using Blog.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly AppDbContext _db;

        public ImageController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet("GetImage")]
        public async Task<ActionResult<IEnumerable<Image>>> GetImages()
        {
            return await _db.Images.ToListAsync();
        }

        [HttpGet("GetImage/{id}")]
        public async Task<ActionResult<Image>> GetImage(Guid id)
        {
            var image = await _db.Images.FindAsync(id);

            if (image == null)
            {
                return NotFound();
            }

            return image;
        }

        [HttpPost("PostImage")]
        public async Task<ActionResult<Image>> PostImage(Image image)
        {
            _db.Images.Add(image);
            await _db.SaveChangesAsync();

            return CreatedAtAction(nameof(GetImage), new { id = image.Id }, image);
        }

        [HttpPut("PutImage")]
        public async Task<ActionResult<Image>> PutImage(Guid id, Image image)
        {
            if (id != image.Id)
            {
                return BadRequest();
            }

            _db.Entry(image).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImageExists(id))
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

        [HttpDelete("DeleteImage")]
        public async Task<IActionResult> DeleteImage(Guid id)
        {
            var image = await _db.Images.FindAsync(id);
            if (image == null)
            {
                return NotFound();
            }

            _db.Images.Remove(image);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        private bool ImageExists(Guid id)
        {
            return _db.Images.Any(e => e.Id == id);
        }
    }
}
