using System;
using System.Collections.Generic;

namespace Proy_Escuela.Entidades
{
    public class Alumno
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public List<Evaluaciones> Calificaciones { get; set; }
        public Alumno() => UniqueId = Guid.NewGuid().ToString();
    }
}