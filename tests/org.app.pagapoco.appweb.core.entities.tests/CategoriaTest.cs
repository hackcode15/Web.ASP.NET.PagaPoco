namespace org.app.pagapoco.appweb.core.entities.tests
{

    public class CategoriaTest
    {

        [Fact]
        public void debeAgregarArticulosAUnaCategoria()
        {

            // 1:22:56

            var categoria = new Categoria()
            {
                Nombre = "Tecnologia",
                Articulos = new List<Articulo>()
            };

            var articulo1 = new Articulo()
            {
                Nombre = "Notebook",
                Precio = 1000
            };

            var articulo2 = new Articulo()
            {
                Nombre = "All In One",
                Precio = 1500
            };

            categoria.AgregarArticulo(articulo1);
            categoria.AgregarArticulo(articulo2);

            Assert.NotEmpty(categoria.Articulos);
            Assert.Equal(2, categoria.Articulos.Count);
            Assert.Equal("Notebook", categoria.Articulos[0].Nombre);
            Assert.Equal(1000, categoria.Articulos[0].Precio);
            Assert.Equal("All In One", categoria.Articulos[1].Nombre);
            Assert.Equal(1500, categoria.Articulos[1].Precio);

        }

    }

}
