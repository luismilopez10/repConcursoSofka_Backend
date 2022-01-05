using System;
using System.Collections.Generic;
using System.Text;

namespace pryConcurso.Model.Jugador
{
    public class mdlJugador
    {
        public int intIdJugador { get; set; }
        public int intPuntaje { get; set; }
        public string strNombre { get; set; }
        public bool blnActivo { get; set; }
        public DateTime dtmActualiza { get; set; }
    }
}
