using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace org.app.pagapoco.appweb.core.entities
{
    
    public class Categoria
    {

        private string _nombre { get; set; }
        private List<Articulo> _articulos;
        public Categoria()
        {
            _articulos = new List<Articulo>();
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public List<Articulo> Articulos
        {
            get { return _articulos; }
            set { _articulos = value; }
        }

        public void AgregarArticulo(Articulo articulo)
        {
            Articulos.Add(articulo);
        }

    }

}
