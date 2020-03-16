using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Configuration;


namespace estate
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            SqlCommand inscommand;
            SqlConnection conn;

            SqlCommand inscommandtop;
            SqlConnection conntop;
            int myid;

            try
            {

                //NonSerializedAttribute datasource required

                string cs = ConfigurationManager.ConnectionStrings["gitpropertyConnectionString"].ConnectionString;
                conn = new System.Data.SqlClient.SqlConnection();
                conn.ConnectionString = cs;

                string cmdtext = "SELECT * FROM [estate];";
                //inscommand = new System.Data.SqlClient.SqlCommand(cmdtext, conn);
                inscommand = new SqlCommand(cmdtext, conn);


                conn.Open();

                SqlDataReader reader = inscommand.ExecuteReader();
                while (reader.Read())
                {
                    myid = (int)reader["estateid"];
                }
                inscommand.Dispose();
                conn.Close();
                conn.Dispose();

                conntop = new System.Data.SqlClient.SqlConnection(cs);
                //conntop.ConnectionString = cs;


                string cmdtexttop = "SELECT estateid FROM [estate];";
                //inscommandtop = new System.Data.SqlClient.SqlCommand(cmdtexttop, conntop);
                inscommandtop = new SqlCommand(cmdtexttop, conntop);

                conntop.Open();

                GridView2.DataSource = inscommandtop.ExecuteReader();
                GridView2.DataBind();

                // inscommandtop.Dispose();
                // conntop.Close();
                //  conntop.Dispose();
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Response.Write("<br/><br/><br/>Cannot connect to server. " +
                                        "<br/>Sql Error Message = " + ex.Message +
                                        "<br/>Sql Error Number = " + ex.Number + "<br/><br/>");
                        break;
                    case 1045:
                        Response.Write("Invalid username/password, please try again" +
                                       "<br/>Sql Error Message = " + ex.Message +
                                       "<br/>Sql Error Number = " + ex.Number + "<br/><br/>");
                        break;
                    default:
                        Response.Write("<br/>Unknown Error = " + ex.Number +
                                        " Error Message = " + ex.Message);
                        break;
                }
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlCommand inscommand;
            SqlConnection conn;

            SqlCommand inscommandtop;
            SqlConnection conntop;
            string lastname;

            try
            {

                string cs = ConfigurationManager.ConnectionStrings["gitpropertyConnectionString"].ConnectionString;
                //conn = new System.Data.SqlClient.SqlConnection();
                conn = new SqlConnection();

                conn.ConnectionString = cs;

            string cmdtext = "SELECT * FROM [vendors];";
            //inscommand = new System.Data.SqlClient.SqlCommand(cmdtext, conn);
            inscommand = new SqlCommand(cmdtext, conn);


                conn.Open();

            SqlDataReader reader = inscommand.ExecuteReader();
            while (reader.Read())
            {
                    lastname = (string)reader["vendorlastname"];
            }
            inscommand.Dispose();
            conn.Close();
            conn.Dispose();

            conntop = new System.Data.SqlClient.SqlConnection(cs);
            //conntop.ConnectionString = cs;


            string cmdtexttop = "SELECT vendorlastname FROM [vendors];";
//            inscommandtop = new System.Data.SqlClient.SqlCommand(cmdtexttop, conntop);
            inscommandtop = new SqlCommand(cmdtexttop, conntop);

                conntop.Open();

            GridView3.DataSource = inscommandtop.ExecuteReader();
            GridView3.DataBind();

            // inscommandtop.Dispose();
            // conntop.Close();
            //  conntop.Dispose();
        }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Response.Write("<br/><br/><br/>Cannot connect to server. " +
                                        "<br/>Sql Error Message = " + ex.Message +
                                        "<br/>Sql Error Number = " + ex.Number + "<br/><br/>");
                        break;
                    case 1045:
                        Response.Write("Invalid username/password, please try again" +
                                       "<br/>Sql Error Message = " + ex.Message +
                                       "<br/>Sql Error Number = " + ex.Number + "<br/><br/>");
                        break;
                    default:
                        Response.Write("<br/>Unknown Error = " + ex.Number +
                                        " Error Message = " + ex.Message);
                        break;
                }
}

        }

    }
}