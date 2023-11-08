using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajador
{
    public static class CrudDAO
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;
        const string NOMBRE_COLUMNA = "NOMBRE";
        const string APELLIDO_COLUMNA = "APELLIDO";
        const string ID_COLUMNA = "ID";


        static CrudDAO()
        {
            connectionString = @"Data Source=.;Initial Catalog=MIFABRICA;Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public static void Guardar(string nombre, string apellido,string trabajo)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO {trabajo} (NOMBRE,APELLIDO) VALUES (@NOMBRE,@APELLIDO)";
                command.Parameters.AddWithValue("@NOMBRE", nombre);
                command.Parameters.AddWithValue("@APELLIDO", apellido);
                int rows = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally { connection.Close(); }
        }

        public static void Actualizar(string nombre,string apellido, int id,string trabajo)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE {trabajo} SET NOMBRE = @NOMBRE, APELLIDO = @APELLIDO WHERE ID = @ID";
                command.Parameters.AddWithValue("@NOMBRE", nombre);
                command.Parameters.AddWithValue("@APELLIDO", apellido);
                command.Parameters.AddWithValue("@ID", id);
                int rows = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<Operario> LeerOperarios()
        {
            List<Operario> operarios = new List<Operario>();
            try
            {
                connection.Open();
                command.CommandText = $"SELECT * FROM OPERADOR";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        operarios.Add(new Operario(reader[NOMBRE_COLUMNA].ToString(), reader[APELLIDO_COLUMNA].ToString(), Convert.ToInt32(reader[ID_COLUMNA])));
                    }
                }

                return operarios;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        public static List<Supervisor> LeerSupervisor()
        {
            List<Supervisor> supervisores = new List<Supervisor>();
            try
            {
                connection.Open();
                command.CommandText = $"SELECT * FROM SUPERVISOR";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        supervisores.Add(new Supervisor(reader[NOMBRE_COLUMNA].ToString(), reader[APELLIDO_COLUMNA].ToString(), Convert.ToInt32(reader[ID_COLUMNA])));
                    }
                }

                return supervisores;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Eliminar(int id , string trabajo)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"DELETE FROM {trabajo} WHERE ID = {id}";
                command.Parameters.AddWithValue("@ID", id);
                int rows = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }



    }


}
