using Microsoft.EntityFrameworkCore;
using MyWebApi.Services;
using MyWebApi.Models;
using MapApi;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// CORS ayarlarý
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder => builder
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
});

// PostgreSQL veritabaný ayarlarý
builder.Services.AddDbContext<DataContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Dependency injection için servisler
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<PointValueService>();

var app = builder.Build();

// Geliþtirme ortamýnda hata ayýklama ve Swagger ayarlarý
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

// CORS middleware'i ekleyin
app.UseCors("AllowAllOrigins");

// Routing ve Authorization
app.UseRouting();
app.UseAuthorization();

// Kontrolcülerin çalýþmasý için middleware'i ekleyin
app.MapControllers();

app.Run();
