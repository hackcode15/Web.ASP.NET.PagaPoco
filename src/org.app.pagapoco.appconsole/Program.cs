// See https://aka.ms/new-console-template for more information
using org.app.pagapoco.appweb.core.finder;

Console.WriteLine("Articulos de Paga Poco!");

var articulos = ArticuloGestion.crearArticulos();

foreach (var articulo in articulos)
{
    Console.WriteLine($"Articulo: {articulo.Nombre}, Precio: {articulo.Precio}");
}


