using System;
using System.Collections.Generic;
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

            
            escuela.Cursos = new List<Curso>()
            {
                new Curso(){Nombre = "101", TipoJornada = TiposJornada.Mañana},
                new Curso(){Nombre = "201", TipoJornada = TiposJornada.Mañana},
                new Curso(){Nombre = "301", TipoJornada = TiposJornada.Mañana}
            };

            escuela.Cursos.Add(new Curso(){Nombre = "102", TipoJornada = TiposJornada.Tarde});
            escuela.Cursos.Add(new Curso(){Nombre = "202", TipoJornada = TiposJornada.Tarde});
            escuela.Cursos.Add(new Curso(){Nombre = "302", TipoJornada = TiposJornada.Tarde});
            var otraColeccion = new List<Curso>(){
                new Curso(){Nombre = "103", TipoJornada = TiposJornada.Noche},
                new Curso(){Nombre = "203", TipoJornada = TiposJornada.Noche},
                new Curso(){Nombre = "303", TipoJornada = TiposJornada.Noche}
            };
            escuela.Cursos.AddRange(otraColeccion);
            otraColeccion.Clear();

            WriteLine(escuela.ToString());

            WriteLine("\nPresione ENTER para continuar");
            ReadLine();

            ImprimirCursos(escuela);

        }

        private static void ImprimirCursos(Escuela escuela)
        {
            if (escuela?.Cursos != null)
            {
                WriteLine("============================================================");
                WriteLine(" Curso | UniqueID                             | Tipo Jornada");
                WriteLine("============================================================");
                foreach (var item in escuela.Cursos)
                {
                    item.Imprimir();
                }
                WriteLine("============================================================");
                WriteLine($"Registros: {escuela.Cursos.Count}\n");
            }
        }
    }
}
