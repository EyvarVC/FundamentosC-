using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {

            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.WriteTitle("BIENVENIDOS A LA ESCUELA");

            Printer.DibujarLinea(50);
            WriteLine(engine.Escuela);
            Printer.DibujarLinea(50);
            
            ImprimirCursosEscuela(engine.Escuela);
            Printer.Beep(10000, cantidad: 10);

            /*escuela.Cursos.RemoveAll(cur => cur.Nombre == "501" && cur.Jornada == TiposJornada.Mañana);
            
            WriteLine("===============");
            ImprimirCursosEscuela(escuela);*/
        }


        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            
            Printer.WriteTitle("Cursos de la Escuela:");
            
            
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
