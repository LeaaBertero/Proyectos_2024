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



//Builder (constructor) de la base de datos (Context)
builder.Services.AddDbContext<Context>(op => op.UseSqlServer("name=conn"));

//AutoMapper (construyendo el objeto)
IServiceCollection serviceCollection = builder.Services.AddAutoMapper(typeof(Program));


//constructor de la aplicacion
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //Use swagger(cuando está en ejecución)
    app.UseSwagger();
    //use la interfáz de usuario de swagger
    app.UseSwaggerUI();
}

//use Https para redireccionar
app.UseHttpsRedirection();
//Use la autorizacion
app.UseAuthorization();
//Mapeé los controles
app.MapControllers();
//Arranque
app.Run();
