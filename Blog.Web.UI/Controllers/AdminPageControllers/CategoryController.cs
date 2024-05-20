using Blog.Data.Repositories.Abstractions;
using Blog.Entity.Entities;
using Blog.Web.UI.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.UI.Controllers.AdminPageControllers
{
    public class CategoryController : Controller
    {
        private readonly IRepositoryRC<Category> _categoryRepository;

        public CategoryController(IRepositoryRC<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var categories = _categoryRepository.GetAll();
            return View(categories);
        }

        [HttpPost]
        public IActionResult Create(Category model)
        {

            Category category = new Category();
            category.Id = Guid.NewGuid();
            category.CategoryName = model.CategoryName;

            _categoryRepository.Add(category);
            return RedirectToAction("Index", "Category");

        }

        public IActionResult Delete(Guid id)
        {
            var category = _categoryRepository.GetByID(id);
            _categoryRepository.Delete(category);
            return RedirectToAction("Index", "Category");
        }

        [HttpGet]
        public IActionResult Update(Guid id)
        {
            CategoryVM vm = new CategoryVM();
            var category = _categoryRepository.GetByID(id);
            vm.CategoryName = category.CategoryName;
            return View(vm);
        }

        [HttpPost]
        public IActionResult Update(CategoryVM vm)
        {
            Category category = _categoryRepository.GetByID(vm.Id);
            category.CategoryName = vm.CategoryName;
            _categoryRepository.Update(category);
            return RedirectToAction("Index", "Category");
        }
    }
}
