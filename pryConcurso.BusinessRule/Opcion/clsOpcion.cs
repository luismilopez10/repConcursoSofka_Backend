using System;
using System.Collections.Generic;
using System.Text;

using pryConcurso.Model.Opcion;
using pryConcurso.Broker.Operation;

namespace pryConcurso.BusinessRule.Opcion
{
    public class clsOpcion :itfOpcion
    {
        private optOpcion objOptOpcion = null;

        public clsOpcion()
        {
            objOptOpcion = new optOpcion();
        }

        public string fncIngresarOpcion(mdlOpcion objMdlOpcion)
        {
            return objOptOpcion.fncIngresarOpcion(objMdlOpcion);
        }

        public List<mdlOpcion> fncConsultarOpcion(mdlOpcion objMdlOpcion)
        {
            return objOptOpcion.fncConsultarOpcion(objMdlOpcion);
        }

        public List<mdlOpcion> fncConsultarOpcionIdPregunta(mdlOpcion objMdlOpcion)
        {
            return objOptOpcion.fncConsultarOpcionIdPregunta(objMdlOpcion);
        }
    }
}
