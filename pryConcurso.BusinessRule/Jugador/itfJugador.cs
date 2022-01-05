using System;
using System.Collections.Generic;
using System.Text;

using pryConcurso.Model.Jugador;

namespace pryConcurso.BusinessRule.Jugador
{
    public interface itfJugador
    {
        string fncIngresarJugador(mdlJugador objMdlJugador);
        List<mdlJugador> fncConsultarJugador(mdlJugador objMdlJugador);
    }
}
