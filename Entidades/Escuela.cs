namespace CoreEscuela.Entidades
{
    class Escuela
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

        public TiposEscuela TipoEscuela { get; set; }

        public Escuela(string nombreEscuela, int año) => (Nombre, AñoDeCreación) = (nombreEscuela, año);

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Tipo: {TipoEscuela}, \n Pais: {Pais}, Ciudad: {Ciudad}";

        }




    }
}