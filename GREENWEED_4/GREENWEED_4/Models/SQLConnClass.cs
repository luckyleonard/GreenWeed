using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace GREENWEED_4.Models
{
    public class SQLConnClass //this class is providing the connections to sql database
    {
        SqlConnection SQLConn = new SqlConnection();//create new connections
        public DataTable SQLTable = new DataTable();//create new data table

        public SQLConnClass()
        {
            //make new connctions of myConnnString
            SQLConn.ConnectionString = ConfigurationManager.ConnectionStrings["myConnString"].ConnectionString;
        }

        public void retrieveData(String command) //retrieveData by sql command
        {
            try 
            {
                SQLConn.Open();
                SqlDataAdapter da = new SqlDataAdapter(command, SQLConn);
                da.Fill(SQLTable);
            }
            catch (Exception ex) //catch exception
            {
                HttpContext.Current.Response.Write("<script>alert('Something goes wrong "
                +"in connecting to DB with error:" +ex.Message+"');</script>");
            }
            finally
            {
                SQLConn.Close();//close connection each time method finished
            }
        }

        public void commandExec(String command) //methods for executing commands
        {
            try
            {
                SQLConn.Open();//open connection
                SqlCommand sqlcomm = new SqlCommand(command, SQLConn);

                int rowInfected = sqlcomm.ExecuteNonQuery();//execute the commonds and get output
                if (rowInfected > 0)//if there is nothing wrong
                {
                    HttpContext.Current.Response.Write("<script>alert('Your Command done');</script>");
                }
                else//if there is something wrong, return the error message
                {
                    HttpContext.Current.Response.Write("<script>alert('Something goes wrong in DBMS,try again');</script>");
                }
            }
            catch(Exception ex)//catch the exception with error message
            {
                HttpContext.Current.Response.Write("<script>alert('Something goes wrong "
                + "in connecting to DB with error:" + ex.Message + "');</script>");
            }
            finally
            {
                SQLConn.Close();//close connection each time method finished
            }
        }
    }
}