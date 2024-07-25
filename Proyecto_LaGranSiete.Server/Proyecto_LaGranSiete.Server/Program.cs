using Microsoft.EntityFrameworkCore;
using Proyecto_LaGranSiete.BD.Data;


//configuracion de los servivios en el constructor de la aplicacion
var builder = WebApplication.CreateBuilder(args);

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
