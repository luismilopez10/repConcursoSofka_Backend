using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using pryConcurso.Model.Categoria;
using pryConcurso.Broker.Procedure;
using pryConcurso.Broker.Interface;

namespace pryConcurso.Broker.Operation
{
    public class optCategoria : itfCategoria
    {
        string strConnectionString = DBConnection.strConnectionString;

        SqlConnection objCon = null;
        SqlCommand objCom = null;
        spaCategoria objSpaCategoria = null;
        SqlDataAdapter objDap = null;
        DataSet objDst = null;
        List<mdlCategoria> lstCategoria = null;

        public optCategoria()
        {
        }



        public string fncIngresarCategoria(mdlCategoria objMdlCategoria)
        {
            int intResultado;
            string strResultado = "";
            objCon = new SqlConnection(strConnectionString);
            objSpaCategoria = new spaCategoria();

            try
            {
                objCon.Open();
                objCom = new SqlCommand(objSpaCategoria.spaIngresarCategoria, objCon);
                objCom.CommandType = CommandType.StoredProcedure;
                objCom.Parameters.AddWithValue("@intNivel", objMdlCategoria.intNivel);
                objCom.Parameters.AddWithValue("@intPremio", objMdlCategoria.intPremio);
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


        public List<mdlCategoria> fncConsultarCategoria(mdlCategoria objMdlCategoria)
        {
            string strResultado;

            objCon = new SqlConnection(strConnectionString);
            objSpaCategoria = new spaCategoria();

            try
            {
                objCon.Open();
                objCom = new SqlCommand(objSpaCategoria.spaConsultarCategoria, objCon);
                objCom.CommandType = CommandType.StoredProcedure;

                objDap = new SqlDataAdapter();
                objDap.SelectCommand = objCom;

                objDst = new DataSet();
                objDap.Fill(objDst);

                lstCategoria = new List<mdlCategoria>();

                for (int i = 0; i < objDst.Tables[0].Rows.Count; i++)
                {
                    objMdlCategoria = new mdlCategoria();
                    objMdlCategoria.intIdCategoria = Convert.ToInt32(objDst.Tables[0].Rows[i]["intIdCategoria"].ToString());
                    objMdlCategoria.intNivel = Convert.ToInt32(objDst.Tables[0].Rows[i]["intNivel"].ToString());
                    objMdlCategoria.intPremio = Convert.ToInt32(objDst.Tables[0].Rows[i]["intPremio"].ToString());
                    objMdlCategoria.blnActivo = Convert.ToBoolean(objDst.Tables[0].Rows[i]["blnActivo"].ToString());
                    objMdlCategoria.dtmActualiza = Convert.ToDateTime(objDst.Tables[0].Rows[i]["dtmActualiza"].ToString());
                    lstCategoria.Add(objMdlCategoria);
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
            return lstCategoria;
        }
    }
}
