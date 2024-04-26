using eSiafApiN4.Entidades;

var builder = WebApplication.CreateBuilder(args);

var apellido = builder.Configuration.GetValue<string>("apellido");

//Inicio de �rea de los servicios


//Fin de �rea de los servicios
var app = builder.Build();
//Inicio de �rea de los middleware

app.MapGet("/", () => $"Hello World! {apellido}");
app.MapGet("/otra-cosa", () => "!Hola, otra cosa");

app.MapGet("/generos", () =>
{
    var generos = new List<Genero>
    {
        new Genero { Id = 1, Nombre="Drama"},
        new Genero { Id = 2, Nombre="Acci�n"},
        new Genero { Id = 3, Nombre="Comedia"}
    };

    return generos;
});

//Fin de �rea de los middleware
app.Run();
