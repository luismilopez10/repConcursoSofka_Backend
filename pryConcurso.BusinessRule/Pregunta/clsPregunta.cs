using System;
using System.Collections.Generic;
using System.Text;

using pryConcurso.Model.Pregunta;
using pryConcurso.Broker.Operation;

namespace pryConcurso.BusinessRule.Pregunta
{
    public class clsPregunta : itfPregunta
    {
        private optPregunta objOptPregunta = null;
        public clsPregunta()
        {
            objOptPregunta = new optPregunta();
        }

        public string fncIngresarPregunta(mdlPregunta objMdlPregunta)
        {
            return objOptPregunta.fncIngresarPregunta(objMdlPregunta);
        }

        public List<mdlPregunta> fncConsultarPregunta(mdlPregunta objMdlPregunta)
        {
            return objOptPregunta.fncConsultarPregunta(objMdlPregunta);
        }

        public List<mdlPregunta> fncConsultarPreguntaIdCategoria(mdlPregunta objMdlPregunta)
        {
            return objOptPregunta.fncConsultarPreguntaIdCategoria(objMdlPregunta);
        }

        public List<mdlPregunta> fncConsultarPreguntaNivel(mdlPregunta objMdlPregunta, int intNivel)
        {
            return objOptPregunta.fncConsultarPreguntaNivel(objMdlPregunta, intNivel);
        }
    }
}
