using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Proyecto2024.BD.Data;
using System.Text.Json.Serialization;


//---------------------------------------------------------------------
//configuracion de los servicios en el constructor de la aplicación
var builder = WebApplication.CreateBuilder(args);

//para evitar los bucles infinitos en la base de datos?????
builder.Services.AddControllersWithViews().AddJsonOptions
    (x=>x.JsonSerializerOptions.
    ReferenceHandler = ReferenceHandler.IgnoreCycles);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//tuve que escribir esta parte manualmente, no me aparecia inicialmente con el proyecto
builder.Services.AddDbContext<Context>(op => op.UseSqlServer("name=conn"));



//---------------------------------------------------------------------
//construccion de la aplicacion
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
