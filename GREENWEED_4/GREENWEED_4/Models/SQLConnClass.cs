using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace GREENWEED_4.Models
{
    public class SQLConnClass
    {
        SqlConnection SQLConn = new SqlConnection();
        public DataTable SQLTable = new DataTable();

        public SQLConnClass()
        {
            SQLConn.ConnectionString = ConfigurationManager.ConnectionStrings["myConnString"].ConnectionString;
        }

        public void retrieveData(String command)
        {
            try 
            {
                SQLConn.Open();
                SqlDataAdapter da = new SqlDataAdapter(command, SQLConn);
                da.Fill(SQLTable);
            }
            catch (Exception ex)
            {
                HttpContext.Current.Response.Write("<script>alert('Something goes wrong "
                +"in connecting to DB with error:" +ex.Message+"');</script>");
            }
            finally
            {
                SQLConn.Close();
            }
        }

        public void commandExec(String command)
        {
            try
            {
                SQLConn.Open();
                SqlCommand sqlcomm = new SqlCommand(command, SQLConn);

                int rowInfected = sqlcomm.ExecuteNonQuery();
                if (rowInfected > 0)
                {
                    HttpContext.Current.Response.Write("<script>alert('Your Command done');</script>");
                }
                else
                {
                    HttpContext.Current.Response.Write("<script>alert('Something goes wrong in DBMS,try again');</script>");
                }
            }
            catch(Exception ex)
            {
                HttpContext.Current.Response.Write("<script>alert('Something goes wrong "
                + "in connecting to DB with error:" + ex.Message + "');</script>");
            }
            finally
            {
                SQLConn.Close();
            }
        }
    }
}