namespace Menu
{
    public class Platos
    {
        private string nombre;
        private int precio;
        private int tamanio;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Tamanio { get => tamanio; set => tamanio = value; }

        public Platos(string nombre, int precio, int tamanio)
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.Tamanio = tamanio;
        }

    }    

    // public class cargaDePlatos
    // {
        
    // }

    
}