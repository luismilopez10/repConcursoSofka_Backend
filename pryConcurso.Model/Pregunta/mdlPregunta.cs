using System;
using System.Collections.Generic;
using System.Text;

namespace pryConcurso.Model.Pregunta
{
    public class mdlPregunta
    {
        public int intIdPregunta { get; set; }
        public int intIdCategoria { get; set; }
        public string strPregunta { get; set; }
        public string strRespuesta { get; set; }
        public bool blnActivo { get; set; }
        public DateTime dtmActualiza { get; set; }
    }
}
