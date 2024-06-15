
namespace Herarquia_de_clases.Clases
{
    public class ExAlumno : MiembroDeLaComunidad
    {
        public int AñoDeEgreso { get; set; }
        public required string Profesion { get; set; }

        public override void EnviarComunicado(string mensaje)
        {
            Console.WriteLine($"Enviando comunicado a ExAlumno: {Nombre}: {mensaje}");
        }
    }
}
