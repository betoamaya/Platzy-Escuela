using System;

namespace Proy_Escuela.Entidades
{
    public class Evaluación
    {
        public string UniqueId { get; private set; }
        public string Materia { get; set; }
        //public Alumno Alumno { get; set; }
        //public Asignatura Asignatura { get; set;}
        public double Calificacion { get; set; }

        public Evaluación() => UniqueId = Guid.NewGuid().ToString();
    }
}