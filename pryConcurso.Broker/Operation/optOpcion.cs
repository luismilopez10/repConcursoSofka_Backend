using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using pryConcurso.Model.Opcion;
using pryConcurso.Broker.Procedure;
using pryConcurso.Broker.Interface;

namespace pryConcurso.Broker.Operation
{
    public class optOpcion : itfOpcion
    {
        string strConnectionString = DBConnection.strConnectionString;

        SqlConnection objCon = null;
        SqlCommand objCom = null;
        spaOpcion objSpaOpcion = null;
        SqlDataAdapter objDap = null;
        DataSet objDst = null;
        List<mdlOpcion> lstOpcion = null;

        public optOpcion()
        {
        }



        public string fncIngresarOpcion(mdlOpcion objMdlOpcion)
        {
            int intResultado;
            string strResultado = "";
            objCon = new SqlConnection(strConnectionString);
            objSpaOpcion = new spaOpcion();

            try
            {
                objCon.Open();
                objCom = new SqlCommand(objSpaOpcion.spaIngresarOpcion, objCon);
                objCom.CommandType = CommandType.StoredProcedure;
                objCom.Parameters.AddWithValue("@intIdPregunta", objMdlOpcion.intIdPregunta);
                objCom.Parameters.AddWithValue("@strOpcion", objMdlOpcion.strOpcion);
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


        public List<mdlOpcion> fncConsultarOpcion(mdlOpcion objMdlOpcion)
        {
            string strResultado;

            objCon = new SqlConnection(strConnectionString);
            objSpaOpcion = new spaOpcion();

            try
            {
                objCon.Open();
                objCom = new SqlCommand(objSpaOpcion.spaConsultarOpcion, objCon);
                objCom.CommandType = CommandType.StoredProcedure;

                objDap = new SqlDataAdapter();
                objDap.SelectCommand = objCom;

                objDst = new DataSet();
                objDap.Fill(objDst);

                lstOpcion = new List<mdlOpcion>();

                for (int i = 0; i < objDst.Tables[0].Rows.Count; i++)
                {
                    objMdlOpcion = new mdlOpcion();
                    objMdlOpcion.intIdOpcion = Convert.ToInt32(objDst.Tables[0].Rows[i]["intIdOpcion"].ToString());
                    objMdlOpcion.intIdPregunta = Convert.ToInt32(objDst.Tables[0].Rows[i]["intIdPregunta"].ToString());
                    objMdlOpcion.strOpcion = Convert.ToString(objDst.Tables[0].Rows[i]["strOpcion"].ToString());
                    objMdlOpcion.blnActivo = Convert.ToBoolean(objDst.Tables[0].Rows[i]["blnActivo"].ToString());
                    objMdlOpcion.dtmActualiza = Convert.ToDateTime(objDst.Tables[0].Rows[i]["dtmActualiza"].ToString());
                    lstOpcion.Add(objMdlOpcion);
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
            return lstOpcion;
        }


        public List<mdlOpcion> fncConsultarOpcionIdPregunta(mdlOpcion objMdlOpcion)
        {
            string strResultado;

            objCon = new SqlConnection(strConnectionString);
            objSpaOpcion = new spaOpcion();

            try
            {
                objCon.Open();
                objCom = new SqlCommand(objSpaOpcion.spaConsultarOpcionIdPregunta, objCon);
                objCom.CommandType = CommandType.StoredProcedure;
                objCom.Parameters.AddWithValue("@intIdPregunta", objMdlOpcion.intIdPregunta);

                objDap = new SqlDataAdapter();
                objDap.SelectCommand = objCom;

                objDst = new DataSet();
                objDap.Fill(objDst);

                lstOpcion = new List<mdlOpcion>();

                for (int i = 0; i < objDst.Tables[0].Rows.Count; i++)
                {
                    objMdlOpcion = new mdlOpcion();
                    objMdlOpcion.intIdOpcion = Convert.ToInt32(objDst.Tables[0].Rows[i]["intIdOpcion"].ToString());
                    objMdlOpcion.intIdPregunta = Convert.ToInt32(objDst.Tables[0].Rows[i]["intIdPregunta"].ToString());
                    objMdlOpcion.strOpcion = Convert.ToString(objDst.Tables[0].Rows[i]["strOpcion"].ToString());
                    objMdlOpcion.blnActivo = Convert.ToBoolean(objDst.Tables[0].Rows[i]["blnActivo"].ToString());
                    objMdlOpcion.dtmActualiza = Convert.ToDateTime(objDst.Tables[0].Rows[i]["dtmActualiza"].ToString());
                    lstOpcion.Add(objMdlOpcion);
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
            return lstOpcion;
        }
    }
}
