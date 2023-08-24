namespace Personas
{
    public class Personal
    {
        private string? nombre;
        private int altura;
        int edad;
        DateTime fechaNac;
        string? profesión;
        string? nacionalidad;

        public string? Nombre { get => nombre; set => nombre = value; }
        public int Altura { get => altura; set => altura = value; }
        public int Edad { get => edad; set => edad = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public string? Profesión { get => profesión; set => profesión = value; }
        public string? Nacionalidad { get => nacionalidad; set => nacionalidad = value; }

        public void calcularEdad(DateTime fechaNac)
        {
            Edad= DateTime.Now.Year - FechaNac.Year;
        }
    }
}