using System;
using System.Collections.Generic;
using System.Text;

namespace pryConcurso.Model.Opcion
{
    public class mdlOpcion
    {
        public int intIdOpcion { get; set; }
        public int intIdPregunta { get; set; }
        public string strOpcion { get; set; }
        public bool blnActivo { get; set; }
        public DateTime dtmActualiza { get; set; }
    }
}
