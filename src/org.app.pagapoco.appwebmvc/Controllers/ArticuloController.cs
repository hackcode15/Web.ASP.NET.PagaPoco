using Microsoft.AspNetCore.Mvc;
using org.app.pagapoco.appweb.core.entities;
using org.app.pagapoco.appweb.core.finder;

namespace org.app.pagapoco.appwebmvc.Controllers
{
    public class ArticuloController : Controller
    {

        [Route("articulos.html")]
        [Route("articulos")]
        [Route("los-articulos")]
        public IActionResult Index()
        {

            var model = new Models.ArticuloListadoViewModel()
            {
                Titulo = "Listado de Articulos",
                Articulos = ArticuloGestion.crearArticulos()
            };

            //var articulos = ArticuloGestion.crearArticulos();

            //return View(articulos);

            return View(model);

        }

    }
}
