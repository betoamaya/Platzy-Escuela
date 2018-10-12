using System;
using Proy_Escuela.Entidades;

namespace Proy_Escuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela(_nombre: "Platzi Academy",
            _año: 2012,
            _tipo: TiposEscuela.Primaria,
            _ciudad: "Bogota",
            _pais: "Colombia");

            var arregloCursos = new Curso[3];
            arregloCursos[0] = new Curso()
            {
                Nombre = "101"
            };
            arregloCursos[1] = new Curso()
            {
                Nombre = "201"
            };
            arregloCursos[2] = new Curso()
            {
                Nombre = "301"
            };

            Console.WriteLine(escuela.ToString());

            Console.WriteLine("\nPresione ENTER para continuar");
            Console.ReadLine();

            ImprimirCursos(arregloCursos);
            
        }

        private static void ImprimirCursos(Curso[] arregloCursos)
        {
            
            System.Console.WriteLine("=============================================");
            System.Console.WriteLine(" Curso | UniqueID");
            int contador = 0;
            while (contador < arregloCursos.Length)
            {
                arregloCursos[contador].Imprimir();
                contador++;
            }
            /*
            for (int i = 0; i < arregloCursos.Length; i++)
            {
                arregloCursos[i].Imprimir();    
            }
             */
            System.Console.WriteLine("=============================================\n");
        }
    }
}
