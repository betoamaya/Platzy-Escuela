using System;
using System.Collections.Generic;
using Proy_Escuela.Entidades;
using Proy_Escuela.Util;
using static System.Console;

namespace Proy_Escuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            //Printer.MarioBros();
            Printer.Titulo("BIENVENIDO A LA ESCUELA");
            WriteLine(engine.Escuela.ToString());
            Dictionary<int, string> Diccionario = new Dictionary<int, string>();

            Diccionario.Add(key: 10, value: "Roberto");
            Diccionario.Add(key: 20, value: "Pruebas");

            foreach (var keyValuePair in Diccionario)
            {
                WriteLine($"key:{keyValuePair.Key} Value:{keyValuePair.Value}");
            }
            Diccionario[0]="Inicio";

            Printer.DibujarLinea();

            var dic = new Dictionary<string,string>();

            dic["Luna"] = "Cuerpo celeste que gira alrededor de la tierra";
            
            WriteLine($"Valor de 10 = {Diccionario[10]}");

            WriteLine("\nPresione ENTER para continuar");
            Printer.Beep(1568, 200);
            ReadLine();

            engine.ImprimirCursos();
        }
    }
}
