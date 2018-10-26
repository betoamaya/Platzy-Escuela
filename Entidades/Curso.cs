using System;
using System.Collections.Generic;

namespace Proy_Escuela.Entidades
{
    public class Curso: ObjetoEscuelaBase
    {
        public TiposJornada TipoJornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos{ get; set; }
        public void Imprimir(){
            System.Console.WriteLine($"  {Nombre}  | {UniqueId} |  {Alumnos.Count}   | {TipoJornada} ");
        }
    }
}