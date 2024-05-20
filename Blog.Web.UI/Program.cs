using Blog.Service.Extentions;
using Blog.Data.Extentions;
using Blog.Data.Repositories.Abstractions;
using Blog.Data.Repositories.Concretes;
using Blog.Data.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.LoadDataLayerExtention(builder.Configuration);
builder.Services.LoadServiceLayerExtention();


builder.Services.AddScoped(typeof(IRepositoryRC<>), typeof(RepositoryRC<>));
builder.Services.AddScoped<IArticleRepositoryRC, ArticleRepositoryRC>();
builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IAdminRepository, AdminRepository>();
builder.Services.AddScoped<ICommentRepository, CommentRepository>();
builder.Services.AddScoped<IImageRepository, ImageRepository>();
builder.Services.AddScoped<ISubscriberRepository, SubscriberRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=AdminHome}/{action=Index}/{id?}");

app.Run();
