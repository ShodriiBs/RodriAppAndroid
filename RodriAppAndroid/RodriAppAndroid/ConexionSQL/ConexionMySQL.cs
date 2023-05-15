using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace RodriAppAndroid.ConexionSQL
{
    class ConexionMySQL
    {
        MySqlConnection conex = new MySqlConnection();
        static string servidor = "https://mstest01.aureofy.net:2083/";
        static string db = "mstest01_hearty";
        static string port = "2083";
        static string user = "mstest01";
        static string pass = "B9Whjm1N^CZv";

        string CadenaConexion = "server=" + servidor + ";" + "port=" + port + ";" + "user id=" + user + ";" + "password=" + pass + ";" + "db=" + db + ";";

        public MySqlConnection Conectar()
        {
            try
            {
                conex.ConnectionString = CadenaConexion;
                conex.Open();

            }
            catch (Exception ex)
            {
            }
            return conex;


        }


    }
}
