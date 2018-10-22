using System;
using System.Collections.Generic;
using System.Linq;
using Proy_Escuela.Entidades;
using Proy_Escuela.Util;
using static System.Console;

namespace Proy_Escuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }
        private static Random rng = new Random();
        public EscuelaEngine()
        {
            Escuela = new Escuela(_nombre: "Platzi Academy",
            _año: 2012,
            _tipo: TiposEscuela.Primaria,
            _ciudad: "Bogota",
            _pais: "Colombia");
        }

        public void Inicializar()
        {
            CargarCursos();
            CargarAsignaturas();
            int cantidad = 0;
            foreach (var curso in Escuela.Cursos)
            {
                cantidad = rng.Next(25, 32);
                curso.Alumnos = CargarAlumnos(_noAlumnos: cantidad);
            }
            //CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
            //throw new NotImplementedException();
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                var listaAsignaturas = new List<Asignatura>(){
                    new Asignatura{Nombre ="Matematicas"},
                    new Asignatura{Nombre ="Español"},
                    new Asignatura{Nombre ="Ciencias Naturales"},
                    new Asignatura{Nombre ="Ciencias Sociales"},
                    new Asignatura{Nombre ="Educación Fisica"},
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private List<Alumno> CargarAlumnos(int _noAlumnos)
        {
            string[] nombre = {"JUAN","JOSÉ LUIS","JOSÉ","MARÍA GUADALUPE","FRANCISCO","GUADALUPE","MARÍA","JUANA","ANTONIO",
                                "JESÚS","MIGUEL ÁNGEL","PEDRO","ALEJANDRO","MANUEL","MARGARITA","MARÍA DEL CARMEN","JUAN CARLOS",
                                "ROBERTO","FERNANDO","DANIEL","CARLOS","JORGE","RICARDO","MIGUEL","EDUARDO","JAVIER","RAFAEL",
                                "MARTÍN","RAÚL","DAVID","JOSEFINA","JOSÉ ANTONIO","ARTURO","MARCO ANTONIO","JOSÉ MANUEL",
                                "FRANCISCO JAVIER","ENRIQUE","VERÓNICA","GERARDO","MARÍA ELENA","LETICIA","ROSA","MARIO","FRANCISCA",
                                "ALFREDO","TERESA","ALICIA","MARÍA FERNANDA","SERGIO","ALBERTO","LUIS","ARMANDO","ALEJANDRA","MARTHA",
                                "SANTIAGO","YOLANDA","PATRICIA","MARÍA DE LOS ÁNGELES","JUAN MANUEL","ROSA MARÍA","ELIZABETH",
                                "GLORIA","ÁNGEL","GABRIELA","SALVADOR","VÍCTOR MANUEL","SILVIA","MARÍA DE GUADALUPE","MARÍA DE JESÚS",
                                "GABRIEL","ANDRÉS","ÓSCAR","GUILLERMO","ANA MARÍA","RAMÓN","MARÍA ISABEL","PABLO","RUBEN","ANTONIA",
                                "MARÍA LUISA","LUIS ÁNGEL","MARÍA DEL ROSARIO","FELIPE","JORGE JESÚS","JAIME","JOSÉ GUADALUPE",
                                "JULIO CESAR","JOSÉ DE JESÚS","DIEGO","ARACELI","ANDREA","ISABEL","MARÍA TERESA","IRMA","CARMEN",
                                "LUCÍA","ADRIANA","AGUSTÍN","MARÍA DE LA LUZ","GUSTAVO"};

            string[] apellido = {"GARCIA","GONZALEZ","RODRIGUEZ","FERNANDEZ","LOPEZ","MARTINEZ","SANCHEZ","PEREZ","GOMEZ","MARTIN",
                                    "JIMENEZ","RUIZ","HERNANDEZ","DIAZ","MORENO","MUÑOZ","ALVAREZ","ROMERO","ALONSO","GUTIERREZ",
                                    "NAVARRO","TORRES","DOMINGUEZ","VAZQUEZ","RAMOS","GIL","RAMIREZ","SERRANO","BLANCO","MOLINA",
                                    "MORALES","SUAREZ","ORTEGA","DELGADO","CASTRO","ORTIZ","RUBIO","MARIN","SANZ","NUÑEZ","IGLESIAS",
                                    "MEDINA","GARRIDO","CORTES","CASTILLO","SANTOS","LOZANO","GUERRERO","CANO","PRIETO","MENDEZ",
                                    "CRUZ","CALVO","GALLEGO","HERRERA","MARQUEZ","LEON","VIDAL","PEÑA","FLORES","CABRERA","CAMPOS",
                                    "VEGA","FUENTES","CARRASCO","DIEZ","REYES","CABALLERO","NIETO","AGUILAR","PASCUAL","SANTANA",
                                    "HERRERO","MONTERO","LORENZO","HIDALGO","GIMENEZ","IBAÑEZ","FERRER","DURAN","SANTIAGO","BENITEZ",
                                    "VARGAS","MORA","VICENTE","ARIAS","CARMONA","CRESPO","ROMAN","PASTOR","SOTO","SAEZ","VELASCO",
                                    "MOYA","SOLER","PARRA","ESTEBAN","BRAVO","GALLARDO","ROJAS"};
            var listaAlumnos = new List<Alumno>();

            for (int i = 0; i < _noAlumnos; i++)
            {
                listaAlumnos.Add(new Alumno() { Nombre = $"{nombre[rng.Next(0, nombre.Length)].ToString()} {apellido[rng.Next(0, apellido.Length)].ToString()}" });
            }

            return listaAlumnos;
        }

        private void CargarCursos()
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

        public void ImprimirCursos()
        {
            if (Escuela?.Cursos != null)
            {
                Printer.DibujarLinea(68);
                WriteLine(" Curso | UniqueID                             | Cant. | Tipo Jornada");
                Printer.DibujarLinea(68);
                foreach (var item in Escuela.Cursos)
                {
                    item.Imprimir();
                }
                Printer.DibujarLinea(68);
                WriteLine($"Registros: {Escuela.Cursos.Count}\n");
            }
        }
    }
}