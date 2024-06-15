

namespace Herarquia_de_clases.Clases
{
    public class Empleado : MiembroDeLaComunidad
    {
        public required string Cargo { get; set; }
        public decimal Salario { get; set; }

        public override void EnviarComunicado(string mensaje)
        {
            Console.WriteLine($"Enviando comunicado a Empleado: {Nombre}: {mensaje}");
        }
    }
}
