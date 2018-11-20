using System.Collections.Generic;
using Proy_Escuela.Entidades;

namespace Proy_Escuela.App
{
    public class Reporteador
    {
        Dictionary<LlavesDiccionario, IReadOnlyList<ObjetoEscuelaBase>> diccionario;
        public Reporteador(Dictionary<LlavesDiccionario, IReadOnlyList<ObjetoEscuelaBase>> _dicObjetosEscuela)
        {
            if (_dicObjetosEscuela == null)
            {
                throw new System.ArgumentNullException(nameof(_dicObjetosEscuela));
            }else{
                diccionario = _dicObjetosEscuela;
            }
            
        }

       /*  public IEnumerable<Evaluación> GetListaEvaluaciones(){
           // IEnumerable<Evaluación> resultado = diccionario(LlavesDiccionario.Evaluaciones);


           // return resultado;
        } */
    }
}