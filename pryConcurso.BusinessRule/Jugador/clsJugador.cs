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
            List <mdlJugador> lstJugadorFiltro = new List<mdlJugador>();

            var Filtro = from jugador in lstJugador
                         group jugador by jugador.strNombre into GrupoJugador
                         select new
                         {
                             strNombre = GrupoJugador.Key,
                             intPuntajeTotal = GrupoJugador.Sum(puntaje => puntaje.intPuntaje)
                         };

            foreach (var jugador in Filtro)
                lstJugadorFiltro.Add(new mdlJugador { strNombre = jugador.strNombre, intPuntaje = jugador.intPuntajeTotal});

            return lstJugadorFiltro;
        }
    }
}
