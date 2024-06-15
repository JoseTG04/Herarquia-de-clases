

namespace Herarquia_de_clases.Clases
{
    public class Estudiante : MiembroDeLaComunidad
    {
        private int semestre;

        public int GetSemestre()
        {
            return semestre;
        }

        public void SetSemestre(int value)
        {
            semestre = value;
        }

        public override void EnviarComunicado(string mensaje)
        {
            Console.WriteLine($"Enviando comunicado a Estudiante: {Nombre}: {mensaje}");
        }
    }
}
