using Microsoft.EntityFrameworkCore;
using Proyecto2024.BD.Data;

//-------------------------------------------------------------------------------------------
//configuraci�n de los servicios en el constructor de la aplicaci�n
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



//haciendo control . se corrige el error, por que ya tenemos generado el constructor en nuestra base de datos(context)
builder.Services.AddDbContext<Context>(op => op.UseSqlServer("name=conn"));



//----------------------------------------------------------------------------------------------
//construccion de la palicaci�n
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
//Comentario
