using Microsoft.EntityFrameworkCore;
using Proyecto_LaGranSiete.BD.Data;
using System.Text.Json.Serialization;// se genera despues de hacer control punto para generar el using para el context


//configuracion de los servivios en el constructor de la aplicacion
var builder = WebApplication.CreateBuilder(args);

//-----------------------------------------------------------------------------
//codigo para ignorar ciclos
builder.Services.AddControllersWithViews().AddJsonOptions(x =>
    x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
//-----------------------------------------------------------------------------


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//constrictor de la base de datos (Context)

builder.Services.AddDbContext<Context>(op => op.UseSqlServer("name=conn"));


//constructor de la aplicacion
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
