using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2012);
            escuela.Pais = "Colombia";
            escuela.Ciudad = "Bogotá";
            escuela.TipoEscuela = TiposEscuela.Primaria;

            /* escuela.Cursos = new Curso[]
            {
                new Curso() {Nombre = "101", Jornada = TiposJornada.Noche},
                new Curso() {Nombre = "201", Jornada = TiposJornada.Tarde},
                new Curso() {Nombre = "301", Jornada = TiposJornada.Tarde}
            }; */

            List<Curso> listaCursos = new List<Curso>
            {
                new Curso() {Nombre = "101", Jornada = TiposJornada.Noche},
                new Curso() {Nombre = "201", Jornada = TiposJornada.Tarde},
                new Curso() {Nombre = "301", Jornada = TiposJornada.Tarde}
            };
;
            escuela.Cursos = listaCursos;



            WriteLine(escuela);
            WriteLine("===============");

            ImprimirCursosEscuela(escuela);



            

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

        private static void ImprimirCursosWhile(Curso[] ListaCursos)
        {
            int contador = 0;
            while (contador < ListaCursos.Length)
            {
                Console.WriteLine($"Curso:{ListaCursos[contador].Nombre} ID:{ListaCursos[contador].UniqueId}");
                contador++;
            }
        }

        private static void ImprimirCursosDoWhile(Curso[] ListaCursos)
        {
            int contador = 0;

            do
            {
                Console.WriteLine($"Curso:{ListaCursos[contador].Nombre} ID:{ListaCursos[contador].UniqueId}");
                contador++;
            } while (contador < ListaCursos.Length);



        }

        private static void ImprimirCursosFor(Curso[] ListaCursos)
        {
            for (int i = 0; i < ListaCursos.Length; i++)
            {
                Console.WriteLine($"Curso:{ListaCursos[i].Nombre} ID:{ListaCursos[i].UniqueId}");
            }
        }

        private static void ImprimirCursosForEach(Curso[] ListaCursos)
        {
            foreach (Curso item in ListaCursos)
            {
                Console.WriteLine($"Curso:{item.Nombre} ID:{item.UniqueId}");
            }
        }



    }
}
