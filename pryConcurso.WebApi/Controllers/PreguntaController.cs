using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using pryConcurso.Model.Pregunta;
using pryConcurso.BusinessRule.Pregunta;

namespace pryConcurso.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class PreguntaController : ControllerBase
    {

        [HttpGet]
        [Route("fncIngresarPregunta")]
        public string fncIngresarPregunta(int intIdCategoria, string strPregunta, string strRespuesta)
        {
            mdlPregunta objMdlPregunta = new mdlPregunta();
            clsPregunta objClsPregunta = new clsPregunta();
            objMdlPregunta.intIdCategoria = intIdCategoria;
            objMdlPregunta.strPregunta = strPregunta;
            objMdlPregunta.strRespuesta = strRespuesta;
            return objClsPregunta.fncIngresarPregunta(objMdlPregunta);
        }

        [HttpGet]
        [Route("fncConsultarPregunta")]
        public List<mdlPregunta> fncConsultarPregunta()
        {
            mdlPregunta objMdlPregunta = new mdlPregunta();
            clsPregunta objClsPregunta = new clsPregunta();
            return objClsPregunta.fncConsultarPregunta(objMdlPregunta);
        }

        [HttpGet]
        [Route("fncConsultarPreguntaIdCategoria")]
        public List<mdlPregunta> fncConsultarPreguntaIdCategoria(int intIdCategoria)
        {
            mdlPregunta objMdlPregunta = new mdlPregunta();
            clsPregunta objClsPregunta = new clsPregunta();
            objMdlPregunta.intIdCategoria = intIdCategoria;
            return objClsPregunta.fncConsultarPreguntaIdCategoria(objMdlPregunta);
        }
    }
}
