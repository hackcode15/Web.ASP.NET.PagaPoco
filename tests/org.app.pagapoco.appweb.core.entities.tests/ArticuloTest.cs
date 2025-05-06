namespace org.app.pagapoco.appweb.core.entities.tests
{
    public class ArticuloTest
    {
        [Fact]
        public void debeCrearUnNuevoArticulo()
        {

            Articulo articulo = new Articulo();
            articulo.Nombre = "Notebook";

            Assert.NotNull(articulo);
            Assert.Equal("Notebook", articulo.Nombre);

        }

        [Fact]
        public void debeCrearOtroNuevoArticulo()
        {

            // 1.
            /*var articulo = new Articulo();
            articulo.Nombre = "Notebook";*/

            // 2.
            var articulo = new Articulo()
            {
                Nombre = "Notebook"
            };

            Assert.NotNull(articulo);
            Assert.Equal("Notebook", articulo.Nombre);

        }

        [Fact]
        public void debeCrearOtroNuevoArticuloConPrecio()
        {


            var articulo = new Articulo()
            {
                Nombre = "Notebook",
                Precio = 1000
            };

            Assert.NotNull(articulo);
            Assert.Equal("Notebook", articulo.Nombre);
            Assert.Equal(1000, articulo.Precio);

        }

        [Fact]
        public void debeCrear10Articulos()
        {

            var articulos = new List<Articulo>();

            for (int i = 0; i < 10; i++)
            {
                var articulo = new Articulo()
                {
                    Nombre = $"Articule N°{i}",
                    Precio = 1000
                };

                articulos.Add(articulo);

            }

            Assert.NotEmpty(articulos);
            Assert.Equal(10, articulos.Count);

        }

        /*[Fact]
        public void debeCrear10Articulos()
        {

            var articulos = new List<Articulo>();

            for (int i = 0; i < 10; i++)
            {
                var articulo = new Articulo()
                {
                    Nombre = $"Articule N°{i}",
                    Precio = 1000
                };

                articulos.Add(articulo);

            }

            Assert.NotEmpty(articulos);
            Assert.Equal(10, articulos.Count);

        }*/

    }
}
