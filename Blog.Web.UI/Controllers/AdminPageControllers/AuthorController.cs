using Blog.Data.Repositories.Abstractions;
using Blog.Entity.Entities;
using Blog.Service.Services.Abstractions;
using Blog.Web.UI.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.UI.Controllers.AdminPageControllers
{
    public class AuthorController : Controller
    {
        private readonly IRepositoryRC<Author> _authorRepository;

        public AuthorController(IRepositoryRC<Author> authorRepository)
        {
            _authorRepository = authorRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var authors = _authorRepository.GetAll();
            return View(authors);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            // ArticleVM vm = new ArticleVM();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Author model)
        {

            Author author = new Author();
            author.Id = Guid.NewGuid();
            author.Name = model.Name;
            author.Surname = model.Surname;
            author.UserName = model.UserName;
            author.Email = model.Email;
            author.Password = model.Password;

            _authorRepository.Add(author);
            return RedirectToAction("Index", "Author");

        }

        public IActionResult Delete(Guid id)
        {
            var auhtor = _authorRepository.GetByID(id);
            _authorRepository.Delete(auhtor);
            return RedirectToAction("Index", "Author");
        }

        [HttpGet]
        public IActionResult Update(Guid id)
        {
            AuthorVM vm = new AuthorVM();
            var author = _authorRepository.GetByID(id);
            vm.Name = author.Name;
            vm.Surname= author.Surname;
            vm.UserName = author.UserName;
            vm.Email = author.Email;
            vm.Password = author.Password;
            return View(vm);
        }

        [HttpPost]
        public IActionResult Update(AuthorVM vm)
        {
            Author author = _authorRepository.GetByID(vm.Id);
            author.Name= vm.Name;
            author.Surname= vm.Surname;
            author.UserName= vm.UserName;
            author.Password= vm.Password;
            _authorRepository.Update(author);
            return RedirectToAction("Index", "Author");
        }
    }
}
