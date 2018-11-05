using System;
using System.Collections.Generic;
using Proy_Escuela.Util;

namespace Proy_Escuela.Entidades
{
    public class Escuela: ObjetoEscuelaBase, ILugar
    {
        public int AñoDeCreación { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public string Dirección { get; set; }
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

        public void LimpiarLugar()
        {
           Printer.DibujarLinea();
           Console.WriteLine("Limpiando Escuela...");
           foreach (var item in Cursos)
           {
               item.LimpiarLugar();
           }
           Console.WriteLine("Escuela {Nombre} Limpio");
        }

       
    }
}