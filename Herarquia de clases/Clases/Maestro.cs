

namespace Herarquia_de_clases.Clases
{
    public class Maestro : Docente
    {
        public required string Titulacion { get; set; }
        public int AñosDeExperiencia { get; set; }

        public override void EnviarComunicado(string mensaje)
        {
            Console.WriteLine($"Enviando comunicado a Maestro: {Nombre}: {mensaje}");
        }
    }
}
