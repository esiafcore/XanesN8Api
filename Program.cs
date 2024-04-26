var builder = WebApplication.CreateBuilder(args);

var apellido = builder.Configuration.GetValue<string>("apellido");

//Inicio de �rea de los servicios


//Fin de �rea de los servicios
var app = builder.Build();
//Inicio de �rea de los middleware

app.MapGet("/", () => $"Hello World! {apellido}");

//Fin de �rea de los middleware
app.Run();
