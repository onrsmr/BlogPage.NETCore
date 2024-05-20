using Blog.Data.Context;
using Blog.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriberController : ControllerBase
    {
        private readonly AppDbContext _db;

        public SubscriberController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet("GetSubscribers")]
        public async Task<ActionResult<IEnumerable<Subscriber>>> GetSubscribers()
        {
            return await _db.Subscribers.ToListAsync();
        }

        [HttpGet("GetSubscriber/{id}")]
        public async Task<ActionResult<Subscriber>> GetSubscriber(Guid id)
        {
            var subscriber = await _db.Subscribers.FindAsync(id);

            if (subscriber == null)
            {
                return NotFound();
            }

            return subscriber;
        }

        [HttpPost("PostSubsciber")]
        public async Task<ActionResult<Subscriber>> PostSubscriber(Subscriber subscriber)
        {
            _db.Subscribers.Add(subscriber);
            await _db.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSubscriber), new { id = subscriber.Id }, subscriber);
        }

        [HttpPut("PutSubscriber")]
        public async Task<ActionResult<Subscriber>> PutSubscriber(Guid id, Subscriber subscriber)
        {
            if (id != subscriber.Id)
            {
                return BadRequest();
            }

            _db.Entry(subscriber).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubscriberExists(id))
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

        [HttpDelete("DeleteSubscriber")]
        public async Task<IActionResult> DeleteSubscriber(Guid id)
        {
            var subscriber = await _db.Subscribers.FindAsync(id);
            if (subscriber == null)
            {
                return NotFound();
            }

            _db.Subscribers.Remove(subscriber);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        private bool SubscriberExists(Guid id)
        {
            return _db.Subscribers.Any(x => x.Id == id);
        }
    }
}
