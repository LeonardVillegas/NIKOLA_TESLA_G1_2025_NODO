using Microsoft.EntityFrameworkCore;
using TeslaACDC.Business.Interfaces;
using TeslaACDC.Business.Services;
using TeslaACDC.Data.IRepository;
using TeslaACDC.Data.Models;
using TeslaACDC.Data.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<NikolaContext>(
    opt => opt.UseNpgsql(builder.Configuration.GetConnectionString("NikolaDatabase"))
);

// Inyección de dependencia
builder.Services.AddScoped<IAlbumService, AlbumService>();
builder.Services.AddTransient<IArtistService, ArtistService>();
builder.Services.AddScoped<IMatematika, Matematika>();
builder.Services.AddScoped<IAlbumRepository<int, Album>, AlbumRepository<int, Album>>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();

