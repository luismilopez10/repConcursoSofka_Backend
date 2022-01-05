using System;
using System.Collections.Generic;
using System.Text;

using pryConcurso.Model.Categoria;
using pryConcurso.Broker.Operation;
using System.Linq;

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
        public List<mdlCategoria> fncConsultarCategoriaNivel(mdlCategoria objMdlCategoria)
        {
            List<mdlCategoria> lstCategoriaNivel = objOptCategoria.fncConsultarCategoria(objMdlCategoria);
            List<mdlCategoria> lstCategoriaNivelFiltro = new List<mdlCategoria>();

            var Filtro = from categoria in lstCategoriaNivel
                         where categoria.intNivel == objMdlCategoria.intNivel
                         select categoria;

            foreach (var categoria in Filtro)
                lstCategoriaNivelFiltro.Add(categoria);

            return lstCategoriaNivelFiltro;
        }
    }
}
