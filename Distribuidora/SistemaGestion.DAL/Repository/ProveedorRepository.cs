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
    public class ProveedorRepository
    {
        public void RegistrarLista(List<proveedores> lista)
        {
            try
            {
                using (SqlConnection connection = DBConnection.Connect())
                {
                    // Abrir conexión con la BD
                    connection.Open();

                    foreach (var proveedores in lista)
                    {
                        //Personalizar el comando a enviar a la BD
                        string sql = "INSERT INTO Proveedor(Nombre_Empresa,Nombre_Contacto,Telefono,Email,Direccion,Activo) VALUES (@Nombre_Empresa, @Nombre_Contacto, @Telefono,@Email,@Direccion,@Activo)";
                        SqlCommand cmd = new SqlCommand(sql, connection);

                        //Asignacion de valores a los parametros de la consulta T-SQL
                        cmd.Parameters.AddWithValue("@Nombre_Empresa", proveedores.NombreEmpresa);
                        cmd.Parameters.AddWithValue("@Nombre_Contacto", proveedores.NombreContacto);
                        cmd.Parameters.AddWithValue("@Telefono", proveedores.Telefono);
                        cmd.Parameters.AddWithValue("@Email", proveedores.Gmail);
                        cmd.Parameters.AddWithValue("@Direccion", proveedores.Direccion);
                        cmd.Parameters.AddWithValue("@Activo", proveedores.Estado);

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
        public List<proveedores> ObtenerLista()
        {
            // definicion de la lista
            List<proveedores> ListaProveedores = new List<proveedores>();

            try
            {
                using (SqlConnection connection = DBConnection.Connect())
                {
                    connection.Open();

                    //Personalizar el comando
                    string sql = "SELECT * FROM Proveedor";
                    SqlCommand cmd = new SqlCommand(sql, connection);

                    // captura de los datos obtenidos desde la BD
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var proveedores = new proveedores()
                        {
                            IdProveedores = (int)reader["Id_Proveedor"],
                            NombreEmpresa = reader["Nombre_Empresa"].ToString(),
                            NombreContacto = reader["Nombre_Contacto"].ToString(),
                            Telefono = reader["Telefono"].ToString(),                                    
                            Gmail = reader["Email"].ToString(),
                            Direccion = reader["Direccion"].ToString(),
                            Estado = (bool)reader["Activo"]
                        };

                        ListaProveedores.Add(proveedores);
                    }

                    connection.Close();

                    return ListaProveedores;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<proveedores> ObtenerProveedoresActivos()
        {
            // definicion de la lista
            List<proveedores> ListaProveedores = new List<proveedores>();

            try
            {
                using (SqlConnection connection = DBConnection.Connect())
                {
                    connection.Open();

                    //Personalizar el comando
                    string sql = "SELECT * FROM Proveedor WHERE Activo=1";
                    SqlCommand cmd = new SqlCommand(sql, connection);

                    // captura de los datos obtenidos desde la BD
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var proveedores = new proveedores()
                        {
                            IdProveedores = (int)reader["Id_Proveedor"],
                            NombreEmpresa = reader["Nombre_Empresa"].ToString(),
                            NombreContacto = reader["Nombre_Contacto"].ToString(),
                            Telefono = reader["Telefono"].ToString(),
                            Gmail = reader["Email"].ToString(),
                            Direccion = reader["Direccion"].ToString(),
                            Estado = (bool)reader["Activo"]
                        };

                        ListaProveedores.Add(proveedores);
                    }

                    connection.Close();

                    return ListaProveedores;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // editar una categoria
        public void Editar(proveedores proveedores)
        {
            try
            {
                using (SqlConnection connection = DBConnection.Connect())
                {
                    // aperturar a la DB
                    connection.Open();

                    // diseniar la instruccion T-SQL a enviar a la BD
                    string sql = "UPDATE Proveedor SET Nombre_Empresa = @Nombre_Empresa, Nombre_Contacto = @Nombre_Contacto,Telefono=@Telefono,Email=@Email, Activo = @Activo WHERE Id_Proveedor = @Id_Proveedor;";

                    // Preparamos el comando a enviar a la BD
                    SqlCommand cmd = new SqlCommand(sql, connection);

                    // asignar valores a los parametros de la consulta T-SQL
                    cmd.Parameters.AddWithValue("@Nombre_Empresa", proveedores.NombreEmpresa);
                    cmd.Parameters.AddWithValue("@Nombre_Contacto", proveedores.NombreContacto);
                    cmd.Parameters.AddWithValue("@Telefono", proveedores.Telefono);
                    cmd.Parameters.AddWithValue("@Email", proveedores.Gmail);
                    cmd.Parameters.AddWithValue("@Direccion", proveedores.Direccion);
                    cmd.Parameters.AddWithValue("@Activo", proveedores.Estado);
                    cmd.Parameters.AddWithValue("@Id_Proveedor", proveedores.IdProveedores);
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
        public void Eliminar(int Idproveedor)
        {
            try
            {
                using (SqlConnection connection = DBConnection.Connect())
                {
                    connection.Open();

                    string sql = "DELETE FROM Proveedor WHERE Id_Proveedor = @Id_Proveedor";

                    SqlCommand cmd = new SqlCommand(sql, connection);

                    cmd.Parameters.AddWithValue("@Id_Proveedor", Idproveedor);

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
