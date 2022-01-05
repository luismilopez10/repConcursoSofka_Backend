using System;
using System.Collections.Generic;
using System.Text;

namespace pryConcurso.Model.Categoria
{
    public class mdlCategoria
    {
        public int intIdCategoria { get; set; }
        public int intNivel { get; set; }
        public int intPremio { get; set; }
        public bool blnActivo { get; set; }
        public DateTime dtmActualiza { get; set; }
    }
}
