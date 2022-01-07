using System;
using System.Collections.Generic;
using System.Text;

using pryConcurso.Model.Jugador;
using pryConcurso.Broker.Operation;
using System.Linq;

namespace pryConcurso.BusinessRule.Jugador
{
    public class clsJugador : itfJugador
    {
        private optJugador objOptJugador = null;

        public clsJugador()
        {
            objOptJugador = new optJugador();
        }

        public string fncIngresarJugador(mdlJugador objMdlJugador)
        {
            objMdlJugador.strNombre = objMdlJugador.strNombre.ToUpper();
            return objOptJugador.fncIngresarJugador(objMdlJugador);
        }

        public List<mdlJugador> fncConsultarJugador(mdlJugador objMdlJugador)
        {
            List<mdlJugador> lstJugador = objOptJugador.fncConsultarJugador(objMdlJugador);
            List<mdlJugador> lstJugadorFiltroPuntaje = new List<mdlJugador>();
            List<mdlJugador> lstJugadorFiltroDescendiente = new List<mdlJugador>();

            // Filtro para sumar puntaje acomulado para nombres iguales
            var FiltroPuntaje = from jugador in lstJugador
                         group jugador by jugador.strNombre into GrupoJugador
                         select new
                         {
                             strNombre = GrupoJugador.Key,
                             intPuntajeTotal = GrupoJugador.Sum(puntaje => puntaje.intPuntaje)
                         };

            foreach (var jugador in FiltroPuntaje)
                lstJugadorFiltroPuntaje.Add(new mdlJugador { strNombre = jugador.strNombre, intPuntaje = jugador.intPuntajeTotal});

            // Filtro para ordenar en descendiente
            var FiltroDescendiente = from jugador in lstJugadorFiltroPuntaje
                                     orderby jugador.intPuntaje descending
                                     select jugador;

            foreach (var jugador in FiltroDescendiente)
                lstJugadorFiltroDescendiente.Add(jugador);

            return lstJugadorFiltroDescendiente;
        }
    }
}
