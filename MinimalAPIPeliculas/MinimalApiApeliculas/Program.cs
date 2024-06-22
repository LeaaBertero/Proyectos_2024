using MinimalApiApeliculas.Entidades;


var builder = WebApplication.CreateBuilder(args);

var origenesPermitodos = builder.Configuration.GetValue<string>("origenesPermitidos")!;

//inicio de area de los servicios
builder.Services.AddCors(opciones => 
{
opciones.AddDefaultPolicy(configuracion =>
{
    configuracion.WithOrigins(origenesPermitodos).AllowAnyHeader().AllowAnyMethod();
});



        
    






//fin de area de los servicios

var app = builder.Build();

//inicio de area de los middleware

app.UseCors();


app.MapGet("/generos",() =>
{
    var generos = new List<Genero>();

    new Genero
    {
        Id = 1,
        Nombre = "Drama"
    };

    new Genero
    {
        Id = 2,
        Nombre = "Accion"
    };

    new Genero
    {
        Id = 3,
        Nombre = "Comedia"
    };

    return generos;

});
//fin de area de los middleware

app.Run();
