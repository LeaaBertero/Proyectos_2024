using MinimalAPIPeliculas.Entidades;



var builder = WebApplication.CreateBuilder(args);
var apellido = builder.Configuration.GetValue<string>("Apellido");
//inicio de area de los servicios

//fin del area de los servicios

var app = builder.Build();


//inicio de area de los middleware
app.MapGet("/", () => "Hola Mundo");

//para crear un endPoint
app.MapGet("/generos",  () => {
 
    var generos = new List<Genero>();
    new Genero
    {
        Id = 1,
        Nombre = "Drama",

    };

    new Genero
    {
        Id = 2,
        Nombre = "Acción",

    };

    new Genero
    {
        Id = 3,
        Nombre = "Comedia",

    };

    return generos; 
});



app.MapGet("/", () => "Hello World!");

//fin de area de los middlware
app.Run();
