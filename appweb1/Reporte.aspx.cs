using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Text;


namespace appweb1
{
    public partial class Reporte : Page
    {
        int[] barras = new int[2];
        string[] nombs = new string[2];
        DateTime dt;

        protected void Page_Load(object sender, EventArgs e)
        {

            //Cartgar las fechass a los Dropdown list FECHA_REPORTE_1 Y FECHA_REPORTE_2
            //FECHA_REPORTE_1.DataSource = items;
            //DateTime Fecha = DateTime.Today;
            //obtener_datos(Fecha.ToString,Fecha.ToString);
            

            if (!IsPostBack)
            {


                Conection con = new Conection();

                SqlConnection conn = new SqlConnection();

                conn.ConnectionString = Conection.constr;

                SqlCommand cmd = new SqlCommand("Select MIN(FECHA_MAGNA) FROM FALLOS_REPORTADOS", conn);

                conn.Open();
                
                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    dt = reader.GetDateTime(0);
                }
               
                for (DateTime d = dt; d < DateTime.Now; d = d.AddDays(1))
                {
                    Fecha_1.Items.Add(d.ToShortDateString());
                    Fecha_2.Items.Add(d.ToShortDateString());
                }


                reader.Close();
                conn.Close();


            }
        }

        protected void obtener_datos(string fecha, string fecha2)
        {


            int contador = 0;
            Conection con = new Conection();

            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = Conection.constr;

            SqlCommand cmd = new SqlCommand("Select Ambiente, count(TIPO_FALLA) AS Fallas_capturadas FROM FALLOS_REPORTADOS WHERE FECHA_MAGNA BETWEEN '" + Fecha_1.SelectedValue + "' and '" + Fecha_2.SelectedValue + "' Group by Ambiente", conn);

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                nombs[contador] = reader.GetString(0);
                barras[contador] = reader.GetInt32(1);
                contador++;
            };

            reader.Close();
            

            //Grafica.Series["Serie"].Points.DataBindXY();
            Grafica.Series["Serie"].Points.DataBindXY(nombs,barras);

            SqlDataAdapter DBAdapter = new SqlDataAdapter();

            //Agregar la tabla con los estadísticos
            DBAdapter.SelectCommand = new SqlCommand("Select Distinct AMBIENTE, SUM(DISTINCT MIN_FALLA) AS Minutos_paro, SUM(MINUTOS) as Minutos_capturados, sum(DISTINCT MIN_PRODUCCION) AS Minutos_produccion FROM FALLOS_REPORTADOS WHERE FECHA_MAGNA BETWEEN '" + Fecha_1.SelectedValue + "' and '" + Fecha_2.SelectedValue + "' GROUP BY AMBIENTE", conn);
           
            DataSet ds = new DataSet();
            DBAdapter.Fill(ds, "FALLOS_REPORTADOS");

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
                    html.Append("<td style='padding-left: 5px; padding-bottom:3px; font-size:15px;' width='30%'>" + row[column.ColumnName] + "</td>");         
                }
                html.Append("</tr>");
            }

            html.Append("</table>");
            
            //Append the HTML string to Placeholder # 2.
            PlaceHolder2.Controls.Add(new Literal { Text = html.ToString() });



            conn.Close();

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }


        //Al hacer la seleccion cambiar los parámetros de fecha

        protected void Fecha_2_SelectedIndexChanged(object sender, EventArgs e)
        {

            string fecha1 = Convert.ToString(Fecha_1.SelectedValue);
            string fecha2 = Convert.ToString(Fecha_2.SelectedValue);

            obtener_datos(fecha1, fecha2);



        }

        protected void Fecha_1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string fecha1 = Convert.ToString(Fecha_1.SelectedValue);
            string fecha2 = Convert.ToString(Fecha_2.SelectedValue);

            obtener_datos(fecha1, fecha2);


        }
    }
}