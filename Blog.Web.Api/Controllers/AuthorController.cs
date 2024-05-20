using Blog.Data.Context;
using Blog.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly AppDbContext _db;

        public AuthorController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet("GetAuthors")]
        public async Task<ActionResult<IEnumerable<Author>>> GetAuthors()
        {
            return await _db.Authors.ToListAsync();
        }

        [HttpGet("GetAuthor/{id}")]
        public async Task<ActionResult<Author>> GetAuthor(Guid id)
        {
            var author = await _db.Authors.FindAsync(id);

            if (author == null)
            {
                return NotFound();
            }
            return author;
        }

        [HttpPost("PostAuthor")]
        public async Task<ActionResult<Author>> PostAuthor(Author author)
        {
            _db.Authors.Add(author);
            await _db.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAuthor), new { id = author.Id }, author);
        }

        [HttpPut("PutAuthor")]
        public async Task<IActionResult> PutAuthor(Guid id, Author author)
        {
            if (id != author.Id)
            {
                return BadRequest();
            }

            _db.Entry(author).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (Exception)
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

        [HttpDelete("DeleteAuthor")]
        public async Task<IActionResult> DeleteAuthor(Guid id)
        {
            var author = await _db.Authors.FindAsync(id);

            if (author == null)
            {
                return NotFound(id);
            }

            _db.Authors.Remove(author);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        private bool AdminExists(Guid id)
        {
            return _db.Authors.Any(e => e.Id == id);
        }

    }
}
