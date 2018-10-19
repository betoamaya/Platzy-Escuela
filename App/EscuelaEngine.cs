using System.Collections.Generic;
using Proy_Escuela.Entidades;
using static System.Console;

namespace Proy_Escuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {
            Escuela = new Escuela(_nombre: "Platzi Academy",
            _año: 2012,
            _tipo: TiposEscuela.Primaria,
            _ciudad: "Bogota",
            _pais: "Colombia");
        }

        public void inicializar()
        {
            Escuela.Cursos = new List<Curso>()
            {
                new Curso(){Nombre = "101", TipoJornada = TiposJornada.Mañana},
                new Curso(){Nombre = "201", TipoJornada = TiposJornada.Mañana},
                new Curso(){Nombre = "301", TipoJornada = TiposJornada.Mañana},
                new Curso(){Nombre = "401", TipoJornada = TiposJornada.Mañana},
                new Curso(){Nombre = "501", TipoJornada = TiposJornada.Mañana},
                new Curso(){Nombre = "601", TipoJornada = TiposJornada.Mañana},
                new Curso(){Nombre = "102", TipoJornada = TiposJornada.Tarde},
                new Curso(){Nombre = "202", TipoJornada = TiposJornada.Tarde},
                new Curso(){Nombre = "302", TipoJornada = TiposJornada.Tarde},
                new Curso(){Nombre = "402", TipoJornada = TiposJornada.Tarde},
                new Curso(){Nombre = "103", TipoJornada = TiposJornada.Noche},
                new Curso(){Nombre = "203", TipoJornada = TiposJornada.Noche},
                new Curso(){Nombre = "303", TipoJornada = TiposJornada.Noche},
                new Curso(){Nombre = "403", TipoJornada = TiposJornada.Noche},
                new Curso(){Nombre = "503", TipoJornada = TiposJornada.Noche},
                new Curso(){Nombre = "603", TipoJornada = TiposJornada.Noche}
            };
        }
        public void imprimirCursos(){
            if (Escuela?.Cursos != null)
            {
                WriteLine("============================================================");
                WriteLine(" Curso | UniqueID                             | Tipo Jornada");
                WriteLine("============================================================");
                foreach (var item in Escuela.Cursos)
                {
                    item.Imprimir();
                }
                WriteLine("============================================================");
                WriteLine($"Registros: {Escuela.Cursos.Count}\n");
            }
        }
    }
}