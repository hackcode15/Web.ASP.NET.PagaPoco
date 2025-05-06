using org.app.pagapoco.appweb.core.entities;
using org.app.pagapoco.appweb.core.finder;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// 8:52

// investigar sobre
// guardar la solucion con la extension slnx 

//app.MapGet("/", () => "Hello World!");

/*app.MapGet("/", () => {

    string demo = DateTime.Now.ToString();
    return $"Hola Mundo! {demo}";

});*/

// Contexto Web

// Middleware
/*app.Use(async (context, next) => 
{

    await context.Response.WriteAsync("Hello Wordl");

    await next.Invoke();

});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("UTN TUP 2025!");
    await next.Invoke();
});*/

app.MapGet("/articulos", () =>
{

    var articulos = new List<Articulo>();

    for (int i = 0; i < 10; i++)
    {
        var articulo = new Articulo()
        {
            Nombre = $"Articulo N°{i}",
            Precio = 1000
        };

        articulos.Add(articulo);

    }


    var cadena = "\n";

    foreach (var articulo in articulos)
    {
        cadena = cadena + $"Nombre: {articulo.Nombre} - Precio: {articulo.Precio} \n";
    }

    return $"Articulos! {cadena}";

});

app.MapGet("/api/articulos", () =>
{

    var articulos = ArticuloGestion.crearArticulos();

    var dataJson = "[";

    foreach (var articulo in articulos)
    {
        dataJson += $"{{\"nombre\":\"{articulo.Nombre}\",\"price\":\"{articulo.Precio}\"}},";
    }

    dataJson += "]";

    return dataJson;

});

app.Run();
