
namespace Herarquia_de_clases.Clases
{
    public class Administrativo : Empleado
    {
        public required string Departamento { get; set; }
        public required string Funciones { get; set; }

        public override void EnviarComunicado(string mensaje)
        {
            Console.WriteLine($"Enviando comunicado a Administrativo: {Nombre}: {mensaje}");
        }
    }
}
