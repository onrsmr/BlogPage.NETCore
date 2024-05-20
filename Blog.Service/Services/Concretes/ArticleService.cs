using Blog.Data.UnitofWorks;
using Blog.Entity.Entities;
using Blog.Service.Services.Abstractions;

namespace Blog.Service.Services.Concretes
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitofWork _unitofWork;

        public ArticleService(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
        }

        // aynı kod burada çalılıyor

        public async Task<List<Article>> GetAllArticlesAsync()
        {
            return await _unitofWork.GetRepository<Article>().GetAllAsync();
        }
    }
}
