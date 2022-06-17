using Floristeria.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Floristeria.Controladores
{
    public static class ControladorPedidos
    {
        public static string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBbdd"].ConnectionString;
        /// <summary>
        /// RECUPERA LOS PEDIDOS
        /// </summary>
        /// <returns></returns>
        public static DataSet recuperarPedidosDataSet()
        {

            DataSet dataSet = new DataSet();

            try
            {

                MySqlConnection cnn = new MySqlConnection(cadenaConexion);
                cnn.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("select * from pedidos", cnn);
                dataAdapter.Fill(dataSet);
                cnn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo base de datos" + e.Message);
            }

            return dataSet;

        }

        /// <summary>
        /// GUARDAR LOS CAMBIOS EN EL DATASET
        /// </summary>
        /// <param name="dataSet"></param>
        /// <returns></returns>
        public static bool guardarPedidosDeDataSet(DataSet dataSet)
        {
            bool respuesta = true;

            try
            {

                MySqlConnection cnn = new MySqlConnection(cadenaConexion);
                cnn.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("select * from pedidos", cnn);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(dataAdapter);
                builder.GetUpdateCommand();
                dataAdapter.Update(dataSet);
                dataAdapter.Dispose();
                cnn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error guardando  dataset " + e.Message);
                respuesta = false;
            }

            return respuesta;

        }
        /// <summary>
        /// GUARDAR LOS PEDIDOS
        /// </summary>
        /// <param name="dataSet"></param>
        /// <param name="ruta"></param>
        /// <returns></returns>

        public static bool guardarPedidosEnXml(List<Pedido> listaP, string ruta)
        {
            try
            {
                using (var writer = new StreamWriter(ruta) )
                {
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    var serializer = new XmlSerializer(listaP.GetType());
                    serializer.Serialize(writer, listaP, namespaces);
                }
            }catch(Exception e)
            { }
                
           return true;
        }

        public static bool guardarPedidos(int codigo_flor, int codigo_cliente, DateTime fecha, int cantidad)
        {

            bool respuesta = true;

            try
            {

                MySqlConnection cnn = new MySqlConnection(cadenaConexion);
                cnn.Open();
                MySqlCommand comando = cnn.CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO `pedidos`(`codigo_flor`, `codigo_cliente`, `fecha`, `cantidad`) VALUES (@codigo_flor,@codigo_cliente,@fecha,@cantidad)";


                comando.Parameters.AddWithValue("@codigo_flor", codigo_flor);
                comando.Parameters.AddWithValue("@codigo_cliente", codigo_cliente);
                comando.Parameters.AddWithValue("@fecha", fecha);
                comando.Parameters.AddWithValue("@cantidad", cantidad);

                comando.Prepare();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.InsertCommand = comando;
                if (adapter.InsertCommand.ExecuteNonQuery() == 0)
                {
                    respuesta = false;

                }
                adapter.Dispose();
                comando.Dispose();


                cnn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error guardando  pedidos " + e.Message);
                respuesta = false;
            }

            return respuesta;


        }


        public static List<Pedido> recuperarPedidosEnLista()
        {
            List<Pedido> listaPed = new List<Pedido>();

            try
            {
                MySqlConnection cnn = new MySqlConnection(cadenaConexion);
                cnn.Open();

                MySqlCommand comando = cnn.CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "select * from pedidos";
                MySqlDataReader dataReader = comando.ExecuteReader();
                while (dataReader.Read())
                {

                    int codigoPed = dataReader.GetInt32("codigo_pedido");
                    int codFlor = dataReader.GetInt32("codigo_flor");
                    int codClient = dataReader.GetInt32("codigo_cliente");
                    DateTime fecha = dataReader.GetDateTime("fecha");
                    int cant = dataReader.GetInt32("cantidad");                   

                    listaPed.Add(new Pedido(codigoPed,codFlor,codClient,fecha,cant));
                }
                dataReader.Close();
                comando.Dispose();
                cnn.Close();




            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo base de datos" + e.Message);
            }

            return listaPed;

        }



        //ejemplo para prueba unitaria
       







    }
}