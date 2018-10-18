using System;
using Proy_Escuela.Entidades;
using static System.Console;

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

            escuela.Cursos = new Curso[]
            {
                new Curso(){Nombre = "101"},
                new Curso(){Nombre = "201"},
                new Curso(){Nombre = "301"}
            };

            WriteLine(escuela.ToString());

            WriteLine("\nPresione ENTER para continuar");
            ReadLine();

            ImprimirCursos(escuela);

        }

        private static void ImprimirCursos(Escuela escuela)
        {
            if (escuela?.Cursos != null)
            {
                WriteLine("=============================================");
                WriteLine(" Curso | UniqueID");
                WriteLine("=============================================");
                foreach (var item in escuela.Cursos)
                {
                    item.Imprimir();
                }
                WriteLine("=============================================");
                WriteLine($"Registros: {escuela.Cursos.Length}\n");
            }
        }
    }
}
