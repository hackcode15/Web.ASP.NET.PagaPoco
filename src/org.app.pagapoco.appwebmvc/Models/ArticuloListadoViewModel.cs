using org.app.pagapoco.appweb.core.entities;

namespace org.app.pagapoco.appwebmvc.Models
{
    
    public class ArticuloListadoViewModel
    {

        public string Titulo { get; set; }
        
        public List<Articulo> Articulos { get; set; }

        public int CantidadArticulo => Articulos.Count;

        public string TituloFormateado => $"{Titulo} [{CantidadArticulo}]";

        public ArticuloListadoViewModel()
        {
            this.Articulos = new List<Articulo>();
        }

    }

}
