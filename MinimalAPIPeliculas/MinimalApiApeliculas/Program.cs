using MinimalApiApeliculas.Entidades;


var builder = WebApplication.CreateBuilder(args);

//inicio de area de los servicios


var apellido = builder.Configuration.GetValue<string>("apellido");


//fin de area de los servicios

var app = builder.Build();

//inicio de area de los middleware


app.MapGet("/", () => apellido);

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
