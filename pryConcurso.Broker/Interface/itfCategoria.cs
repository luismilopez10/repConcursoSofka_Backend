using System;
using System.Collections.Generic;
using System.Text;

using pryConcurso.Model.Categoria;

namespace pryConcurso.Broker.Interface
{
    public interface itfCategoria
    {
        string fncIngresarCategoria(mdlCategoria objMdlCategoria);
        List<mdlCategoria> fncConsultarCategoria(mdlCategoria objMdlCategoria);
    }
}
