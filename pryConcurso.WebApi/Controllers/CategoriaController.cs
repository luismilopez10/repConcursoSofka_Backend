using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using pryConcurso.Model.Categoria;
using pryConcurso.BusinessRule.Categoria;

namespace pryConcurso.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class CategoriaController : ControllerBase
    {
        /// <summary>
        /// fncIngresarCategoria
        /// </summary>
        /// <param name="intNivel"></param>
        /// <param name="intPremio"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("fncIngresarCategoria")]
        public string fncIngresarCategoria(int intNivel, int intPremio)
        {
            mdlCategoria objMdlCategoria = new mdlCategoria();
            clsCategoria objClsCategoria = new clsCategoria();
            objMdlCategoria.intNivel = intNivel;
            objMdlCategoria.intPremio = intPremio;
            return objClsCategoria.fncIngresarCategoria(objMdlCategoria);
        }

        /// <summary>
        /// fncConsultarCategoria
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("fncConsultarCategoria")]
        public List<mdlCategoria> fncConsultarCategoria()
        {
            mdlCategoria objMdlCategoria = new mdlCategoria();
            clsCategoria objClsCategoria = new clsCategoria();
            return objClsCategoria.fncConsultarCategoria(objMdlCategoria);
        }
    }
}
