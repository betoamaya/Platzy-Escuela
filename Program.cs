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

            escuela.Cursos.Add(new Curso() { Nombre = "102", TipoJornada = TiposJornada.Tarde });
            escuela.Cursos.Add(new Curso() { Nombre = "202", TipoJornada = TiposJornada.Tarde });
            escuela.Cursos.Add(new Curso() { Nombre = "302", TipoJornada = TiposJornada.Tarde });
            var otraColeccion = new List<Curso>(){
                new Curso(){Nombre = "103", TipoJornada = TiposJornada.Noche},
                new Curso(){Nombre = "203", TipoJornada = TiposJornada.Noche},
                new Curso(){Nombre = "303", TipoJornada = TiposJornada.Noche}
            };
            escuela.Cursos.AddRange(otraColeccion);
            otraColeccion.Clear();

            /* Agregar un curso */
            Curso tmp = new Curso() { Nombre = "999", TipoJornada = TiposJornada.Noche };
            escuela.Cursos.Add(tmp);
            /* Quitar el curso */
            escuela.Cursos.Remove(tmp);

            /* RemoveAll */
            escuela.Cursos.Add(tmp);
            escuela.Cursos.RemoveAll(Predicado);

            escuela.Cursos.Add(tmp);
            Predicate<Curso> miAlgoritmo = Predicado; //Encapsulamiento de Algoritmos
            escuela.Cursos.RemoveAll(miAlgoritmo);

            /* delegado */
            escuela.Cursos.Add(tmp);
            escuela.Cursos.RemoveAll(delegate (Curso cur) { return cur.Nombre == "999"; });
            
            /* Expresion Lambda - mas conpacto */
            escuela.Cursos.Add(tmp);
            escuela.Cursos.RemoveAll((cur) => cur.Nombre == "999" && cur.TipoJornada == TiposJornada.Noche);

            WriteLine(escuela.ToString());

            WriteLine("\nPresione ENTER para continuar");
            ReadLine();

            ImprimirCursos(escuela);

            WriteLine("Curso.Hash " + tmp.GetHashCode());

        }
        
        private static bool Predicado(Curso obj)
        {
            return obj.Nombre == "999";
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
