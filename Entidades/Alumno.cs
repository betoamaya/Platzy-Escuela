using System;
using System.Collections.Generic;

namespace Proy_Escuela.Entidades
{
    public class Alumno: ObjetoEscuelaBase
    {
        public List<Evaluación> Evaluaciones { get; set; }
    }
}