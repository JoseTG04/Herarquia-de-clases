
namespace Herarquia_de_clases.Clases
{
    abstract public class MiembroDeLaComunidad
    {
        public required string Nombre { get; set; }
        public required string CorreoElectronico { get; set; }
        public required string Telefono { get; set; }

        private string carrera;

        protected MiembroDeLaComunidad(string carrera)
        {
            this.carrera = carrera;
        }

        public required string Carrera { get; set; }

        public string? Semestre { get; set; }

        public abstract void EnviarComunicado(string mensaje);
    }
}
