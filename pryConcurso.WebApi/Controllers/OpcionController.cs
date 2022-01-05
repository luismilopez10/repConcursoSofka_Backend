using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using pryConcurso.Model.Opcion;
using pryConcurso.BusinessRule.Opcion;

namespace pryConcurso.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class OpcionController : ControllerBase
    {

        [HttpGet]
        [Route("fncIngresarOpcion")]
        public string fncIngresarOpcion(int intIdPregunta, string strOpcion)
        {
            mdlOpcion objMdlOpcion = new mdlOpcion();
            clsOpcion objClsOpcion = new clsOpcion();
            objMdlOpcion.intIdPregunta = intIdPregunta;
            objMdlOpcion.strOpcion = strOpcion;
            return objClsOpcion.fncIngresarOpcion(objMdlOpcion);
        }

        [HttpGet]
        [Route("fncConsultarOpcion")]
        public List<mdlOpcion> fncConsultarOpcion()
        {
            mdlOpcion objMdlOpcion = new mdlOpcion();
            clsOpcion objClsOpcion = new clsOpcion();
            return objClsOpcion.fncConsultarOpcion(objMdlOpcion);
        }

        [HttpGet]
        [Route("fncConsultarOpcionIdPregunta")]
        public List<mdlOpcion> fncConsultarOpcionIdPregunta(int intIdPregunta)
        {
            mdlOpcion objMdlOpcion = new mdlOpcion();
            clsOpcion objClsOpcion = new clsOpcion();
            objMdlOpcion.intIdPregunta = intIdPregunta;
            return objClsOpcion.fncConsultarOpcionIdPregunta(objMdlOpcion);
        }
    }
}
