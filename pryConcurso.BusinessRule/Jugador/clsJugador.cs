using System;
using System.Collections.Generic;
using System.Text;

using pryConcurso.Model.Jugador;
using pryConcurso.Broker.Operation;

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
            return objOptJugador.fncIngresarJugador(objMdlJugador);
        }
        public List<mdlJugador> fncConsultarJugador(mdlJugador objMdlJugador)
        {
            return objOptJugador.fncConsultarJugador(objMdlJugador);
        }
    }
}
