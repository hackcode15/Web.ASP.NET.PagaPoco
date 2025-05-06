using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.app.pagapoco.appweb.core.entities;

namespace org.app.pagapoco.appweb.core.finder
{
    public abstract class ArticuloGestion
    {

        public static List<Articulo> crearArticulos()
        {
            return crearArticulos(10);
        }

        public static List<Articulo> crearArticulos(int cantidad)
        {
            var articulos = new List<Articulo>();
            
            for (int i = 0; i < cantidad; i++)
            {
                
                var articulo = new Articulo()
                {
                    Nombre = $"Articulo N°{i}",
                    Precio = 100.0
                };

                articulos.Add(articulo);
            
            }

            return articulos;
        
        }

    }
}
