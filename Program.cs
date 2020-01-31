using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {

            var engine = new EscuelaEngine();
            engine.Inicializar();

            WriteLine(engine.Escuela);
            WriteLine("===============");
            ImprimirCursosEscuela(engine.Escuela);

            /*escuela.Cursos.RemoveAll(cur => cur.Nombre == "501" && cur.Jornada == TiposJornada.Mañana);
            
            WriteLine("===============");
            ImprimirCursosEscuela(escuela);*/
        }


        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("====================");
            WriteLine("Cursos de la Escuela:");
            WriteLine("====================");
            if (escuela?.Cursos != null) // ?, pregunta, si el obj escuela es diferente de null?, evalúa lo siguiente (Cursos)
            {
                foreach (Curso item in escuela.Cursos)
                {
                    WriteLine($"Curso:{item.Nombre} ID:{item.UniqueId}");
                }
            }
        }

    }
}
