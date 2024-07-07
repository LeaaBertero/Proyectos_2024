using Microsoft.EntityFrameworkCore;
using Proyecto2024.BD.Data;

//-------------------------------------------------------------------------------------------
//configuración de los servicios en el constructor de la aplicación
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



//haciendo control . se corrige el error, por que ya tenemos generado el constructor en nuestra base de datos(context)
builder.Services.AddDbContext<Context>(op => op.UseSqlServer("name=conn"));



//----------------------------------------------------------------------------------------------
//construccion de la palicación
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
