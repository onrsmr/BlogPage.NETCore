using Blog.Data.Context;
using Blog.Data.Repositories.Abstractions;
using Blog.Data.Repositories.Concretes;
using Blog.Data.UnitofWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Data.Extentions
{
    public static class DataLayerExtentions
    {
        // Dependency Injection: bu class içerisinde yazmamın sebebi program.cs classını temiz tutmak ve okunabilirliği arttırmak

        public static IServiceCollection LoadDataLayerExtention(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>)); // IRepository'ye istek gönderildiğinde Repositoryi çağır

            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUnitofWork, UnitofWork>();

            return services;
        }
    }
}
