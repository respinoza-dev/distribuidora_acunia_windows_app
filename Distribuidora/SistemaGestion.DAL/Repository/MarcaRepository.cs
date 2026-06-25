using Microsoft.Data.SqlClient;
using SistemaGestion.DAL.Configuration;
using SistemaGestion.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion.DAL.Repository
{
    public class MarcaRepository
    {
        public void RegistrarLista(List<Marca> lista)
        {
            try
            {
                using (SqlConnection connection = DBConnection.Connect())
                {
                    // Abrir conexión con la BD
                    connection.Open();

                    foreach (var Marca in lista)
                    {
                        //Personalizar el comando a enviar a la BD
                        string sql = "INSERT INTO Marca(Nombre_Marca,Descripcion) VALUES (@Nombre_Marca, @Descripcion )";
                        SqlCommand cmd = new SqlCommand(sql, connection);

                        //Asignacion de valores a los parametros de la consulta T-SQL
                        cmd.Parameters.AddWithValue("@Nombre_Marca", Marca.NombreMarca);
                        cmd.Parameters.AddWithValue("@Descripcion", Marca.Descripcion);
                       

                        //Ejecucion del comando
                        cmd.ExecuteNonQuery();

                    }
                    //Cierre de la conexión a  la BD
                    connection.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Marca> ObtenerLista()
        {
            // definicion de la lista
            List<Marca> ListaMarca = new List<Marca>();

            try
            {
                using (SqlConnection connection = DBConnection.Connect())
                {
                    connection.Open();

                    //Personalizar el comando
                    string sql = "SELECT * FROM Marca";
                    SqlCommand cmd = new SqlCommand(sql, connection);

                    // captura de los datos obtenidos desde la BD
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var Marca = new Marca()
                        {
                            IdMarca = (int)reader["Id_Marca"],
                            NombreMarca= reader["Nombre_Marca"].ToString(),
                            Descripcion = reader["Descripcion"].ToString(),
                            
                        };

                        ListaMarca.Add(Marca);
                    }

                    connection.Close();

                    return ListaMarca;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // editar una categoria
        public void Editar(Marca Marca)
        {
            try
            {
                using (SqlConnection connection = DBConnection.Connect())
                {
                    // aperturar a la DB
                    connection.Open();

                    // diseniar la instruccion T-SQL a enviar a la BD
                    string sql = "UPDATE Marca SET Nombre_Marca = @Nombre_Marca, Descripcion = @Descripcion  WHERE Id_Marca = @Id_Marca;";

                    // Preparamos el comando a enviar a la BD
                    SqlCommand cmd = new SqlCommand(sql, connection);

                    // asignar valores a los parametros de la consulta T-SQL
                    cmd.Parameters.AddWithValue("@Nombre_Marca", Marca.NombreMarca);
                    cmd.Parameters.AddWithValue("@Descripcion", Marca.Descripcion);
                    cmd.Parameters.AddWithValue("@Id_Marca", Marca.IdMarca);

                    // Ejecutar el comando
                    cmd.ExecuteNonQuery();

                    // cerramos la conexion
                    connection.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Eliminar(int IdMarca)
        {
            try
            {
                using (SqlConnection connection = DBConnection.Connect())
                {
                    connection.Open();

                    string sql = "DELETE FROM Marca WHERE Id_Marca= @Id_Marca";

                    SqlCommand cmd = new SqlCommand(sql, connection);

                    cmd.Parameters.AddWithValue("@Id_Marca", IdMarca);

                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
