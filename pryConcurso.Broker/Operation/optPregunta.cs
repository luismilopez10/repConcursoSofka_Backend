using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using pryConcurso.Model.Pregunta;
using pryConcurso.Broker.Procedure;
using pryConcurso.Broker.Interface;

namespace pryConcurso.Broker.Operation
{
    public class optPregunta : itfPregunta
    {
        string strConnectionString = DBConnection.strConnectionString;

        SqlConnection objCon = null;
        SqlCommand objCom = null;
        spaPregunta objSpaPregunta = null;
        SqlDataAdapter objDap = null;
        DataSet objDst = null;
        List<mdlPregunta> lstPregunta = null;

        public optPregunta()
        {
        }



        public string fncIngresarPregunta(mdlPregunta objMdlPregunta)
        {
            int intResultado;
            string strResultado = "";
            objCon = new SqlConnection(strConnectionString);
            objSpaPregunta = new spaPregunta();

            try
            {
                objCon.Open();
                objCom = new SqlCommand(objSpaPregunta.spaIngresarPregunta, objCon);
                objCom.CommandType = CommandType.StoredProcedure;
                objCom.Parameters.AddWithValue("@intIdCategoria", objMdlPregunta.intIdCategoria);
                objCom.Parameters.AddWithValue("@strPregunta", objMdlPregunta.strPregunta);
                objCom.Parameters.AddWithValue("@strRespuesta", objMdlPregunta.strRespuesta);
                intResultado = objCom.ExecuteNonQuery();

                if (intResultado > 0)
                {
                    strResultado = "Ingresar Exitoso";
                }
                else
                {
                    strResultado = "Ingresar Fallido";
                }
            }
            catch (SqlException ex)
            {
                strResultado = ex.Message.ToString();
            }
            finally
            {
                objCon.Close();
            }

            return strResultado;
        }


        public List<mdlPregunta> fncConsultarPregunta(mdlPregunta objMdlPregunta)
        {
            string strResultado;

            objCon = new SqlConnection(strConnectionString);
            objSpaPregunta = new spaPregunta();

            try
            {
                objCon.Open();
                objCom = new SqlCommand(objSpaPregunta.spaConsultarPregunta, objCon);
                objCom.CommandType = CommandType.StoredProcedure;

                objDap = new SqlDataAdapter();
                objDap.SelectCommand = objCom;

                objDst = new DataSet();
                objDap.Fill(objDst);

                lstPregunta = new List<mdlPregunta>();

                for (int i = 0; i < objDst.Tables[0].Rows.Count; i++)
                {
                    objMdlPregunta = new mdlPregunta();
                    objMdlPregunta.intIdPregunta = Convert.ToInt32(objDst.Tables[0].Rows[i]["intIdPregunta"].ToString());
                    objMdlPregunta.intIdCategoria = Convert.ToInt32(objDst.Tables[0].Rows[i]["intIdCategoria"].ToString());
                    objMdlPregunta.strPregunta = Convert.ToString(objDst.Tables[0].Rows[i]["strPregunta"].ToString());
                    objMdlPregunta.strRespuesta = Convert.ToString(objDst.Tables[0].Rows[i]["strRespuesta"].ToString());
                    objMdlPregunta.blnActivo = Convert.ToBoolean(objDst.Tables[0].Rows[i]["blnActivo"].ToString());
                    objMdlPregunta.dtmActualiza = Convert.ToDateTime(objDst.Tables[0].Rows[i]["dtmActualiza"].ToString());
                    lstPregunta.Add(objMdlPregunta);
                }

            }
            catch (SqlException ex)
            {
                strResultado = ex.Message.ToString();
            }
            finally
            {
                objCon.Close();
            }
            return lstPregunta;
        }


        public List<mdlPregunta> fncConsultarPreguntaIdCategoria(mdlPregunta objMdlPregunta)
        {
            string strResultado;

            objCon = new SqlConnection(strConnectionString);
            objSpaPregunta = new spaPregunta();

            try
            {
                objCon.Open();
                objCom = new SqlCommand(objSpaPregunta.spaConsultarPreguntaIdCategoria, objCon);
                objCom.CommandType = CommandType.StoredProcedure;
                objCom.Parameters.AddWithValue("@intIdCategoria", objMdlPregunta.intIdCategoria);

                objDap = new SqlDataAdapter();
                objDap.SelectCommand = objCom;

                objDst = new DataSet();
                objDap.Fill(objDst);

                lstPregunta = new List<mdlPregunta>();

                for (int i = 0; i < objDst.Tables[0].Rows.Count; i++)
                {
                    objMdlPregunta = new mdlPregunta();
                    objMdlPregunta.intIdPregunta = Convert.ToInt32(objDst.Tables[0].Rows[i]["intIdPregunta"].ToString());
                    objMdlPregunta.intIdCategoria = Convert.ToInt32(objDst.Tables[0].Rows[i]["intIdCategoria"].ToString());
                    objMdlPregunta.strPregunta = Convert.ToString(objDst.Tables[0].Rows[i]["strPregunta"].ToString());
                    objMdlPregunta.strRespuesta = Convert.ToString(objDst.Tables[0].Rows[i]["strRespuesta"].ToString());
                    objMdlPregunta.blnActivo = Convert.ToBoolean(objDst.Tables[0].Rows[i]["blnActivo"].ToString());
                    objMdlPregunta.dtmActualiza = Convert.ToDateTime(objDst.Tables[0].Rows[i]["dtmActualiza"].ToString());
                    lstPregunta.Add(objMdlPregunta);
                }

            }
            catch (SqlException ex)
            {
                strResultado = ex.Message.ToString();
            }
            finally
            {
                objCon.Close();
            }
            return lstPregunta;
        }


        public List<mdlPregunta> fncConsultarPreguntaNivel(mdlPregunta objMdlPregunta, int intNivel)
        {
            string strResultado;

            objCon = new SqlConnection(strConnectionString);
            objSpaPregunta = new spaPregunta();

            try
            {
                objCon.Open();
                objCom = new SqlCommand(objSpaPregunta.spaConsultarPreguntaNivel, objCon);
                objCom.CommandType = CommandType.StoredProcedure;
                objCom.Parameters.AddWithValue("@intNivel", intNivel);

                objDap = new SqlDataAdapter();
                objDap.SelectCommand = objCom;

                objDst = new DataSet();
                objDap.Fill(objDst);

                lstPregunta = new List<mdlPregunta>();

                for (int i = 0; i < objDst.Tables[0].Rows.Count; i++)
                {
                    objMdlPregunta = new mdlPregunta();
                    objMdlPregunta.intIdPregunta = Convert.ToInt32(objDst.Tables[0].Rows[i]["intIdPregunta"].ToString());
                    objMdlPregunta.intIdCategoria = Convert.ToInt32(objDst.Tables[0].Rows[i]["intIdCategoria"].ToString());
                    objMdlPregunta.strPregunta = Convert.ToString(objDst.Tables[0].Rows[i]["strPregunta"].ToString());
                    objMdlPregunta.strRespuesta = Convert.ToString(objDst.Tables[0].Rows[i]["strRespuesta"].ToString());
                    objMdlPregunta.blnActivo = Convert.ToBoolean(objDst.Tables[0].Rows[i]["blnActivo"].ToString());
                    objMdlPregunta.dtmActualiza = Convert.ToDateTime(objDst.Tables[0].Rows[i]["dtmActualiza"].ToString());
                    lstPregunta.Add(objMdlPregunta);
                }

            }
            catch (SqlException ex)
            {
                strResultado = ex.Message.ToString();
            }
            finally
            {
                objCon.Close();
            }
            return lstPregunta;
        }
    }
}
