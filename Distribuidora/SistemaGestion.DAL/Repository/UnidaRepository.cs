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
    public class UnidaRepository
    {
        public void RegistrarLista(List<UnidaDeMedida> lista)
        {
            try
            {
                using (SqlConnection connection = DBConnection.Connect())
                {
                    // Abrir conexión con la BD
                    connection.Open();

                    foreach (var UnidaDeMedida in lista)
                    {
                        //Personalizar el comando a enviar a la BD
                        string sql = "INSERT INTO Unidad_Medida(Nombre_Unidad,Abreviatura) VALUES (@Nombre_Unidad, @Abreviatura )";
                        SqlCommand cmd = new SqlCommand(sql, connection);

                        //Asignacion de valores a los parametros de la consulta T-SQL
                        cmd.Parameters.AddWithValue("@Nombre_Unidad", UnidaDeMedida.NombreUnidad);
                        cmd.Parameters.AddWithValue("@Abreviatura", UnidaDeMedida.Abreviatura);


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
        public List<UnidaDeMedida> ObtenerLista()
        {
            // definicion de la lista
            List<UnidaDeMedida> ListaUnidadMedida = new List<UnidaDeMedida>();

            try
            {
                using (SqlConnection connection = DBConnection.Connect())
                {
                    connection.Open();

                    //Personalizar el comando
                    string sql = "SELECT * FROM Unidad_Medida";
                    SqlCommand cmd = new SqlCommand(sql, connection);

                    // captura de los datos obtenidos desde la BD
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var UnidadMedida = new UnidaDeMedida()
                        {
                            IdUnidad = (int)reader["Id_Unidad"],
                            NombreUnidad = reader["Nombre_Unidad"].ToString(),
                            Abreviatura = reader["Abreviatura"].ToString(),

                        };

                        ListaUnidadMedida.Add(UnidadMedida);
                    }

                    connection.Close();

                    return ListaUnidadMedida;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // editar una categoria
        public void Editar(UnidaDeMedida UnidaDeMedida)
        {
            try
            {
                using (SqlConnection connection = DBConnection.Connect())
                {
                    // aperturar a la DB
                    connection.Open();

                    // diseniar la instruccion T-SQL a enviar a la BD
                    string sql = "UPDATE Unidad_Medida SET Nombre_Unidad = @Nombre_Unidad, Abreviatura = @Abreviatura  WHERE Id_Unidad = @Id_Unidad;";

                    // Preparamos el comando a enviar a la BD
                    SqlCommand cmd = new SqlCommand(sql, connection);

                    // asignar valores a los parametros de la consulta T-SQL
                    cmd.Parameters.AddWithValue("@Nombre_Unidad", UnidaDeMedida.NombreUnidad);
                    cmd.Parameters.AddWithValue("@Descripcion", UnidaDeMedida.Abreviatura);
                    cmd.Parameters.AddWithValue("@Id_Marca", UnidaDeMedida.IdUnidad);

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
        public void Eliminar(int IdUnidad)
        {
            try
            {
                using (SqlConnection connection = DBConnection.Connect())
                {
                    connection.Open();

                    string sql = "DELETE FROM Unidad_Medida WHERE Id_Unidad= @Id_Unidad";

                    SqlCommand cmd = new SqlCommand(sql, connection);

                    cmd.Parameters.AddWithValue("@Id_Unidad", IdUnidad);

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
