using Microsoft.EntityFrameworkCore;
using Proyecto2024.BD.Data;
using System.Text.Json.Serialization;

//-------------------------------------------------------------------------------------------
//configuración de los servicios en el constructor de la aplicación
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


//constructor de los servicios de los controladores - (Controllers)
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

//-----------------------------------------------------------------------------------------
//Metodo para ignorar ciclos repetitivos
builder.Services.AddControllers();
builder.Services.AddControllersWithViews().AddJsonOptions(
    x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
//-----------------------------------------------------------------------------------------


//constructor de los servicios de los endPoints (CRUD)
builder.Services.AddEndpointsApiExplorer();

//constructor de los servicios de ejecucion (Swagger);
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

//Mapea los controladores
app.MapControllers();

//En ésta sección arranca el programa cuando se ejecuta
app.Run();

