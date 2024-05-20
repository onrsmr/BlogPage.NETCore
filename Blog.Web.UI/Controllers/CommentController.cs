using Blog.Data.Repositories.Abstractions;
using Blog.Entity.Entities;
using Blog.Web.UI.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.UI.Controllers
{
    public class CommentController : Controller
    {
        private readonly IRepositoryRC<Comment> commentRepository;

        public CommentController(IRepositoryRC<Comment> commentRepository)
        {
            this.commentRepository = commentRepository;
        }

        public IActionResult Index()
        {
            var comment = commentRepository.GetAll();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Comment model)
        {
            Comment comment = new Comment();
            comment.Id = Guid.NewGuid();
            comment.CommentContent = model.CommentContent;
            comment.ArticleID = Guid.Parse("56F58F96-3B2C-4339-BA5D-F3BD0C70D388");
            comment.SubscriberId = Guid.Parse("D1A59CDE-123B-45F2-89A7-9F34B9B501C9");
            return RedirectToAction("Index", "Comment");
        }

        public IActionResult Delete(Guid id)
        {
            var comment = commentRepository.GetByID(id);
            commentRepository.Delete(comment);
            return RedirectToAction("Index", "Comment");
        }

        [HttpGet]
        public IActionResult Update(Guid Id)
        {
            CommentVM vm = new CommentVM();
            var comment = commentRepository.GetByID(Id);
            vm.CommentContent = comment.CommentContent;
            vm.ArticleID = comment.ArticleID;
            vm.SubscriberId = comment.SubscriberId;
            return View();
        }

        [HttpPost]
        public IActionResult Update(CommentVM vm)
        {
            Comment comment= commentRepository.GetByID(vm.Id);
            comment.CommentContent = vm.CommentContent;
            comment.ArticleID = vm.ArticleID;
            comment.SubscriberId = vm.SubscriberId;
            commentRepository.Update(comment);
            return RedirectToAction("Index", "Comment");
        }
    }
}
