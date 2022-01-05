using NUnit.Framework;

using System.Net.Http;

namespace pryConcurso.NUnit
{
    public class tscConcurso
    {
        [SetUp]
        public void Setup()
        {
        }

        //--------------------------------------------Test Categoria--------------------------------------------
        [Test]
        public void fncIngresarCategoriaTest()
        {
            string strURL = @"https://pryconcursowebapi20210924070307.azurewebsites.net/api/Categoria/fncIngresarCategoria?intNivel=000&intPremio=000";

            HttpClient objHttpClient = new HttpClient();
            HttpResponseMessage objHttpResponseMessage = new HttpResponseMessage();
            objHttpResponseMessage = objHttpClient.GetAsync(strURL).Result;

            Assert.IsTrue(objHttpResponseMessage.IsSuccessStatusCode);
        }

        [Test]
        public void fncConsultarCategoriaTest()
        {
            string strURL = @"https://pryconcursowebapi20210924070307.azurewebsites.net/api/Categoria/fncConsultarCategoria";

            HttpClient objHttpClient = new HttpClient();
            HttpResponseMessage objHttpResponseMessage = new HttpResponseMessage();
            objHttpResponseMessage = objHttpClient.GetAsync(strURL).Result;

            Assert.IsTrue(objHttpResponseMessage.IsSuccessStatusCode);
        }


        //--------------------------------------------Test Pregunta--------------------------------------------
        [Test]
        public void fncIngresarPreguntaTest()
        {
            string strURL = @"https://pryconcursowebapi20210924070307.azurewebsites.net/api/Pregunta/fncIngresarPregunta?intIdCategoria=1&strPregunta=AAA&strRespuesta=BBB";

            HttpClient objHttpClient = new HttpClient();
            HttpResponseMessage objHttpResponseMessage = new HttpResponseMessage();
            objHttpResponseMessage = objHttpClient.GetAsync(strURL).Result;

            Assert.IsTrue(objHttpResponseMessage.IsSuccessStatusCode);
        }

        [Test]
        public void fncConsultarPreguntaTest()
        {
            string strURL = @"https://pryconcursowebapi20210924070307.azurewebsites.net/api/Pregunta/fncConsultarPregunta";

            HttpClient objHttpClient = new HttpClient();
            HttpResponseMessage objHttpResponseMessage = new HttpResponseMessage();
            objHttpResponseMessage = objHttpClient.GetAsync(strURL).Result;

            Assert.IsTrue(objHttpResponseMessage.IsSuccessStatusCode);
        }

        [Test]
        public void fncConsultarPreguntaIdCategoriaTest()
        {
            string strURL = @"https://pryconcursowebapi20210924070307.azurewebsites.net/api/Pregunta/fncConsultarPreguntaIdCategoria?intIdCategoria=1";

            HttpClient objHttpClient = new HttpClient();
            HttpResponseMessage objHttpResponseMessage = new HttpResponseMessage();
            objHttpResponseMessage = objHttpClient.GetAsync(strURL).Result;

            Assert.IsTrue(objHttpResponseMessage.IsSuccessStatusCode);
        }

        //--------------------------------------------Test Opcion--------------------------------------------
        [Test]
        public void fncIngresarOpcionTest()
        {
            string strURL = @"https://pryconcursowebapi20210924070307.azurewebsites.net/api/Opcion/fncIngresarOpcion?intIdPregunta=1&strOpcion=AAA";

            HttpClient objHttpClient = new HttpClient();
            HttpResponseMessage objHttpResponseMessage = new HttpResponseMessage();
            objHttpResponseMessage = objHttpClient.GetAsync(strURL).Result;

            Assert.IsTrue(objHttpResponseMessage.IsSuccessStatusCode);
        }

        [Test]
        public void fncConsultarOpcionTest()
        {
            string strURL = @"https://pryconcursowebapi20210924070307.azurewebsites.net/api/Opcion/fncConsultarOpcion";

            HttpClient objHttpClient = new HttpClient();
            HttpResponseMessage objHttpResponseMessage = new HttpResponseMessage();
            objHttpResponseMessage = objHttpClient.GetAsync(strURL).Result;

            Assert.IsTrue(objHttpResponseMessage.IsSuccessStatusCode);
        }

        [Test]
        public void fncConsultarOpcionIdPreguntaTest()
        {
            string strURL = @"https://pryconcursowebapi20210924070307.azurewebsites.net/api/Opcion/fncConsultarOpcionIdPregunta?intIdPregunta=1";

            HttpClient objHttpClient = new HttpClient();
            HttpResponseMessage objHttpResponseMessage = new HttpResponseMessage();
            objHttpResponseMessage = objHttpClient.GetAsync(strURL).Result;

            Assert.IsTrue(objHttpResponseMessage.IsSuccessStatusCode);
        }

        //--------------------------------------------Test Jugador--------------------------------------------
        [Test]
        public void fncIngresarJugadorTest()
        {
            string strURL = @"https://pryconcursowebapi20210924070307.azurewebsites.net/api/Jugador/fncIngresarJugador?intPuntaje=000&strNombre=AAA";

            HttpClient objHttpClient = new HttpClient();
            HttpResponseMessage objHttpResponseMessage = new HttpResponseMessage();
            objHttpResponseMessage = objHttpClient.GetAsync(strURL).Result;

            Assert.IsTrue(objHttpResponseMessage.IsSuccessStatusCode);
        }

        [Test]
        public void fncConsultarJugadorTest()
        {
            string strURL = @"https://pryconcursowebapi20210924070307.azurewebsites.net/api/Jugador/fncConsultarJugador";

            HttpClient objHttpClient = new HttpClient();
            HttpResponseMessage objHttpResponseMessage = new HttpResponseMessage();
            objHttpResponseMessage = objHttpClient.GetAsync(strURL).Result;

            Assert.IsTrue(objHttpResponseMessage.IsSuccessStatusCode);
        }
    }
}