using System;
using System.Collections.Generic;

namespace Proy_Escuela.Entidades
{
    public class Escuela
    {
        public string Nombre { get; set; }
        public int AñoDeCreación { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public TiposEscuela TipoEscuela { get; set; }

        public List<Curso> Cursos { get; set; }

        public Escuela(string _nombre, int _año, TiposEscuela _tipo, string _ciudad = "",string _pais = "")
        {
            (this.Nombre, this.AñoDeCreación, this.TipoEscuela) = (_nombre, _año, _tipo);
            this.Ciudad = _ciudad;
            this.Pais = _pais;
        }

        public Escuela(string _nombre, int _año, string _ciudad, string _pais) => (Nombre, AñoDeCreación, Ciudad, Pais) = (_nombre, _año, _ciudad, _pais);

        public override string ToString()
        {
            return $"{TipoEscuela} \"{Nombre}\"!!! {System.Environment.NewLine}Fundada desde {AñoDeCreación} \nEn{Ciudad}, {Pais}";
        }

       
    }
}