using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace appweb1.app
{
    public partial class Default : System.Web.UI.Page
    {

        //Crear conexiones a SQL SERVER
        //String constr = @"Server=ATKL106;Database=TIEMPOS_MUERTOS;Trusted_Connection=yes;";

        //Quitar las conecciones a Access
        //OleDbConnection con;//Representa una conexión abierta a un origen de datos
        //String stringConexion = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source =C:\\Users\\p.rguerrero\\Documents\\BaseCodigos.mdb;Persist Security Info=False;";
        
        public static List<string> items = new List<string> {"0","1","2","3","4","5","6","7","8","9","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","33","33",
                    "35","36","37","38","39","40","41","42","43","44","45","46","47","48","49","50","51","52","53","54","55","56","57","58","59","60","61","62","63","30","31","32","33","33",
                   "34",    "35",   "36",   "37",   "38",   "39",   "40",   "41",   "42",   "43",   "44",   "45",   "46",   "47",   "48",   "49",   "50",
                    "51",   "52",   "53",   "54",   "55",   "56",   "57",   "58",   "59",   "60",   "61",   "62",   "63",   "64",   "65",   "66",   "67",
                    "68",   "69",   "70",   "71",   "72",   "73",   "74",   "75",   "76",   "77",   "78",   "79",   "80",   "81",   "82",   "83",   "84",
                    "85",   "86",   "87",   "88",   "89",   "90",   "91",   "92",   "93",   "94",   "95",   "96",   "97",   "98",   "99",   "100",  "101",
                    "102",  "103",  "104",  "105",  "106",  "107",  "108",  "109",  "110",  "111",  "112",  "113",  "114",  "115",  "116",  "117",  "118",
                    "119",  "120",  "121",  "122",  "123",  "124",  "125",  "126",  "127",  "128",  "129",  "130",  "131",  "132",  "133",  "134",  "135",
                    "136",  "137",  "138",  "139",  "140",  "141",  "142",  "143",  "144",  "145",  "146",  "147",  "148",  "149",  "150",  "151",  "152",
                    "153",  "154",  "155",  "156",  "157",  "158",  "159",  "160",  "161",  "162",  "163",  "164",  "165",  "166",  "167",  "168",  "169",
                    "170",  "171",  "172",  "173",  "174",  "175",  "176",  "177",  "178",  "179",  "180",  "181",  "182",  "183",  "184",  "185",  "186",
                    "187",  "188",  "189",  "190",  "191",  "192",  "193",  "194",  "195",  "196",  "197",  "198",  "199",  "200",  "201",  "202",  "203",
                    "204",  "205",  "206",  "207",  "208",  "209",  "210",  "211",  "212",  "213",  "214",  "215",  "216",  "217",  "218",  "219",  "220",
                    "221",  "222",  "223",  "224",  "225",  "226",  "227",  "228",  "229",  "230",  "231",  "232",  "233",  "234",  "235",  "236",  "237",
                    "238",  "239",  "240",  "241",  "242",  "243",  "244",  "245",  "246",  "247",  "248",  "249",  "250",  "251",  "252",  "253",  "254",
                    "255",  "256",  "257",  "258",  "259",  "260",  "261",  "262",  "263",  "264",  "265",  "266",  "267",  "268",  "269",  "270",  "271",
                    "272",  "273",  "274",  "275",  "276",  "277",  "278",  "279",  "280",  "281",  "282",  "283",  "284",  "285",  "286",  "287",  "288",
                    "289",  "290",  "291",  "292",  "293",  "294",  "295",  "296",  "297",  "298",  "299",  "300",  "301",  "302",  "303",  "304",  "305",
                    "306",  "307",  "308",  "309",  "310",  "311",  "312",  "313",  "314",  "315",  "316",  "317",  "318",  "319",  "320",  "321",  "322",
                    "323",  "324",  "325",  "326",  "327",  "328",  "329",  "330",  "331",  "332",  "333",  "334",  "335",  "336",  "337",  "338",  "339",
                    "340",  "341",  "342",  "343",  "344",  "345",  "346",  "347",  "348",  "349",  "350",  "351",  "352",  "353",  "354",  "355",  "356",
                    "357",  "358",  "359",  "360",  "361",  "362",  "363",  "364",  "365",  "366",  "367",  "368",  "369",  "370",  "371",  "372",  "373",
                    "374",  "375",  "376",  "377",  "378",  "379",  "380",  "381",  "382",  "383",  "384",  "385",  "386",  "387",  "388",  "389",  "390",
                    "391",  "392",  "393",  "394",  "395",  "396",  "397",  "398",  "399",  "400",  "401",  "402",  "403",  "404",  "405",  "406",  "407",
                    "408",  "409",  "410",  "411",  "412",  "413",  "414",  "415",  "416",  "417",  "418",  "419",  "420",  "421",  "422",  "423",  "424",
                    "425",  "426",  "427",  "428",  "429",  "430",  "431",  "432",  "433",  "434",  "435",  "436",  "437",  "438",  "439",  "440",  "441",
                    "442",  "443",  "444",  "445",  "446",  "447",  "448",  "449",  "450",  "451",  "452",  "453",  "454",  "455",  "456",  "457",  "458",
                    "459",  "460",  "461",  "462",  "463",  "464",  "465",  "466",  "467",  "468",  "469",  "470",  "471",  "472",  "473",  "474",  "475",
                    "476",  "477",  "478",  "479",  "480",  "481",  "482",  "483",  "484",  "485",  "486",  "487",  "488",  "489",  "490",  "491",  "492"};




        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String pieza_procesar = Request.QueryString["pieza"];
                String hora_procesar = Request.QueryString["hora"];

                if (string.IsNullOrEmpty(pieza_procesar))
                {
                    Page.Response.Redirect("~/Default.aspx");
                }



                try
                {

                    //Quitar ole ya que es para Acccess
                    //con = new OleDbConnection(@stringConexion);

                    Table_mantto.Visible = false;
                    Table_calidad.Visible = false;
                    Table_logistica.Visible = false;

                    ambiente_lbl0.Visible = false;
                    ambiente_lbl1.Visible = false;
                    ambiente_lbl2.Visible = false;



                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Conection.constr;
                    //SqlConnection con = new SqlConnection(constr);

                    con.Open();//se abre una conexion

                    Button1.Visible = false;
                    Label1.Text = "";
                    // Put all data into de ComboBox
                    // Cargar las causas
                    //OleDbCommand cmd_3 = new OleDbCommand();
                    SqlCommand cmd_3 = new SqlCommand();


                    cmd_3.Connection = con;

                    cmd_3.CommandText = "Select Distinct Descripcion from Piezas where Pieza='" + pieza_procesar + "'";
                    cmd_3.ExecuteNonQuery();

                    //OleDbDataReader reader_3 = cmd_3.ExecuteReader();

                    SqlDataReader reader_3 = cmd_3.ExecuteReader();

                    //DropDownList4.Items.Clear();
                    while (reader_3.Read())
                    {
                        ListItem listItem = new ListItem();
                        item_desc.Text = reader_3["Descripcion"].ToString();
                        Item_nbr.Text = pieza_procesar;

                    }

                    reader_3.Close();

                    //Obtener las horas que aún nohan sido capturadas
                    //Si la hora ya ha sido capturada, no se mostrará...

                    //OleDbCommand cmd_12 = new OleDbCommand();
                    //SqlCommand cmd_12 = new SqlCommand();
                    SqlCommand cmd_12 = new SqlCommand();
                    
                    cmd_12.Connection = con;

                    cmd_12.CommandText = "Select HORA from PRODUCCION where PARTE=" + pieza_procesar + " and ST=''";
                    cmd_12.ExecuteNonQuery();

                    Hora_Sel_usr.Items.Add("-");

                    //OleDbDataReader reader_12 = cmd_12.ExecuteReader();
                    SqlDataReader reader_12 = cmd_12.ExecuteReader();


                    //int i = 0;
                    while (reader_12.Read())
                    {
                        ListItem listItem = new ListItem();
                        Hora_Sel_usr.Items.Add(reader_12["HORA"].ToString());
                    }
                    reader_12.Close();
                    
                    //  Cargar los tipos de falla
                    //OleDbCommand cmd_1 = new OleDbCommand();
                    SqlCommand cmd_1 = new SqlCommand();
                    cmd_1.Connection = con;


                    Dropdown_Mantto_Fallo_1.Items.Clear();
                    Dropdown_Calidad_Fallo_1.Items.Clear();
                    Dropdown_Logistica_Fallo_1.Items.Clear();

                    Dropdown_Mantto_Fallo_2.Items.Clear();
                    Dropdown_Calidad_Fallo_2.Items.Clear();
                    Dropdown_Logistica_Fallo_2.Items.Clear();

                    Dropdown_Mantto_Fallo_3.Items.Clear();
                    Dropdown_Calidad_Fallo_3.Items.Clear();
                    Dropdown_Logistica_Fallo_3.Items.Clear();


                    Dropdown_Mantto_Fallo_1.Items.Add("Opción fallo 1");
                    Dropdown_Calidad_Fallo_1.Items.Add("Opción fallo 1");
                    Dropdown_Logistica_Fallo_1.Items.Add("Opción fallo 1");

                    Dropdown_Mantto_Fallo_2.Items.Add("Opción fallo 2");
                    Dropdown_Calidad_Fallo_2.Items.Add("Opción fallo 2");
                    Dropdown_Logistica_Fallo_2.Items.Add("Opción fallo 2");

                    Dropdown_Mantto_Fallo_3.Items.Add("Opción fallo 3");
                    Dropdown_Calidad_Fallo_3.Items.Add("Opción fallo 3");
                    Dropdown_Logistica_Fallo_3.Items.Add("Opción fallo 3");


                    cmd_1.CommandText = "Select Distinct Tipo_falla from Fallos_Mantenimiento";

                    cmd_1.ExecuteNonQuery();

                    //OleDbDataReader reader_1 = cmd_1.ExecuteReader();
                    SqlDataReader reader_1 = cmd_1.ExecuteReader();


                    while (reader_1.Read())
                    {
                        ListItem listItem = new ListItem();

                        listItem.Text = reader_1["Tipo_falla"].ToString();
                        Dropdown_Mantto_Fallo_1.Items.Add(listItem);
                        Dropdown_Mantto_Fallo_2.Items.Add(listItem);
                        Dropdown_Mantto_Fallo_3.Items.Add(listItem);
                        
                    }
                    reader_1.Close();




                    //FALLOS CALIDAD
                    SqlCommand cmd_2 = new SqlCommand();
                    cmd_2.Connection = con;
                    cmd_2.CommandText = "Select Distinct Tipo_falla from Fallos_CALIDAD";
                    

                    cmd_2.ExecuteNonQuery();

                    //OleDbDataReader reader_1 = cmd_1.ExecuteReader();
                    SqlDataReader reader_2 = cmd_2.ExecuteReader();
                    while (reader_2.Read())
                    {
                        ListItem listItem = new ListItem();

                        listItem.Text = reader_2["Tipo_falla"].ToString();
                        
                        Dropdown_Calidad_Fallo_1.Items.Add(listItem);
                        Dropdown_Calidad_Fallo_2.Items.Add(listItem);
                        Dropdown_Calidad_Fallo_3.Items.Add(listItem);
                        

                    }
                    reader_2.Close();


                    // FALLOS LOGISTICA
                    SqlCommand cmd_33 = new SqlCommand();
                    cmd_33.Connection = con;
                    cmd_33.CommandText = "Select Distinct Tipo_falla from Fallos_Logistica";


                    cmd_33.ExecuteNonQuery();

                    //OleDbDataReader reader_1 = cmd_1.ExecuteReader();
                    SqlDataReader reader_33 = cmd_33.ExecuteReader();

                    while (reader_33.Read())
                    {
                        ListItem listItem = new ListItem();

                        listItem.Text = reader_33["Tipo_falla"].ToString();
                        
                        Dropdown_Logistica_Fallo_1.Items.Add(listItem);
                        Dropdown_Logistica_Fallo_2.Items.Add(listItem);
                        Dropdown_Logistica_Fallo_3.Items.Add(listItem);

                    }
                    reader_3.Close();







                    con.Close();

                }
                catch (System.Exception ex)
                {
                    Label1.Text = ex.Message;
                    ;
                }

            }
            
        }


        //Save all data into DataBase
        protected void Button1_Click(object sender, EventArgs e)
        {
            //con.Open();


            //Detectar los campos vacíos para no guardarlos en la base como espacios vacíos
            String Min_Mantto_1_var = Min_Mantto_1.Text;
            String Min_Mantto_2_var = Min_Mantto_2.Text;
            String Min_Mantto_3_var = Min_Mantto_3.Text;

            String Min_Calidad_1_var = Min_Calidad_1.Text;
            String Min_Calidad_2_var = Min_Calidad_2.Text;
            String Min_Calidad_3_var = Min_Calidad_3.Text;

            String Min_Logistica_1_var = Min_Logistica_1.Text;
            String Min_Logistica_2_var = Min_Logistica_2.Text;
            String Min_Logistica_3_var = Min_Logistica_3.Text;


            //con = new OleDbConnection(@stringConexion);
            //SqlConnection con = new SqlConnection(constr);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conection.constr;


            con.Open();//se abre una conexion

            //OleDbCommand commando = new OleDbCommand();
            SqlCommand commando = new SqlCommand();
            commando.Connection = con;

            String Ambiente;

            if (Min_Mantto_1.Text.Length > 0)
            {
                Ambiente = "Mantenimiento";
                commando.CommandText = "Insert into Fallos_reportados values('" + DateTime.Now.ToString("yyyy-MM-dd") + "'," + hora_select.Text + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "'," + Item_nbr.Text + ",'" + item_desc.Text + "','" + Ambiente.ToString() + "','" + Dropdown_Mantto_Fallo_1.Text + "','" + Dropdown_Mantto_Modo_1.SelectedValue + "','" + Dropdown_Mantto_Causa_1.SelectedValue + "'," + Min_Mantto_1.Text + "," + Minutos_prod.Text + "," + hora_select.Text + ") ";
                commando.ExecuteNonQuery();

            }

            if (Min_Mantto_2.Text.Length > 0)
            {
                Ambiente = "Mantenimiento";
                commando.CommandText = "Insert into Fallos_reportados values('" + DateTime.Now.ToString("yyyy-MM-dd") + "'," + hora_select.Text + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "'," + Item_nbr.Text + ",'" + item_desc.Text + "','" + Ambiente.ToString() + "','" + Dropdown_Mantto_Fallo_2.Text + "','" + Dropdown_Mantto_Modo_2.SelectedValue + "','" + Dropdown_Mantto_Causa_2.SelectedValue + "'," + Min_Mantto_2.Text + "," + Minutos_prod.Text + "," + hora_select.Text + ") ";
                commando.ExecuteNonQuery();
            }

            if (Min_Mantto_3.Text.Length > 0)
            {
                Ambiente = "Mantenimiento";
                commando.CommandText = "Insert into Fallos_reportados values('" + DateTime.Now.ToString("yyyy-MM-dd") + "'," + hora_select.Text + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "'," + Item_nbr.Text + ",'" + item_desc.Text + "','" + Ambiente.ToString() + "','" + Dropdown_Mantto_Fallo_3.Text + "','" + Dropdown_Mantto_Modo_3.SelectedValue + "','" + Dropdown_Mantto_Causa_3.SelectedValue + "'," + Min_Mantto_3.Text + "," + Minutos_prod.Text + "," + hora_select.Text + ") ";
                commando.ExecuteNonQuery();
            }


            if (Min_Calidad_1.Text.Length > 0)
            {
                Ambiente = "Calidad";
                commando.CommandText = "Insert into Fallos_reportados values('" + DateTime.Now.ToString("yyyy-MM-dd") + "'," + hora_select.Text + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "'," + Item_nbr.Text + ",'" + item_desc.Text + "','" + Ambiente.ToString() + "','" + Dropdown_Calidad_Fallo_1.Text + "','" + Dropdown_Calidad_Modo_1.SelectedValue + "','" + Dropdown_Calidad_Causa_1.SelectedValue + "'," + Min_Calidad_1.Text + "," + Minutos_prod.Text + "," + hora_select.Text + ") ";
                commando.ExecuteNonQuery();
            }

            if (Min_Calidad_2.Text.Length > 0)
            {
                Ambiente = "Calidad";
                commando.CommandText = "Insert into Fallos_reportados values('" + DateTime.Now.ToString("yyyy-MM-dd") + "'," + hora_select.Text + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "'," + Item_nbr.Text + ",'" + item_desc.Text + "','" + Ambiente.ToString() + "','" + Dropdown_Calidad_Fallo_2.Text + "','" + Dropdown_Calidad_Modo_2.SelectedValue + "','" + Dropdown_Calidad_Causa_2.SelectedValue + "'," + Min_Calidad_1.Text + "," + Minutos_prod.Text + "," + hora_select.Text + ") ";
                commando.ExecuteNonQuery();
            }

            if (Min_Calidad_3.Text.Length > 0)
            {
                Ambiente = "Calidad";
                commando.CommandText = "Insert into Fallos_reportados values('" + DateTime.Now.ToString("yyyy-MM-dd") + "'," + hora_select.Text + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "'," + Item_nbr.Text + ",'" + item_desc.Text + "','" + Ambiente.ToString() + "','" + Dropdown_Calidad_Fallo_3.Text + "','" + Dropdown_Calidad_Modo_3.SelectedValue + "','" + Dropdown_Calidad_Causa_3.SelectedValue + "'," + Min_Calidad_1.Text + "," + Minutos_prod.Text + "," + hora_select.Text + ") ";
                commando.ExecuteNonQuery();
            }


            if (Min_Logistica_1.Text.Length > 0)
            {
                Ambiente = "Logistica";
                commando.CommandText = "Insert into Fallos_reportados values('" + DateTime.Now.ToString("yyyy-MM-dd") + "'," + hora_select.Text + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "'," + Item_nbr.Text + ",'" + item_desc.Text + "','" + Ambiente.ToString() + "','" + Dropdown_Logistica_Fallo_1.Text + "','" + Dropdown_Logistica_Modo_1.SelectedValue + "','" + Dropdown_Logistica_Causa_1.SelectedValue + "'," + Min_Logistica_1.Text + "," + Minutos_prod.Text + "," + hora_select.Text + ") ";
                commando.ExecuteNonQuery();
            }

            if (Min_Logistica_2.Text.Length > 0)
            {
                Ambiente = "Logistica";
                commando.CommandText = "Insert into Fallos_reportados values('" + DateTime.Now.ToString("yyyy-MM-dd") + "'," + hora_select.Text + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "'," + Item_nbr.Text + ",'" + item_desc.Text + "','" + Ambiente.ToString() + "','" + Dropdown_Logistica_Fallo_2.Text + "','" + Dropdown_Logistica_Modo_2.SelectedValue + "','" + Dropdown_Logistica_Causa_2.SelectedValue + "'," + Min_Logistica_2.Text + "," + Minutos_prod.Text + "," + hora_select.Text + ") ";

                commando.ExecuteNonQuery();
            }

            if (Min_Logistica_3.Text.Length > 0)
            {
                Ambiente = "Logistica";
                commando.CommandText = "Insert into Fallos_reportados values('" + DateTime.Now.ToString("yyyy-MM-dd") + "'," + hora_select.Text + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "," + Item_nbr.Text + ",'" + item_desc.Text + "','" + Ambiente.ToString() + "','" + Dropdown_Logistica_Fallo_1.Text + "','" + Dropdown_Logistica_Modo_3.SelectedValue + "','" + Dropdown_Logistica_Causa_3.SelectedValue + "'," + Min_Logistica_3.Text + "," + Minutos_prod.Text + "," + hora_select.Text + ") ";
                commando.ExecuteNonQuery();
            }

            
            //Marcar con una Y aquellas partes que han sido justificadas por el supervisor para evitar que vuelvan a ser capturadas...
            commando.CommandText = "Update Produccion Set ST = 'Y' where PARTE = '" + Item_nbr.Text + "' and HORA =" + Hora_Sel_usr.Text + ";";
            commando.ExecuteNonQuery();
            
            con.Close();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Gracias por tu información');window.top.opener.RefreshPage();window.close()</script>");

            Page.ClientScript.RegisterStartupScript(this.GetType(), "myCloseScript", "window.top.opener.RefreshPage();window.close()", true);

            item_desc.Text = "";
            Item_nbr.Text = "";
            Button1.Visible = false;

            Page.Response.Redirect("~/Default.aspx");

        }


        // //////////////////////////////////////Fallos de Mantenimiento /////////////////////////////////////////////////////////

        //Fallas de mantenimiento
        //  Seleccionar opciones para Mantenimiento 1
        //Al seleccionar la falla mantenimiento 1, este procedimiento cargará las fallas correspondientes al dropdown Modos de mantenimiento
        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

            Button1.Visible = true;
            //con = new OleDbConnection(@stringConexion);
            //SqlConnection con = new SqlConnection(constr);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conection.constr;

            con.Open();//se abre una conexion
            
            //OleDbCommand cmd_2 = new OleDbCommand();
            SqlCommand cmd_2 = new SqlCommand();
            cmd_2.Connection = con;

            cmd_2.CommandText = "Select Distinct Modo_falla from Fallos_Mantenimiento where Tipo_falla ='" + Dropdown_Mantto_Fallo_1.Text + "';";
            cmd_2.ExecuteNonQuery();


            //OleDbDataReader reader_2 = cmd_2.ExecuteReader();
            SqlDataReader reader_2 = cmd_2.ExecuteReader();

            Dropdown_Mantto_Modo_1.Items.Clear();

            Dropdown_Mantto_Modo_1.Items.Add("Seleccione el modo");
            

            while (reader_2.Read())
            {
                ListItem listItem = new ListItem();

                listItem.Text = reader_2["Modo_falla"].ToString();
                Dropdown_Mantto_Modo_1.Items.Add(listItem);

            }
            reader_2.Close();
            con.Close();

        }




        //Al seleccionar el modo de falla de mantenimiento 1, se cargaran las causas en el dropdown Causas 1 Mantenimiento
        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {

            //con = new OleDbConnection(@stringConexion);
            //SqlConnection con = new SqlConnection(constr);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conection.constr;
            con.Open();//se abre una conexion

            Button1.Visible = true;
            // Cargar las causas
            //OleDbCommand cmd_3 = new OleDbCommand();
            SqlCommand cmd_3 = new SqlCommand();
            cmd_3.Connection = con;

            cmd_3.CommandText = "Select Distinct CAUSA_FALLA from Fallos_Mantenimiento where Modo_Falla ='" + Dropdown_Mantto_Modo_1.Text + "'";
            cmd_3.ExecuteNonQuery();

            //OleDbDataReader reader_3 = cmd_3.ExecuteReader();
            SqlDataReader reader_3 = cmd_3.ExecuteReader();
            Dropdown_Mantto_Causa_1.Items.Clear();

            Dropdown_Mantto_Causa_1.Items.Add("Seleccione una opción");
            while (reader_3.Read())
            {
                ListItem listItem = new ListItem();

                listItem.Text = reader_3["Causa_FALLA"].ToString();
                Dropdown_Mantto_Causa_1.Items.Add(listItem);

            }
            reader_3.Close();
            con.Close();

        }


        //Fallas de mantenimiento
        //  Seleccionar opciones para Mantenimiento 2
        //Al seleccionar la falla mantenimiento 2, este procedimiento cargará las fallas correspondientes al dropdown Modos de mantenimiento
        protected void Mantenimiento_2_opt_Modo(object sender, EventArgs e)
        {

            Button1.Visible = true;
            //con = new OleDbConnection(@stringConexion);
            //SqlConnection con = new SqlConnection(constr);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conection.constr;
            con.Open();//se abre una conexion

            //OleDbCommand cmd_2 = new OleDbCommand();
            SqlCommand cmd_2 = new SqlCommand();
            cmd_2.Connection = con;

            cmd_2.CommandText = "Select Distinct Modo_falla from Fallos_Mantenimiento where Tipo_falla ='" + Dropdown_Mantto_Fallo_2.Text + "';";
            cmd_2.ExecuteNonQuery();

            //OleDbDataReader reader_2 = cmd_2.ExecuteReader();
            SqlDataReader reader_2 = cmd_2.ExecuteReader();
            Dropdown_Mantto_Modo_2.Items.Clear();
            Dropdown_Mantto_Modo_2.Items.Add("Seleccione el modo");
            
            while (reader_2.Read())
            {
                ListItem listItem = new ListItem();

                listItem.Text = reader_2["Modo_falla"].ToString();
                
                Dropdown_Mantto_Modo_2.Items.Add(listItem);
                
            }
            reader_2.Close();
            con.Close();

        }

        //Al seleccionar el modo de falla de mantenimiento 1, se cargaran las causas en el dropdown Causas 1 Mantenimiento
        protected void Mantenimiento_2_opt_Causa(object sender, EventArgs e)
        {


            //SqlConnection con = new SqlConnection(constr);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conection.constr;
            con.Open();//se abre una conexion

            Button1.Visible = true;
            // Cargar las causas
            //OleDbCommand cmd_3 = new OleDbCommand();
            SqlCommand cmd_3 = new SqlCommand();
            cmd_3.Connection = con;

            cmd_3.CommandText = "Select Distinct CAUSA_FALLA from Fallos_Mantenimiento where Modo_Falla ='" + Dropdown_Mantto_Modo_2.Text + "';";
            cmd_3.ExecuteNonQuery();

            //OleDbDataReader reader_3 = cmd_3.ExecuteReader();
            SqlDataReader reader_3 = cmd_3.ExecuteReader();
            Dropdown_Mantto_Causa_2.Items.Clear();
            Dropdown_Mantto_Causa_2.Items.Add("Seleccione una opción");

            while (reader_3.Read())
            {
                ListItem listItem = new ListItem();

                listItem.Text = reader_3["Causa_FALLA"].ToString();
                Dropdown_Mantto_Causa_2.Items.Add(listItem);
                
            }
            reader_3.Close();
            con.Close();

        }


        //Fallas de mantenimiento
        //Seleccionar opciones para Mantenimiento 3
        //Al seleccionar la falla mantenimiento 3, este procedimiento cargará las fallas correspondientes al dropdown Modos de mantenimiento
        protected void Mantenimiento_3_opt_Modo(object sender, EventArgs e)
        {

            Button1.Visible = true;
            //con = new OleDbConnection(@stringConexion);
            //SqlConnection con = new SqlConnection(constr);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conection.constr;
            con.Open();//se abre una conexion

            //OleDbCommand cmd_2 = new OleDbCommand();
            SqlCommand cmd_2 = new SqlCommand();
            cmd_2.Connection = con;

            cmd_2.CommandText = "Select Distinct Modo_falla from Fallos_Mantenimiento where Tipo_falla ='" + Dropdown_Mantto_Fallo_3.Text + "';";
            cmd_2.ExecuteNonQuery();

            //OleDbDataReader reader_2 = cmd_2.ExecuteReader();
            SqlDataReader reader_2 = cmd_2.ExecuteReader();
            Dropdown_Mantto_Modo_3.Items.Clear();
            
            Dropdown_Mantto_Modo_3.Items.Add("Seleccione el modo");
            while (reader_2.Read())
            {
                ListItem listItem = new ListItem();

                listItem.Text = reader_2["Modo_falla"].ToString();
                
                Dropdown_Mantto_Modo_3.Items.Add(listItem);
                
            }
            reader_2.Close();
            con.Close();

        }

        //Al seleccionar el modo de falla de mantenimiento 1, se cargaran las causas en el dropdown Causas 1 Mantenimiento
        protected void Mantenimiento_3_opt_Causa(object sender, EventArgs e)
        {

            //con = new OleDbConnection(@stringConexion);
            //SqlConnection con = new SqlConnection(constr);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conection.constr;
            con.Open();//se abre una conexion

            Button1.Visible = true;
            // Cargar las causas
            //OleDbCommand cmd_3 = new OleDbCommand();
            SqlCommand cmd_3 = new SqlCommand();
            cmd_3.Connection = con;

            cmd_3.CommandText = "Select Distinct CAUSA_FALLA from Fallos_Mantenimiento where Modo_Falla ='" + Dropdown_Mantto_Modo_3.Text + "';";
            cmd_3.ExecuteNonQuery();

            //OleDbDataReader reader_3 = cmd_3.ExecuteReader();
            SqlDataReader reader_3 = cmd_3.ExecuteReader();
            Dropdown_Mantto_Causa_3.Items.Clear();
            Dropdown_Mantto_Causa_3.Items.Add("Seleccione una opción");

            while (reader_3.Read())
            {
                ListItem listItem = new ListItem();

                listItem.Text = reader_3["Causa_FALLA"].ToString();
                Dropdown_Mantto_Causa_3.Items.Add(listItem);
                
            }
            reader_3.Close();
            con.Close();

        }
        
        // ////////////////////////////////////////////////////////Fallos de Calidad ////////////////////////////////////////////////////////////////
        //Fallas de mantenimiento
        //  Seleccionar opciones para Calidad 1
        //Al seleccionar la falla mantenimiento 1, este procedimiento cargará las fallas correspondientes al dropdown Modos de mantenimiento
        protected void Calidad_1_opt_Modo(object sender, EventArgs e)
        {

            Button1.Visible = true;
            //con = new OleDbConnection(@stringConexion);
            //SqlConnection con = new SqlConnection(constr);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conection.constr;
            con.Open();//se abre una conexion

            //OleDbCommand cmd_2 = new OleDbCommand();
            SqlCommand cmd_2 = new SqlCommand();
            cmd_2.Connection = con;

            cmd_2.CommandText = "Select Distinct Modo_falla from Fallos_CALIDAD where Tipo_falla ='" + Dropdown_Calidad_Fallo_1.Text + "';";
            cmd_2.ExecuteNonQuery();

            //OleDbDataReader reader_2 = cmd_2.ExecuteReader();
            SqlDataReader reader_2 = cmd_2.ExecuteReader();
            Dropdown_Calidad_Modo_1.Items.Clear();

            //Dropdown_Calidad_Modo_1.Items.Add("Seleccione una opción");
            Dropdown_Calidad_Modo_1.Items.Add("Seleccione el modo");


            while (reader_2.Read())
            {
                ListItem listItem = new ListItem();

                listItem.Text = reader_2["Modo_falla"].ToString();
                Dropdown_Calidad_Modo_1.Items.Add(listItem);

            }
            reader_2.Close();
            con.Close();

        }




        //Al seleccionar el modo de falla de Modo 1, se cargaran las causas en el dropdown Causas 1 Mantenimiento
        protected void Calidad_1_opt_Causa(object sender, EventArgs e)
        {

            //con = new OleDbConnection(@stringConexion);
            //SqlConnection con = new SqlConnection(constr);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conection.constr;
            con.Open();//se abre una conexion

            Button1.Visible = true;
            // Cargar las causas
            //OleDbCommand cmd_3 = new OleDbCommand();
            SqlCommand cmd_3 = new SqlCommand();
            cmd_3.Connection = con;

            cmd_3.CommandText = "Select Distinct CAUSA_FALLA from Fallos_CALIDAD where Modo_Falla ='" + Dropdown_Calidad_Modo_1.Text + "';";
            cmd_3.ExecuteNonQuery();

            //OleDbDataReader reader_3 = cmd_3.ExecuteReader();
            SqlDataReader reader_3 = cmd_3.ExecuteReader();
            Dropdown_Calidad_Causa_1.Items.Clear();

            Dropdown_Calidad_Causa_1.Items.Add("Seleccione una opción");

            while (reader_3.Read())
            {
                ListItem listItem = new ListItem();

                listItem.Text = reader_3["Causa_FALLA"].ToString();
                Dropdown_Calidad_Causa_1.Items.Add(listItem);

            }
            reader_3.Close();
            con.Close();

        }



        //Fallas de mantenimiento
        //  Seleccionar opciones para Mantenimiento 2
        //Al seleccionar la falla mantenimiento 2, este procedimiento cargará las fallas correspondientes al dropdown Modos de mantenimiento
        protected void Calidad_2_opt_Modo(object sender, EventArgs e)
        {

            Button1.Visible = true;
            //con = new OleDbConnection(@stringConexion);
            //SqlConnection con = new SqlConnection(constr);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conection.constr;
            con.Open();//se abre una conexion

            //OleDbCommand cmd_2 = new OleDbCommand();
            SqlCommand cmd_2 = new SqlCommand();
            cmd_2.Connection = con;

            cmd_2.CommandText = "Select Distinct Modo_falla from Fallos_CALIDAD where Tipo_falla ='" + Dropdown_Calidad_Fallo_2.Text + "';";
            cmd_2.ExecuteNonQuery();

            //OleDbDataReader reader_2 = cmd_2.ExecuteReader();
            SqlDataReader reader_2 = cmd_2.ExecuteReader();
            Dropdown_Calidad_Modo_2.Items.Clear();
            Dropdown_Calidad_Modo_2.Items.Add("Seleccione el modo");

            while (reader_2.Read())
            {
                ListItem listItem = new ListItem();

                listItem.Text = reader_2["Modo_falla"].ToString();

                Dropdown_Calidad_Modo_2.Items.Add(listItem);

            }

            reader_2.Close();
            con.Close();


        }

        //Al seleccionar el modo de falla de mantenimiento 1, se cargaran las causas en el dropdown Causas 1 Mantenimiento
        protected void Calidad_2_opt_Causa(object sender, EventArgs e)
        {

            //con = new OleDbConnection(@stringConexion);
            //SqlConnection con = new SqlConnection(constr);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conection.constr;
            con.Open();//se abre una conexion

            Button1.Visible = true;
            // Cargar las causas
            //OleDbCommand cmd_3 = new OleDbCommand();
            SqlCommand cmd_3 = new SqlCommand();
            cmd_3.Connection = con;

            cmd_3.CommandText = "Select Distinct CAUSA_FALLA from Fallos_CALIDAD where Modo_Falla ='" + Dropdown_Calidad_Modo_2.Text + "';";
            cmd_3.ExecuteNonQuery();

            //OleDbDataReader reader_3 = cmd_3.ExecuteReader();
            SqlDataReader reader_3 = cmd_3.ExecuteReader();
            Dropdown_Calidad_Causa_2.Items.Clear();
            Dropdown_Calidad_Causa_2.Items.Add("Seleccione una opción");

            while (reader_3.Read())
            {
                ListItem listItem = new ListItem();
                listItem.Text = reader_3["Causa_FALLA"].ToString();
                Dropdown_Calidad_Causa_2.Items.Add(listItem);
            }
            reader_3.Close();
            con.Close();

        }

        //Fallas de mantenimiento
        //Seleccionar opciones para Calidad 3
        //Al seleccionar la falla mantenimiento 3, este procedimiento cargará las fallas correspondientes al dropdown Modos de mantenimiento
        protected void Calidad_3_opt_Modo(object sender, EventArgs e)
        {

            Button1.Visible = true;
            //con = new OleDbConnection(@stringConexion);
            //SqlConnection con = new SqlConnection(constr);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conection.constr;
            con.Open();//se abre una conexion

            //OleDbCommand cmd_2 = new OleDbCommand();
            SqlCommand cmd_2 = new SqlCommand();
            cmd_2.Connection = con;

            cmd_2.CommandText = "Select Distinct Modo_falla from Fallos_CALIDAD where Tipo_falla ='" + Dropdown_Calidad_Fallo_3.Text + "';";
            cmd_2.ExecuteNonQuery();

            //OleDbDataReader reader_2 = cmd_2.ExecuteReader();
            SqlDataReader reader_2 = cmd_2.ExecuteReader();
            Dropdown_Calidad_Modo_3.Items.Clear();

            Dropdown_Calidad_Modo_3.Items.Add("Seleccione el modo");

            while (reader_2.Read())
            {
                ListItem listItem = new ListItem();
                listItem.Text = reader_2["Modo_falla"].ToString();
                Dropdown_Calidad_Modo_3.Items.Add(listItem);
            }
            reader_2.Close();
            con.Close();

        }

        //Al seleccionar el modo de falla de mantenimiento 1, se cargaran las causas en el dropdown Causas 1 Mantenimiento
        protected void Calidad_3_opt_Causa(object sender, EventArgs e)
        {

            //con = new OleDbConnection(@stringConexion);
            //SqlConnection con = new SqlConnection(constr);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conection.constr;
            con.Open();//se abre una conexion

            Button1.Visible = true;
            // Cargar las causas
            //OleDbCommand cmd_3 = new OleDbCommand();
            SqlCommand cmd_3 = new SqlCommand();
            cmd_3.Connection = con;

            cmd_3.CommandText = "Select Distinct CAUSA_FALLA from Fallos_CALIDAD where Modo_Falla ='" + Dropdown_Calidad_Modo_3.Text + "';";
            cmd_3.ExecuteNonQuery();

            //OleDbDataReader reader_3 = cmd_3.ExecuteReader();
            SqlDataReader reader_3 = cmd_3.ExecuteReader();
            Dropdown_Calidad_Causa_3.Items.Clear();
            Dropdown_Calidad_Causa_3.Items.Add("Seleccione una opción");

            while (reader_3.Read())
            {
                ListItem listItem = new ListItem();

                listItem.Text = reader_3["Causa_FALLA"].ToString();
                Dropdown_Calidad_Causa_3.Items.Add(listItem);

            }
            reader_3.Close();
            con.Close();


        }






        // //////////////////////////////////////Fallos de Logística /////////////////////////////////////////////////////////


        //Fallas de Loagistica
        //  Seleccionar opciones para Logistica 1
        //Al seleccionar la falla mantenimiento 1, este procedimiento cargará las fallas correspondientes al dropdown Modos de mantenimiento
        protected void Logistica_1_opt_Modo(object sender, EventArgs e)
        {

            Button1.Visible = true;
            //con = new OleDbConnection(@stringConexion);
            //SqlConnection con = new SqlConnection(constr);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conection.constr;
            con.Open();//se abre una conexion

            //OleDbCommand cmd_2 = new OleDbCommand();
            SqlCommand cmd_2 = new SqlCommand();
            cmd_2.Connection = con;

            cmd_2.CommandText = "Select Distinct Modo_falla from Fallos_LOGISTICA where Tipo_falla ='" + Dropdown_Logistica_Fallo_1.Text + "';";
            cmd_2.ExecuteNonQuery();

            //OleDbDataReader reader_2 = cmd_2.ExecuteReader();
            SqlDataReader reader_2 = cmd_2.ExecuteReader();
            Dropdown_Logistica_Modo_1.Items.Clear();
            Dropdown_Logistica_Modo_1.Items.Add("Seleccione el modo");
            
            while (reader_2.Read())
            {
                ListItem listItem = new ListItem();

                listItem.Text = reader_2["Modo_falla"].ToString();
                Dropdown_Logistica_Modo_1.Items.Add(listItem);

            }
            reader_2.Close();
            con.Close();


        }




        //Al seleccionar el modo de falla de Modo 1, se cargaran las causas en el dropdown Causas 1 Mantenimiento
        protected void Logistica_1_opt_Causa(object sender, EventArgs e)
        {

            //con = new OleDbConnection(@stringConexion);
            //SqlConnection con = new SqlConnection(constr);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conection.constr;
            con.Open();//se abre una conexion

            Button1.Visible = true;
            // Cargar las causas
            //OleDbCommand cmd_3 = new OleDbCommand();
            SqlCommand cmd_3 = new SqlCommand();
            cmd_3.Connection = con;

            cmd_3.CommandText = "Select Distinct CAUSA_FALLA from Fallos_LOGISTICA where Modo_Falla ='" + Dropdown_Logistica_Modo_1.Text + "';";
            cmd_3.ExecuteNonQuery();

            //OleDbDataReader reader_3 = cmd_3.ExecuteReader();
            SqlDataReader reader_3 = cmd_3.ExecuteReader();
            Dropdown_Logistica_Causa_1.Items.Clear();
            Dropdown_Logistica_Causa_1.Items.Add("Seleccione una opción");

            while (reader_3.Read())
            {
                ListItem listItem = new ListItem();

                listItem.Text = reader_3["Causa_FALLA"].ToString();
                Dropdown_Logistica_Causa_1.Items.Add(listItem);

            }
            reader_3.Close();
            con.Close();


        }



        //Fallas de mantenimiento
        //  Seleccionar opciones para Mantenimiento 2
        //Al seleccionar la falla mantenimiento 2, este procedimiento cargará las fallas correspondientes al dropdown Modos de mantenimiento
        protected void Logistica_2_opt_Modo(object sender, EventArgs e)
        {

            Button1.Visible = true;
            //con = new OleDbConnection(@stringConexion);
            //SqlConnection con = new SqlConnection(constr);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conection.constr;
            con.Open();//se abre una conexion

            //OleDbCommand cmd_2 = new OleDbCommand();
            SqlCommand cmd_2 = new SqlCommand();
            cmd_2.Connection = con;

            cmd_2.CommandText = "Select Distinct Modo_falla from Fallos_LOGISTICA where Tipo_falla ='" + Dropdown_Logistica_Fallo_2.Text + "';";
            cmd_2.ExecuteNonQuery();

            //OleDbDataReader reader_2 = cmd_2.ExecuteReader();
            SqlDataReader reader_2 = cmd_2.ExecuteReader();
            Dropdown_Logistica_Modo_2.Items.Clear();
            Dropdown_Logistica_Modo_2.Items.Add("Seleccione el modo");

            while (reader_2.Read())
            {
                ListItem listItem = new ListItem();

                listItem.Text = reader_2["Modo_falla"].ToString();

                Dropdown_Logistica_Modo_2.Items.Add(listItem);

            }
            reader_2.Close();
            con.Close();

        }

        //Al seleccionar el modo de falla de mantenimiento 1, se cargaran las causas en el dropdown Causas 1 Mantenimiento
        protected void Logistica_2_opt_Causa(object sender, EventArgs e)
        {

            //con = new OleDbConnection(@stringConexion);
            //SqlConnection con = new SqlConnection(constr);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conection.constr;
            con.Open();//se abre una conexion

            Button1.Visible = true;
            // Cargar las causas
            //OleDbCommand cmd_3 = new OleDbCommand();
            SqlCommand cmd_3 = new SqlCommand();
            cmd_3.Connection = con;

            cmd_3.CommandText = "Select Distinct CAUSA_FALLA from Fallos_LOGISTICA where Modo_Falla ='" + Dropdown_Logistica_Modo_2.Text + "';";
            cmd_3.ExecuteNonQuery();

            //OleDbDataReader reader_3 = cmd_3.ExecuteReader();
            SqlDataReader reader_3 = cmd_3.ExecuteReader();
            Dropdown_Logistica_Causa_2.Items.Clear();

            Dropdown_Logistica_Causa_2.Items.Add("Seleccione una opción");

            while (reader_3.Read())
            {
                ListItem listItem = new ListItem();

                listItem.Text = reader_3["Causa_FALLA"].ToString();
                Dropdown_Logistica_Causa_2.Items.Add(listItem);

            }
            reader_3.Close();
            con.Close();

        }


        //Fallas de mantenimiento
        //Seleccionar opciones para Calidad 3
        //Al seleccionar la falla mantenimiento 3, este procedimiento cargará las fallas correspondientes al dropdown Modos de mantenimiento
        protected void Logistica_3_opt_Modo(object sender, EventArgs e)
        {

            Button1.Visible = true;
            //con = new OleDbConnection(@stringConexion);
            //SqlConnection con = new SqlConnection(constr);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conection.constr;
            con.Open();//se abre una conexion

            //OleDbCommand cmd_2 = new OleDbCommand();
            SqlCommand cmd_2 = new SqlCommand();
            cmd_2.Connection = con;

            cmd_2.CommandText = "Select Distinct Modo_falla from Fallos_LOGISTICA where Tipo_falla ='" + Dropdown_Logistica_Fallo_3.Text + "';";
            cmd_2.ExecuteNonQuery();

            //OleDbDataReader reader_2 = cmd_2.ExecuteReader();
            SqlDataReader reader_2 = cmd_2.ExecuteReader();
            Dropdown_Logistica_Modo_3.Items.Clear();

            Dropdown_Logistica_Modo_3.Items.Add("Seleccione el modo");


            while (reader_2.Read())
            {
                ListItem listItem = new ListItem();

                listItem.Text = reader_2["Modo_falla"].ToString();

                Dropdown_Logistica_Modo_3.Items.Add(listItem);

            }
            reader_2.Close();
            con.Close();


        }

        //Al seleccionar el modo de falla de mantenimiento 1, se cargaran las causas en el dropdown Causas 1 Mantenimiento
        protected void Logistica_3_opt_Causa(object sender, EventArgs e)
        {

            //con = new OleDbConnection(@stringConexion);
            //SqlConnection con = new SqlConnection(constr);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conection.constr;
            con.Open();//se abre una conexion

            Button1.Visible = true;
            // Cargar las causas
            //OleDbCommand cmd_3 = new OleDbCommand();
            SqlCommand cmd_3 = new SqlCommand();
            cmd_3.Connection = con;

            cmd_3.CommandText = "Select Distinct CAUSA_FALLA from Fallos_LOGISTICA where Modo_Falla ='" + Dropdown_Logistica_Modo_3.Text + "';";
            cmd_3.ExecuteNonQuery();

            //OleDbDataReader reader_3 = cmd_3.ExecuteReader();
            SqlDataReader reader_3 = cmd_3.ExecuteReader();
            Dropdown_Logistica_Causa_3.Items.Clear();
            Dropdown_Logistica_Causa_3.Items.Add("Seleccione una opción");

            while (reader_3.Read())
            {
                ListItem listItem = new ListItem();

                listItem.Text = reader_3["Causa_FALLA"].ToString();
                Dropdown_Logistica_Causa_3.Items.Add(listItem);

            }
            reader_3.Close();
            con.Close();


        }



        protected void Button2_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Default.aspx");
        }


        // ////////////////////////////////////////////////////////Validar los minutos ingresados para cada falla justificada //////////////////////////////////////////////

        protected void min_1(Object sender, EventArgs e)
        {
            int intParsed;
            if (int.TryParse(Min_Mantto_1.Text.Trim(), out intParsed))
            {
                // Do nothing
            }
        }


        protected void Min_Mantto_1_TextChanged(object sender, EventArgs e)
        {

            //Ver el valor de Hora_Select que son los minutos a justificar de esa falla
            int valor1;
            //int valor2;
            int valor3;

            // Valor de los minutos a justificar
            valor1 =  Convert.ToInt32(hora_select.Text);

            //Valor de la captura 1
            //valor2 = Convert.ToInt32(Min_Mantto_1.Text);

            String Min_Mantto_1_var = Min_Mantto_1.Text;
            String Min_Mantto_2_var = Min_Mantto_2.Text;
            String Min_Mantto_3_var = Min_Mantto_3.Text;

            String Min_Calidad_1_var = Min_Calidad_1.Text;
            String Min_Calidad_2_var = Min_Calidad_2.Text;
            String Min_Calidad_3_var = Min_Calidad_3.Text;

            String Min_Logistica_1_var = Min_Logistica_1.Text;
            String Min_Logistica_2_var = Min_Logistica_2.Text;
            String Min_Logistica_3_var = Min_Logistica_3.Text;

            if (Min_Mantto_1_var.Equals("")) { Min_Mantto_1_var = "0"; };
            if (Min_Mantto_2_var.Equals("")) { Min_Mantto_2_var = "0"; };
            if (Min_Mantto_3_var.Equals("")) { Min_Mantto_3_var = "0"; };

            if (Min_Calidad_1_var.Equals("")) { Min_Calidad_1_var = "0"; };
            if (Min_Calidad_2_var.Equals("")) { Min_Calidad_2_var = "0"; };
            if (Min_Calidad_3_var.Equals("")) { Min_Calidad_3_var = "0"; };

            if (Min_Logistica_1_var.Equals("")) { Min_Logistica_1_var = "0"; };
            if (Min_Logistica_2_var.Equals("")) { Min_Logistica_2_var = "0"; };
            if (Min_Logistica_3_var.Equals("")) { Min_Logistica_3_var = "0"; };


            //Valor de todos los Minutos que puede capturar el supervisor
            valor3 = Convert.ToInt32(Min_Mantto_1_var) + Convert.ToInt32(Min_Mantto_2_var) + Convert.ToInt32(Min_Mantto_3_var) + 
                Convert.ToInt32(Min_Calidad_1_var) + Convert.ToInt32(Min_Calidad_2_var) + Convert.ToInt32(Min_Calidad_3_var)+
                Convert.ToInt32(Min_Logistica_1_var) + Convert.ToInt32(Min_Logistica_2_var) + Convert.ToInt32(Min_Logistica_3_var);

            //valor3 = valor3 + Convert.ToInt32(Min_Mantto_2.Text);
            
            if (valor3 <= valor1)
            {   
                var result = (valor1- valor3);
                Minutos_prod.Text = result.ToString();
                Button1.Visible = true;
                error_id.Text = "";
            }
            else
            {
                //En caso de que las sumas de losa minutos supere los minutos a justificar,
                // el programa no dejará continuar hasta que se revisen los minutos seleccionados

                error_id.Text= "Favor de revisar la captura de los minutos!";

                Button1.Visible = false;
            }

        }

        protected void Dropdown_Mantto_Causa_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Min_Mantto_1.Visible = true;
            Min_Mantto_1.DataSource = items;
            Min_Mantto_1.DataBind();
        }

        protected void Dropdown_Mantto_Causa_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Min_Mantto_2.Visible = true;
            Min_Mantto_2.DataSource = items;
            Min_Mantto_2.DataBind();

            
        }

        protected void Dropdown_Mantto_Causa_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Min_Mantto_3.Visible = true;
            Min_Mantto_3.DataSource = items;
            Min_Mantto_3.DataBind();

            
        }

        protected void Dropdown_Calidad_Causa_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Min_Calidad_1.Visible = true;
            Min_Calidad_1.DataSource = items;
            Min_Calidad_1.DataBind();

            
        }

        protected void Dropdown_Calidad_Causa_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Min_Calidad_2.Visible = true;
            Min_Calidad_2.DataSource = items;
            Min_Calidad_2.DataBind();

            
        }

        protected void Dropdown_Calidad_Causa_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Min_Calidad_3.Visible = true;
            Min_Calidad_3.DataSource = items;
            Min_Calidad_3.DataBind();


            
        }

        protected void Dropdown_Logistica_Causa_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Min_Logistica_1.Visible = true;
            Min_Logistica_1.DataSource = items;
            Min_Logistica_1.DataBind();

           
        }

        protected void Dropdown_Logistica_Causa_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Min_Logistica_2.Visible = true;
            Min_Logistica_2.DataSource = items;
            Min_Logistica_2.DataBind();

            
        }

        protected void Dropdown_Logistica_Causa_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Min_Logistica_3.Visible = true;
            Min_Logistica_3.DataSource = items;
            Min_Logistica_3.DataBind();
        }

        protected void Hora_Sel_usr_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                //Este procedimiento hará que el supervisor pueda seleccionar la hora de paro que tenga disponible el número de parte seleccionado
                //con = new OleDbConnection(@stringConexion);
                //SqlConnection con = new SqlConnection(constr);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conection.constr;
                con.Open();//se abre una conexion

                //OleDbCommand cmd_13 = new OleDbCommand();
                SqlCommand cmd_13 = new SqlCommand();
                cmd_13.Connection = con;

                cmd_13.CommandText = "Select Minutos from Produccion where Parte='" + Item_nbr.Text + "' and HORA =" + Hora_Sel_usr.Text + ";";
                cmd_13.ExecuteNonQuery();

                //OleDbDataReader reader_13 = cmd_13.ExecuteReader();
                SqlDataReader reader_13 = cmd_13.ExecuteReader();

                //DropDownList4.Items.Clear();
                while (reader_13.Read())
                {
                    ListItem listItem = new ListItem();

                    hora_select.Text = (reader_13["Minutos"].ToString());
                    Minutos_prod.Text = (reader_13["Minutos"].ToString());

                }
                reader_13.Close();

                Table_mantto.Visible = true;
                Table_calidad.Visible = true;
                Table_logistica.Visible = true;

                ambiente_lbl0.Visible = true;
                ambiente_lbl1.Visible = true;
                ambiente_lbl2.Visible = true;

                con.Close();



            }
            catch (System.Exception ex)
            {
                Label1.Text = ex.Message; ;
            }

        }
    }
}