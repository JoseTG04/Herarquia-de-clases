

namespace Herarquia_de_clases.Clases
{
    public class Administrador : Empleado
    {
        public string? AreaDeResponsabilidad { get; set; }
        public int NivelDeAcceso { get; set; }

        public override void EnviarComunicado(string mensaje)
        {
            Console.WriteLine($"Enviando comunicado a Administrador: {Nombre}: {mensaje}");
        }
    }
}
