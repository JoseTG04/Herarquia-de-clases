namespace Herarquia_de_clases.Clases
{
    public class Docente : Empleado
    {
        public required string AreaDeEspecializacion { get; set; }
        public int CantidadDeMaterias { get; set; }

        public override void EnviarComunicado(string mensaje)
        {
            Console.WriteLine($"Enviando comunicado a Docente: {Nombre}: {mensaje}");
        }
    }
}
