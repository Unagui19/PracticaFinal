namespace Menu
{
    class Platos
    {
        private string nombre;
        private int precio;
        private int stock;


        public string Nombre { get => nombre; set => nombre = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }

        public Platos(string nombre, int precio, int stock)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
        }

    }    

    // public class cargaDePlatos
    // {
        
    // }

    
}