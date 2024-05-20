using Blog.Data.Extentions;
using Blog.Data.Repositories.Abstractions;
using Blog.Data.Repositories.Concretes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.LoadDataLayerExtention(builder.Configuration); // program.cs' datalayerextetions baðlandý
//builder.Services.LoadServiceLayerExtention();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(IRepositoryRC<>), typeof(RepositoryRC<>));
builder.Services.AddScoped<IArticleRepositoryRC, ArticleRepositoryRC>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
