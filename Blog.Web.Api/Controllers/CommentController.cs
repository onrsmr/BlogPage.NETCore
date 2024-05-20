using Blog.Data.Context;
using Blog.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly AppDbContext _db;

        public CommentController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet("GetComments")]
        public async Task<ActionResult<IEnumerable<Comment>>> GetComments()
        {
            return await _db.Comments.ToListAsync();
        }

        [HttpGet("GetComment/{id}")]
        public async Task<ActionResult<Comment>> GetComment(Guid id)
        {
            var comment = await _db.Comments.FindAsync(id);

            if (comment == null)
            {
                return NotFound();
            }

            return comment;
        }

        [HttpPost("PostComment")]
        public async Task<ActionResult<Comment>> PostComment(Comment comment)
        {
            _db.Comments.Add(comment);
            await _db.SaveChangesAsync();

            return CreatedAtAction(nameof(GetComment), new { id = comment.Id }, comment);
        }

        [HttpPut("PutComment")]
        public async Task<ActionResult<Comment>> PutComment(Guid id, Comment comment)
        {
            if (id != comment.Id)
            {
                return BadRequest();
            }

            _db.Entry(comment).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CommentExists(id))
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

        [HttpDelete("DeleteComment")]
        public async Task<IActionResult> DeleteComment(Guid id)
        {
            var comment = await _db.Comments.FindAsync(id);
            if (comment == null)
            {
                return NotFound();
            }

            _db.Comments.Remove(comment);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        private bool CommentExists(Guid id)
        {
            return _db.Comments.Any(e => e.Id == id);
        }
    }
}
