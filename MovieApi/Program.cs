using Microsoft.EntityFrameworkCore;
using MovieAPI.Models;
using MovieAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Configuración de la cadena de conexión a SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Registrar servicios
builder.Services.AddScoped<IMovieService, MovieService>();

builder.Services.AddControllers();

var app = builder.Build();

// Configuración de las rutas
app.MapControllers();

app.Run();

