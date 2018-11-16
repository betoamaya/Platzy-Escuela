using System;
using System.Collections.Generic;
using System.Linq;
using Proy_Escuela.Entidades;
using Proy_Escuela.Util;
using static System.Console;

namespace Proy_Escuela
{
    public sealed class EscuelaEngine
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
            CargarEvaluaciones();

            int numEvaluaciones = 0;
            var listaObjetos = ObtenerLista(out numEvaluaciones, _traeEvaludaciones: false);

            var listaObjetos2 = ObtenerLista(_traeEvaludaciones: false);
        }

        private void CargarEvaluaciones()
        {
            foreach (var curso in Escuela.Cursos)
            {
                foreach (var alumno in curso.Alumnos)
                {
                    alumno.Evaluaciones = generarEvaluaciones(curso.Asignaturas);
                }
            }
        }

        private List<Evaluación> generarEvaluaciones(List<Asignatura> asignaturas)
        {
            var listaCalificaciones = new List<Evaluación>();
            double califición = 0.0;
            foreach (var materia in asignaturas)
            {
                califición = rng.NextDouble() * (5.0 - 0.0) + 0.0;
                listaCalificaciones.Add(new Evaluación() { Nombre = materia.Nombre, Calificacion = califición });
            }
            return listaCalificaciones;
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
        /* public List<ObjetoEscuelaBase> ObtenerLista()
        {
            var lista = new List<ObjetoEscuelaBase>();
            lista.Add(Escuela);
            lista.AddRange(Escuela.Cursos);
            foreach (var curso in Escuela.Cursos)
            {
                lista.AddRange(curso.Alumnos);
                lista.AddRange(curso.Asignaturas);
                foreach (var alumno in curso.Alumnos)
                {
                    lista.AddRange(alumno.Evaluaciones);
                }
            }
            return lista;
        } */
        public List<ObjetoEscuelaBase> ObtenerLista(
            bool _traeCursos = true,
            bool _traeAlumnos = true,
            bool _traeAsignaturas = true,
            bool _traeEvaludaciones = true
           )
        {
            return ObtenerLista(out int dumy, _traeCursos, _traeAlumnos, _traeAsignaturas, _traeEvaludaciones);
        }

        public List<ObjetoEscuelaBase> ObtenerLista(
            out int numEvaluaciones,
            bool _traeCursos = true,
            bool _traeAlumnos = true,
            bool _traeAsignaturas = true,
            bool _traeEvaludaciones = true
            )
        {
            var lista = new List<ObjetoEscuelaBase>();
            numEvaluaciones = 0;
            lista.Add(Escuela);
            if (_traeCursos)
            {
                lista.AddRange(Escuela.Cursos);
            }
            foreach (var curso in Escuela.Cursos)
            {
                if (_traeAlumnos)
                {
                    lista.AddRange(curso.Alumnos);
                }
                if (_traeAsignaturas)
                {
                    lista.AddRange(curso.Asignaturas);
                }

                if (_traeEvaludaciones)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        lista.AddRange(alumno.Evaluaciones);
                        numEvaluaciones++;
                    }
                }

            }
            return (lista);
        }


        /*
                public (List<ObjetoEscuelaBase>, int) ObtenerLista(bool _traeCursos = true, bool _traeAlumnos = true, bool _traeAsignaturas = true, bool _traeEvaludaciones = true)
                {
                    var lista = new List<ObjetoEscuelaBase>();
                    int numEvaluaciones = 0;
                    lista.Add(Escuela);
                    if (_traeCursos)
                    {
                        lista.AddRange(Escuela.Cursos);
                    }
                    foreach (var curso in Escuela.Cursos)
                    {
                        if (_traeAlumnos)
                        {
                            lista.AddRange(curso.Alumnos);
                        }
                        if (_traeAsignaturas)
                        {
                            lista.AddRange(curso.Asignaturas);
                        }

                        if (_traeEvaludaciones)
                        {
                            foreach (var alumno in curso.Alumnos)
                            {
                                lista.AddRange(alumno.Evaluaciones);
                                numEvaluaciones ++;
                            }
                        }

                    }
                    return (lista, numEvaluaciones);
                }
                 */
    }
}