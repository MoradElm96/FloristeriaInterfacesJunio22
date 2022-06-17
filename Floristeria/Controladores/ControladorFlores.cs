using Floristeria.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floristeria.Controladores
{
   public static class ControladorFlores
    {

        public static string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBbdd"].ConnectionString;

        public static DataSet recuperarFloresDataSet()
        {

            DataSet dataSet = new DataSet();

            try
            {

                MySqlConnection cnn = new MySqlConnection(cadenaConexion);
                cnn.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("select * from flores", cnn);
                dataAdapter.Fill(dataSet);
                cnn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo base de datos" + e.Message);
            }

            return dataSet;

        }


        public static List<Flor> recuperarFloresEnLista()
        {
            List<Flor> listaFlores = new List<Flor>();

            try
            {
                MySqlConnection cnn = new MySqlConnection(cadenaConexion);
                cnn.Open();

                MySqlCommand comando = cnn.CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "select * from flores";
                MySqlDataReader dataReader = comando.ExecuteReader();
                while (dataReader.Read())
                {

                    int codigo = dataReader.GetInt32("codigo");
                    string nombre = dataReader.GetString("nombre");
                    string foto = dataReader.GetString("foto");
                    double precio = dataReader.GetDouble("precio");
                    int codigo_color = dataReader.GetInt32("codigo_color");
                    string estacion = dataReader.GetString("estacion");

                    listaFlores.Add(new Flor(codigo, nombre, foto, precio, codigo_color, estacion));
                }
                dataReader.Close();
                comando.Dispose();
                cnn.Close();
                



            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo base de datos" + e.Message);
            }

            return listaFlores;

        }

        
    }
}
