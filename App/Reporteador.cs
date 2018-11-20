using System.Linq;
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

        public IEnumerable<ObjetoEscuelaBase> GetListaEvaluaciones(){
           var lista = diccionario.GetValueOrDefault(LlavesDiccionario.Escuela);
            if (lista == null)
            {
                throw new System.ArgumentNullException(nameof(lista));
            }

            return lista.Cast<ObjetoEscuelaBase>();
        }
    }
}