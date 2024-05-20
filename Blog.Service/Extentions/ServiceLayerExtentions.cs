using Blog.Service.Services.Abstractions;
using Blog.Service.Services.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Service.Extentions
{
    public static class ServiceLayerExtentions
    {
        public static IServiceCollection LoadServiceLayerExtention(this IServiceCollection services)
        {
            services.AddScoped<IArticleService, ArticleService>();
            return services;
        }
    }
}
