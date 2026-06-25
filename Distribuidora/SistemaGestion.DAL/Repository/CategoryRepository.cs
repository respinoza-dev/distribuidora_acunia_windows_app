using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SistemaGestion.DAL.Configuration;
using SistemaGestion.DAL.Entities;

namespace SistemaGestion.DAL.Repository
{
    public class CategoryRepository
    {
        // Registro de una lista de categorias en la BD
        public void RegistrarLista(List<Categoria> lista)
        {
            try
            {
                using (SqlConnection connection = DBConnection.Connect())
                {
                    // Abrir conexión con la BD
                    connection.Open();

                    foreach (var categoria in lista)
                    {
                        //Personalizar el comando a enviar a la BD
                        string sql = "INSERT INTO Categoria (Nombre_Categoria, Descripcion, Estado) VALUES (@Nombre_Categoria, @Descripcion, @Estado)";
                        SqlCommand cmd = new SqlCommand(sql, connection);

                        //Asignacion de valores a los parametros de la consulta T-SQL
                        cmd.Parameters.AddWithValue("@Nombre_Categoria", categoria.NombreCategoria);
                        cmd.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
                        cmd.Parameters.AddWithValue("@Estado", categoria.Estado);

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
        
        // Obtener los registros desde la BD
        public List<Categoria> ObtenerLista()
        {
            // definicion de la lista
            List<Categoria> ListaCategorias = new List<Categoria>();

            try
            {
                using (SqlConnection connection = DBConnection.Connect())
                {
                    connection.Open();

                    //Personalizar el comando
                    string sql = "SELECT * FROM Categoria";
                    SqlCommand cmd = new SqlCommand(sql, connection);

                    // captura de los datos obtenidos desde la BD
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var categoria = new Categoria()
                        {
                            IdCategoria = (int)reader["Id_Categoria"],
                            NombreCategoria = reader["Nombre_Categoria"].ToString(),
                            Descripcion = reader["Descripcion"].ToString(),
                            Estado = (bool)reader["Estado"]
                        };

                        ListaCategorias.Add(categoria);
                    }

                    connection.Close();

                    return ListaCategorias;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Categoria> ObtenerCategoriasActivas()
        {
            // definicion de la lista
            List<Categoria> ListaCategorias = new List<Categoria>();

            try
            {
                using (SqlConnection connection = DBConnection.Connect())
                {
                    connection.Open();

                    //Personalizar el comando
                    string sql = "SELECT * FROM Categoria WHERE Estado=1";
                    SqlCommand cmd = new SqlCommand(sql, connection);

                    // captura de los datos obtenidos desde la BD
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var categoria = new Categoria()
                        {
                            IdCategoria = (int)reader["Id_Categoria"],
                            NombreCategoria = reader["Nombre_Categoria"].ToString(),
                            Descripcion = reader["Descripcion"].ToString(),
                            Estado = (bool)reader["Estado"]
                        };

                        ListaCategorias.Add(categoria);
                    }

                    connection.Close();

                    return ListaCategorias;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        // editar una categoria
        public void Editar(Categoria categoria)
        {
            try
            {
                using (SqlConnection connection = DBConnection.Connect())
                {
                    // aperturar a la DB
                    connection.Open();

                    // diseniar la instruccion T-SQL a enviar a la BD
                    string sql = "UPDATE Categoria SET Nombre_Categoria = @Nombre_Categoria, Descripcion = @Descripcion, Estado = @Estado WHERE Id_Categoria = @Id_Categoria;";

                    // Preparamos el comando a enviar a la BD
                    SqlCommand cmd = new SqlCommand(sql, connection);

                    // asignar valores a los parametros de la consulta T-SQL
                    cmd.Parameters.AddWithValue("@Nombre_Categoria", categoria.NombreCategoria);
                    cmd.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
                    cmd.Parameters.AddWithValue("@Estado", categoria.Estado);
                    cmd.Parameters.AddWithValue("@Id_Categoria", categoria.IdCategoria);

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
        public void Eliminar(int IdCategoria)
        {
            try
            {
                using (SqlConnection connection = DBConnection.Connect())
                {
                    connection.Open();

                    string sql = "DELETE FROM Categoria WHERE Id_Categoria= @Id_Categoria";

                    SqlCommand cmd = new SqlCommand(sql, connection);

                    cmd.Parameters.AddWithValue("@Id_Categoria",IdCategoria);

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
