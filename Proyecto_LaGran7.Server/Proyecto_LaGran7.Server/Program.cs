using Microsoft.EntityFrameworkCore;
using Proyecto_Lagran7.BD.Data;


//---------------------------------------------------------------------------------------------------
//configuraci�n de los servicios en el constructor de la aplicaci�n
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//conexion string con la base de datos
builder.Services.AddDbContext<Context>(op => op.UseSqlServer("name=conn"));




//-------------------------------------------------------------------------------------------------------
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
