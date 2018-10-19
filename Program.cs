using System;
using System.Collections.Generic;
using Proy_Escuela.Entidades;
using static System.Console;

namespace Proy_Escuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.inicializar();
            WriteLine(engine.Escuela.ToString());

            WriteLine("\nPresione ENTER para continuar");
            ReadLine();

            engine.imprimirCursos();

        }
    }
}
