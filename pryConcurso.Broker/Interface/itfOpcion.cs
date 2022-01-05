using System;
using System.Collections.Generic;
using System.Text;

using pryConcurso.Model.Opcion;

namespace pryConcurso.Broker.Interface
{
    public interface itfOpcion
    {
        string fncIngresarOpcion(mdlOpcion objMdlOpcion);
        List<mdlOpcion> fncConsultarOpcion(mdlOpcion objMdlOpcion);
        List<mdlOpcion> fncConsultarOpcionIdPregunta(mdlOpcion objMdlOpcion);
    }
}
