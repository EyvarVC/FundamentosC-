using System;
using CoreEscuela.Entidades;

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

            var arregloCursos = new Curso[3];

            arregloCursos[0] = new Curso()
            {
                Nombre = "101",
                Jornada = TiposJornada.Noche
            };

            var curso2 = new Curso()
            {
                Nombre = "201",
                Jornada = TiposJornada.Tarde
            };

            arregloCursos[1] = curso2;

            arregloCursos[2] = new Curso
            {
                Nombre = "301",
                Jornada = TiposJornada.Tarde
            };




            Console.WriteLine(escuela);
            System.Console.WriteLine("===============");

            ImprimirCursosWhile(arregloCursos);
            System.Console.WriteLine("===============");
            ImprimirCursosDoWhile(arregloCursos);
            System.Console.WriteLine("===============");
            ImprimirCursosFor(arregloCursos);
            System.Console.WriteLine("===============");
            ImprimirCursosForEach(arregloCursos);

        }

            private static void ImprimirCursosWhile(Curso[] ListaCursos)
            {
                int contador = 0;
                while (contador<ListaCursos.Length)
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
                } while (contador<ListaCursos.Length);
                

                
            }

             private static void ImprimirCursosFor(Curso[] ListaCursos)
            {
                for(int i=0; i<ListaCursos.Length; i++)
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
