using System;

namespace Proy_Escuela.Entidades
{
    public class Evaluaciones
    {
        public string UniqueId { get; private set; }
        public string Materia { get; set; }
        public double Calificacion { get; set; }

        public Evaluaciones() => UniqueId = Guid.NewGuid().ToString();
    }
}