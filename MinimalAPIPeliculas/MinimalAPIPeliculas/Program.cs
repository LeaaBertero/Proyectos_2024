using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using MinimalAPIPeliculas;
using MinimalAPIPeliculas.Entidades;




var builder = WebApplication.CreateBuilder(args);
var origenesPermitidos = builder.Configuration.GetValue<string>("origenesPermitidos")!;

builder.Services.AddDbContext<AplicationDbContext>(opciones => opciones.UseSqlServer("DefaultConnection"));

//var apellido = builder.Configuration.GetValue<string>("apellido");

//inicio del area de los servicios

builder.Services.AddCors(opciones =>
opciones.AddDefaultPolicy(configuracion =>
{
    configuracion.WithOrigins(origenesPermitidos).AllowAnyHeader().AllowAnyMethod();
}));

builder.Services.AddOutputCache();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//fin de area de los servicios


var app = builder.Build();

if (builder.Environment.IsDevelopment()) 
{

}

app.UseSwagger();
app.UseSwaggerUI();
//para utilizar swagger en cualquier ambiente de desarrollo


app.UseCors();
app.UseOutputCache();

//inicio de area de los middlware

app.MapGet("/", () => "Hello World!");

//expresión LAMBDA
app.MapGet("/generos", () =>
{
    var generos = new List<Genero>()
    {
        new Genero 
        {
            id = 1,
            Nombre = "drama",
        },

        new Genero
        {
        id = 2,
        Nombre = "accion",
        },

        new Genero
        {
        id = 3,
        Nombre = "Comedia",
        },

    };
      
    
    return generos;

        


});


app.Run();
