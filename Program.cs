using System;
using CoreEscuela.Entidades;

namespace Proy_Escuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2012, "Bogota", "Colombia");
            /*
            var escuela = new Escuela("Platzi Academy",2012);
            escuela.Ciudad = "Bogota";
            escuela.Pais = "Colombia";
             */
            escuela.TipoEscuela = TiposEscuela.Primaria;
            /*
            Console.WriteLine("Bienvenidos a " + escuela.Nombre.ToString() + "!!!");
            Console.WriteLine(escuela.TipoEscuela.ToString());
            Console.WriteLine("Fundada desde " + escuela.AñoDeCreación.ToString());
            Console.WriteLine("En " + escuela.Ciudad.ToString() + ", " + escuela.Pais.ToString());
             */
            Console.WriteLine(escuela.ToString());
        }
    }
}
