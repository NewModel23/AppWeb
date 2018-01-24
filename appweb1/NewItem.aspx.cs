using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace appweb1
{
    public partial class Contact : Page
    {
        //OleDbConnection con;//Representa una conexión abierta a un origen de datos
                            //String stringConexion = @"Provider=SQLNCLI11;Server=ATKL106;Database=master;Trusted_Connection=yes;";
        //SqlConnection con;
        //String constr = @"Server=ATKL106;Database=TIEMPOS_MUERTOS;Trusted_Connection=yes;";
        protected void Page_Load(object sender, EventArgs e)
        {

            //Populating a DataTable from database.

            //String constr = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source =C:\\Users\\p.rguerrero\\Documents\\BaseCodigos.mdb;Persist Security Info=False;";


            //con = new OleDbConnection(constr);
            //SqlConnection con = new SqlConnection(constr);
            SqlConnection con = new SqlConnection();

            con.ConnectionString = Conection.constr;


            con.Open();//se abre una conexion
            Ambiente.Items.Add("Mantenimiento");
            Ambiente.Items.Add("Calidad");
            Ambiente.Items.Add("Logistica");
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Save the Data into the table
            
            //SqlConnection con = new SqlConnection(constr);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conection.constr;

            SqlCommand commando = new SqlCommand();

            con.Open();

            commando.Connection = con;

            //SqlCommand commando = new SqlCommand(commando.CommandText,con);

            //Determine based on the Ambient value wich ID correspond

            if (Ambiente.Text.Equals("Mantenimiento")){
                commando.CommandText = "Insert into FALLOS_MANTENIMIENTO values(1,'" + Falla.Text + "','" + Modo.Text +"','" + Causa.Text + "');";
            }

            if (Ambiente.Text.Equals("Calidad"))
            {
                commando.CommandText = "Insert into FALLOS_CALIDAD values(2,'" + Falla.Text + "','" + Modo.Text + "','" + Causa.Text + "');";
            }

            if (Ambiente.Text.Equals("Logistica"))
            {
                commando.CommandText = "Insert into FALLOS_LOGISTICA values(3,'" + Falla.Text + "','" + Modo.Text + "','" + Causa.Text + "');";
            }


            commando.ExecuteNonQuery();
            
            con.Close();

            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Se ha guardado la nueva falla, ya puedes capturar los minutos de paro con esta falla!');window.top.opener.RefreshPage();window.close()</script>");
            Page.ClientScript.RegisterStartupScript(this.GetType(), "myCloseScript", "window.top.opener.RefreshPage();window.close()", true);
            
            Page.Response.Redirect("~/Default.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Back to the principal Page jeje
            Page.Response.Redirect("~/Default.aspx");
        }
    }
}