using Biblioteca.BD.Data;
using Microsoft.EntityFrameworkCore;
//------------------------------------------------------------------------------------
//configuracion de los servicios en el constructor de la aplicación
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//Builder (constructor) de la base de datos (Context)


builder.Services.AddDbContext<Context>(op => op.UseSqlServer("name=conn"));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();






//-----------------------------------------------------------------------------------------
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
