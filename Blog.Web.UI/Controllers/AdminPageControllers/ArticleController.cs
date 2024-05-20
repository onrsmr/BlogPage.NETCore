using Blog.Data.Context;
using Blog.Data.Repositories.Abstractions;
using Blog.Data.Repositories.Concretes;
using Blog.Entity.Entities;
using Blog.Service.Services.Abstractions;
using Blog.Service.Services.Concretes;
using Blog.Web.UI.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.UI.Controllers.AdminPageControllers
{
    public class ArticleController : Controller
    {
        private readonly IRepositoryRC<Article> _articleRepository;


        public ArticleController(IRepositoryRC<Article> articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public IActionResult Index()
        {
            var articles = _articleRepository.GetAll();
            return View(articles);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
           // ArticleVM vm = new ArticleVM();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Article model)
        {
            
            Article article = new Article();
            article.Id = Guid.NewGuid();
            article.Title = model.Title;
            article.Content = model.Content;
            article.ViewCount = 0;
            article.CategoryId = Guid.Parse("5DEE7F5A-78ED-42B6-9F79-9816505F9C38"); //model.CategoryId;
            article.ImageId = Guid.Parse("F3C8D4AE-3456-4F8C-88AA-16F3D5E2A60C"); // model.ImageId;
            article.AuthorId = Guid.Parse("A4D9E5AF-4567-4F0C-9EDC-8A2D9F25A7B8"); // model.AuthorId;
            _articleRepository.Add(article);
            return RedirectToAction("Index", "Article");

        }

        public IActionResult Delete(Guid id)
        {
            var article = _articleRepository.GetByID(id);
            _articleRepository.Delete(article);
            return RedirectToAction("Index", "Article");
        }

        [HttpGet]
        public IActionResult Update(Guid id)
        {
            ArticleVM vm = new ArticleVM();
            var article = _articleRepository.GetByID(id);
            vm.Content = article.Content;
            vm.Title = article.Title;
            vm.Id = id;
            return View(vm);
        }

        [HttpPost]
        public IActionResult Update(ArticleVM vm)
        {
            Article article = _articleRepository.GetByID(vm.Id);
            article.Content = vm.Content;
            article.Title = vm.Title;
            _articleRepository.Update(article);
            return RedirectToAction("Index", "Article");
        }

    }
}
