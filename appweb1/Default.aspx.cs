using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace appweb1
{
    public partial class _Default : Page
    {
        //OleDbConnection con;//Representa una conexión abierta a un origen de datos
        //String stringConexion = @"Provider=SQLNCLI11;Server=ATKL106;Database=master;Trusted_Connection=yes;";
        //String stringConexion = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source =C:\\Users\\p.rguerrero\\Documents\\BaseCodigos.mdb;Persist Security Info=False;";
        //String constr = @"Server=ATKL106;Database=TIEMPOS_MUERTOS;Trusted_Connection=yes;";


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {

                //String constr = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source =C:\\Users\\p.rguerrero\\Documents\\BaseCodigos.mdb;Persist Security Info=False;";
                //con = new OleDbConnection(constr);
                //Usar los parámetros de consulta para SQL SERVER
                //Conection con = new Conection();

                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conection.constr;
                //SqlConnection con = new SqlConnection(constr);
                con.Open();//se abre una conexion
                //OleDbDataAdapter DBAdapter = new OleDbDataAdapter();
                SqlDataAdapter DBAdapter = new SqlDataAdapter();

                //DBAdapter.SelectCommand = new OleDbCommand("Select PARTE,ITEM_DESC,FECHA, TURNO, SUM(MINUTOS) AS MINUTOS from Produccion WHERE ST IS NULL GROUP BY PARTE,ITEM_DESC,FECHA, TURNO  ORDER BY SUM(MINUTOS) DESC;", con);

                DBAdapter.SelectCommand = new SqlCommand("Select PARTE,DESCRIPCION, SUM(MINUTOS) AS MINUTOS from Produccion WHERE ST='' GROUP BY PARTE,DESCRIPCION,FECHA  ORDER BY SUM(MINUTOS) DESC", con);


                //DBAdapter.SelectCommand = new SqlCommand("Select * from Produccion", con);
                DataSet ds = new DataSet();
                DBAdapter.Fill(ds, "PRODUCCION");

                DataTable dt = ds.Tables[0];                
                StringBuilder html = new StringBuilder();

                //Table format je je
                html.Append("<style>");
                html.Append("table {");
                html.Append("border-spacing: 0;");
                html.Append("width: 100 %;");
                html.Append("border: 1px solid #ddd;}");

                html.Append("th {");
                html.Append("cursor:pointer;}");

                html.Append("th, td {");
                html.Append("text-align: left;");
                html.Append("padding: 16px;}");

                html.Append("tr: nth - child(even) {");
                html.Append("background-color: #f2f2f2}</style>");



                //Table start.
                html.Append("<table id='tareas' class='tablesorter' border='1' style='padding-left:5px; padding-bottom:3px;cursor: pointer'><col width='240'>");

                //Building the Header row.
                int j = 0;
                html.Append("<tr>");
                foreach (DataColumn column in dt.Columns)
                {

                    html.Append("<th font-size:25px; onclick='sortTable(" + j + ")'>");
                    html.Append(column.ColumnName);
                    html.Append("</th>");
                    
                    j++;
                }
                html.Append("</tr>");


                //Building the Data rows.
                foreach (DataRow row in dt.Rows)
                {
                    html.Append("<tr>");
                    foreach (DataColumn column in dt.Columns)
                    {
                        //html.Append("<td><a href=/app/Default.aspx?pieza=" + row["Parte"] + ">" + row[column.ColumnName] + "</a></td>");
                        //if (row["ST"].Equals("Y")){
                        //    html.Append("<td style='padding-left: 5px; padding-bottom:3px; font-size:15px;' width='30%'>" + row[column.ColumnName] + "</td>");
                        //}
                        //else
                        //{
                            html.Append("<td style='padding-left: 5px; padding-bottom:3px; font-size:22px;' width='50%'><a href='App/Default.aspx?pieza=" + row["Parte"] + "', target='_self' ,onclick='window.open('/app/Default.aspx?pieza=" + row["Parte"] + "';window.close(),height=750, width=1024,status= no,resizable= no, scrollbars=yes,toolbar=no,location=no,menubar=no'); return false;>" + row[column.ColumnName] + "</a></td>");
                        //}                        
                    }
                    html.Append("</tr>");
                }
                //Table end.
                html.Append("</table>");
                con.Close();
                //Append the HTML string to Placeholder.
                PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
            }

        }

        // Cargar la página para la captura de nuevos fallos...
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/NewItem.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Reporte.aspx");
        }
    }
    }
