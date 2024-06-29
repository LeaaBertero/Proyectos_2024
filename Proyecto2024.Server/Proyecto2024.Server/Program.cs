using Microsoft.EntityFrameworkCore;
using Proyecto2024.BD.Data;

//----------------------------------------------------------------------------
//configuracion de los servicios en el contructor de la aplicación  
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//conexion con la base de datos  --- El context, que es una clase, es la base de datos
//es un servicio que conecta la aplicación con la base de datos
builder.Services.AddDbContext<Context>(op => op.UseSqlServer("name=conn"));



//-------------------------------------------------------------------------------
//constructor de la aplicación
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
