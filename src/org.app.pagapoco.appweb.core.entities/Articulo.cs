namespace org.app.pagapoco.appweb.core.entities
{
    public class Articulo
    {

        private string _nombre { get; set; }
        private double _precio { get; set; }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public double Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

    }
}
