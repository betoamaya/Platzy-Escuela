using System;
using System.Collections.Generic;
using Proy_Escuela.Util;

namespace Proy_Escuela.Entidades
{
    public class Curso: ObjetoEscuelaBase, ILugar
    {
        public TiposJornada TipoJornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos{ get; set; }
        public string Dirección { get; set; }

        public void Imprimir(){
            System.Console.WriteLine($"  {Nombre}  | {UniqueId} |  {Alumnos.Count}   | {TipoJornada} ");
        }

        public void LimpiarLugar()
        {
           Printer.DibujarLinea();
           Console.WriteLine("Limpiando Establecimiento...");
           Console.WriteLine("Curso {Nombre} Limpio");
        }
    }
}