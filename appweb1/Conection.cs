using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace appweb1
{
    public class Conection
    {
        //public static String constr = @"Server=ATKL106;Database=TIEMPOS_MUERTOS;Trusted_Connection=yes;";
        //DESKTOP-KRKQVBR
        public static String constr = @"Server=DESKTOP-KRKQVBR;Database=TIEMPOS_MUERTOS;Trusted_Connection=yes;";
        SqlConnection con = new SqlConnection(constr);   
    }
}