using System;
using System.Collections.Generic;
using System.Text;

using pryConcurso.Model.Categoria;
using pryConcurso.Broker.Operation;

namespace pryConcurso.BusinessRule.Categoria
{
    public class clsCategoria : itfCategoria
    {
        private optCategoria objOptCategoria = null;

        public clsCategoria()
        {
            objOptCategoria = new optCategoria();
        }

        public string fncIngresarCategoria(mdlCategoria objMdlCategoria)
        {
            return objOptCategoria.fncIngresarCategoria(objMdlCategoria);
        }
        public List<mdlCategoria> fncConsultarCategoria(mdlCategoria objMdlCategoria)
        {
            return objOptCategoria.fncConsultarCategoria(objMdlCategoria);
        }
    }
}
