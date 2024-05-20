using Blog.Data.Context;
using Blog.Data.Repositories.Abstractions;
using Blog.Entity.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IRepositoryRC<Article> _articleRepository;

        public ArticleController(IRepositoryRC<Article> articleRepository)
        {
            _articleRepository = articleRepository;
        }

        [HttpGet("GetArticles")]
        public  ActionResult GetArticles()
        {
            var articles = _articleRepository.GetAll();

            return Ok(articles);
        }

        [HttpGet("GetArticle/{id}")]
        public async Task<ActionResult<Article>> GetArticle(Guid id)
        {
            var article = _articleRepository.GetByID(id);

            if (article == null)
            {
                return NotFound();
            }

            return article;
        }

        [HttpPost("PostArticle")]
        public async Task<ActionResult<Article>> PostArticle(string Title, string Content)
        {
            Article article = new Article();

            article.Id = Guid.NewGuid();
            article.Title = Title;
            article.Content = Content;
            article.AuthorId = Guid.Parse("A4D9E5AF-4567-4F0C-9EDC-8A2D9F25A7B8");
            article.ImageId = Guid.Parse("F3C8D4AE-3456-4F8C-88AA-16F3D5E2A60C");
            article.CategoryId = Guid.Parse("5DEE7F5A-78ED-42B6-9F79-9816505F9C38");
            article.ViewCount = 0;
            _articleRepository.Add(article);


            return Ok();
        }

        [HttpPut("PutArticle")]
        public async Task<IActionResult> PutArticle(Guid id, Article article)
        {
            //if (id != article.Id)
            //{
            //    return BadRequest();
            //}

            //_db.Entry(article).State = EntityState.Modified;

            //try
            //{
            //    await _db.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!ArticleExists(id))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            //return NoContent();
            return Ok();
        }

        [HttpDelete("DeleteArticle")]
        public async Task<IActionResult> DeleteArticle(Guid id)
        {
            //    var article = await _db.Articles.FindAsync(id);
            //    if (article == null)
            //    {
            //        return NotFound();
            //    }

            //    _db.Articles.Remove(article);
            //    await _db.SaveChangesAsync();

            //    return NoContent();
            //}

            //private bool ArticleExists(Guid id)
            //{
            //    return _db.Articles.Any(e => e.Id == id);
            //}

            return Ok();
        }
    }
}
