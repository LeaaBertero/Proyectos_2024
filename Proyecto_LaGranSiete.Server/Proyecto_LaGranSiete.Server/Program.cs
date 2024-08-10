using Microsoft.EntityFrameworkCore;
using Proyecto_LaGranSiete.BD.Data;
using Proyecto_LaGranSiete.BD.Data.Entity;
using Proyecto_LaGranSiete.Server.Repositorio;
using System.Text.Json.Serialization;// se genera despues de hacer control punto para generar el using para el context


//configuracion de los servivios en el constructor de la aplicacion
var builder = WebApplication.CreateBuilder(args);

//-----------------------------------------------------------------------------
//codigo para ignorar ciclos
builder.Services.AddControllersWithViews().AddJsonOptions(x =>
    x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
//-----------------------------------------------------------------------------

//Agregar Paginas de Razor
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



//Builder (constructor) de la base de datos (Context)
builder.Services.AddDbContext<Context>(op => op.UseSqlServer("name=conn"));



//AutoMapper (construyendo el objeto)
IServiceCollection serviceCollection = builder.Services.AddAutoMapper(typeof(Program));

//servicios de interfaz
builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
builder.Services.AddScoped<IReservaRepositorio, ReservaRepositorio>();


//constructor de la aplicacion
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //Use swagger(cuando est� en ejecuci�n)
    app.UseSwagger();
    //use la interf�z de usuario de swagger
    app.UseSwaggerUI();
}

//Se utiliza para habilitar el uso de archivos del framework de blazor en una aplicaci�n web
app.UseBlazorFrameworkFiles();
//Habilita el servicio de archivos estaticos como html , css y JavaScript 
app.UseStaticFiles();
//habilita el enrutamiento de solicitudes en un aplicaci�n web
app.UseRouting();
//Se utiliza para habilitar el uso de Razor Page en una aplicaci�n web
app.MapRazorPages();    

//use Https para redireccionar
app.UseHttpsRedirection();
//Use la autorizacion
app.UseAuthorization();
//Mape� los controles
app.MapControllers();
app.MapFallbackToFile("index.html");
//Arranque
app.Run();
