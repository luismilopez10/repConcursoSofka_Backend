using System;
using System.Collections.Generic;
using System.Text;

using pryConcurso.Model.Pregunta;

namespace pryConcurso.Broker.Interface
{
    public interface itfPregunta
    {
        string fncIngresarPregunta(mdlPregunta objMdlPregunta);
        List<mdlPregunta> fncConsultarPregunta(mdlPregunta objMdlPregunta);
        List<mdlPregunta> fncConsultarPreguntaIdCategoria(mdlPregunta objMdlPregunta);
        List<mdlPregunta> fncConsultarPreguntaNivel(mdlPregunta objMdlPregunta, int intNivel);
    }
}
