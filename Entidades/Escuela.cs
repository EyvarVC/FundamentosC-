using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Escuela
    {

        string nombre;
        public string Nombre
        {
            get { return "Copia:" + nombre; }
            set { nombre = value.ToUpper(); }
        }

        public int AñoDeCreación { get; set; }

        public string Pais { get; set; }
        public string Ciudad { get; set; }

        //public Curso[] Cursos {get;set;}
        public List<Curso> Cursos {get;set;}


        public TiposEscuela TipoEscuela { get; set; }

        

        public Escuela(string nombreEscuela, int año) => (Nombre, AñoDeCreación) = (nombreEscuela, año);
        

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Tipo: {TipoEscuela}, \nPais: {Pais}, Ciudad: {Ciudad}";

        }




    }
}