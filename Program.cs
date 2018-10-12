using System;
using Proy_Escuela.Entidades;

namespace Proy_Escuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela(_nombre: "Platzi Academy",
            _año: 2012,
            _tipo: TiposEscuela.Primaria,
            _ciudad: "Bogota",
            _pais: "Colombia");
            
            var curso1 = new Curso(){
                Nombre = "101"
            };
            var curso2 = new Curso(){
                Nombre = "201"
            };
            var curso3 = new Curso(){
                Nombre = "301"
            };

            Console.WriteLine(escuela.ToString());
            System.Console.WriteLine("=============================================");
            System.Console.WriteLine(" Curso | UniqueID");
            curso1.Imprimir();
            curso2.Imprimir();
            curso3.Imprimir();
            System.Console.WriteLine("=============================================");
        }
    }
}
