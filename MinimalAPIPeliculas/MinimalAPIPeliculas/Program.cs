

var builder = WebApplication.CreateBuilder(args);
var origenesPermitidos = builder.Configuration.GetValue<string>("origenesPermitidos")!;

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

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors();
app.UseOutputCache();

//inicio de area de los middlware

app.MapGet("/", () => "Hello World!");

app.Run();
