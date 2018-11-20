using System;
using System.Collections.Generic;
using Proy_Escuela.App;
using Proy_Escuela.Entidades;
using Proy_Escuela.Util;
using static System.Console;

namespace Proy_Escuela
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.ProcessExit += AccionDelEvento;

            var engine = new EscuelaEngine();
            engine.Inicializar();
            //Printer.MarioBros();
            Printer.Titulo("BIENVENIDO A LA ESCUELA");
            WriteLine(engine.Escuela.ToString());

            WriteLine("\nPresione ENTER para continuar");
            Printer.Beep(1568, 200);
            //ReadLine();

            engine.ImprimirCursos();

            try
            {
                var reporteador = new Reporteador(engine.getDiciionarioObjetos());
                //var reporteador = new Reporteador(null);  
                var lista = reporteador.GetListaEvaluaciones();  
            }
            catch (System.Exception ex)
            {

                WriteLine($"Error:{ex.Source} Mensaje: {ex.Message}");
            }

            

            /* var resultado = engine.getDiciionarioObjetos();
            engine.imprimirDiccionario(resultado, _imprimirEscuela: true, _imprimirCursos: true, _imprimirAlumno: true); */
        }

        private static void AccionDelEvento(object sender, EventArgs e)
        {
            Printer.Titulo("Saliendo...");
            Printer.MarioBros();
        }
    }
}
