using System;

namespace Proy_Escuela.Entidades
{
    public class Curso
    {
        public string UniqueId { get; private set; } //No puede ser modificado
        public string Nombre { get; set; }
        public TiposJornada TipoJornada { get; set; }
        public Curso() => UniqueId = Guid.NewGuid().ToString();
        public void Imprimir(){
            System.Console.WriteLine($"  {Nombre}  | {UniqueId} | {TipoJornada}");
        }
    }
}