using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using pryConcurso.Model.Jugador;
using pryConcurso.BusinessRule.Jugador;

namespace pryConcurso.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class JugadorController : ControllerBase
    {

        [HttpGet]
        [Route("fncIngresarJugador")]
        public string fncIngresarJugador(int intPuntaje, string strNombre)
        {
            mdlJugador objMdlJugador = new mdlJugador();
            clsJugador objClsJugador = new clsJugador();
            objMdlJugador.intPuntaje = intPuntaje;
            objMdlJugador.strNombre = strNombre;
            return objClsJugador.fncIngresarJugador(objMdlJugador);
        }

        [HttpGet]
        [Route("fncConsultarJugador")]
        public List<mdlJugador> fncConsultarJugador()
        {
            mdlJugador objMdlJugador = new mdlJugador();
            clsJugador objClsJugador = new clsJugador();
            return objClsJugador.fncConsultarJugador(objMdlJugador);
        }
    }
}
