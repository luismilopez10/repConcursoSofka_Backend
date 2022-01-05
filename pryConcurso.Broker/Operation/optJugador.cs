using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using pryConcurso.Model.Jugador;
using pryConcurso.Broker.Procedure;
using pryConcurso.Broker.Interface;

namespace pryConcurso.Broker.Operation
{
    public class optJugador : itfJugador
    {
        string strConnectionString = DBConnection.strConnectionString;

        SqlConnection objCon = null;
        SqlCommand objCom = null;
        spaJugador objSpaJugador = null;
        SqlDataAdapter objDap = null;
        DataSet objDst = null;
        List<mdlJugador> lstJugador = null;

        public optJugador()
        {
        }



        public string fncIngresarJugador(mdlJugador objMdlJugador)
        {
            int intResultado;
            string strResultado = "";
            objCon = new SqlConnection(strConnectionString);
            objSpaJugador = new spaJugador();

            try
            {
                objCon.Open();
                objCom = new SqlCommand(objSpaJugador.spaIngresarJugador, objCon);
                objCom.CommandType = CommandType.StoredProcedure;
                objCom.Parameters.AddWithValue("@intPuntaje", objMdlJugador.intPuntaje);
                objCom.Parameters.AddWithValue("@strNombre", objMdlJugador.strNombre);
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


        public List<mdlJugador> fncConsultarJugador(mdlJugador objMdlJugador)
        {
            string strResultado;

            objCon = new SqlConnection(strConnectionString);
            objSpaJugador = new spaJugador();

            try
            {
                objCon.Open();
                objCom = new SqlCommand(objSpaJugador.spaConsultarJugador, objCon);
                objCom.CommandType = CommandType.StoredProcedure;

                objDap = new SqlDataAdapter();
                objDap.SelectCommand = objCom;

                objDst = new DataSet();
                objDap.Fill(objDst);

                lstJugador = new List<mdlJugador>();

                for (int i = 0; i < objDst.Tables[0].Rows.Count; i++)
                {
                    objMdlJugador = new mdlJugador();
                    objMdlJugador.intIdJugador = Convert.ToInt32(objDst.Tables[0].Rows[i]["intIdJugador"].ToString());
                    objMdlJugador.intPuntaje = Convert.ToInt32(objDst.Tables[0].Rows[i]["intPuntaje"].ToString());
                    objMdlJugador.strNombre = Convert.ToString(objDst.Tables[0].Rows[i]["strNombre"].ToString());
                    objMdlJugador.blnActivo = Convert.ToBoolean(objDst.Tables[0].Rows[i]["blnActivo"].ToString());
                    objMdlJugador.dtmActualiza = Convert.ToDateTime(objDst.Tables[0].Rows[i]["dtmActualiza"].ToString());
                    lstJugador.Add(objMdlJugador);
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
            return lstJugador;
        }
    }
}
