using Microsoft.Data.SqlClient;
using SistemaGestion.DAL.Configuration;
using SistemaGestion.DAL.Entities;

namespace SistemaGestion.DAL.Repository
{
    public class VentaRepository
    {
        // ── Guardar nueva venta (transaccional) ───────────────────────────────────

        public int GuardarVenta(Venta venta, List<DetalleVenta> detalles)
        {
            int idVenta = 0;
            using (SqlConnection conn = DBConnection.Connect())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    // 1. Insertar cabecera de venta
                    const string sqlVenta = @"
                        INSERT INTO [dbo].[Venta]
                            (Id_Cliente, Id_Usuario, Id_Metodo_Pago, Tipo_Venta,
                             Estado_Venta, Fecha_Venta, Observaciones)
                        VALUES
                            (@IdCliente, @IdUsuario, @IdMetodoPago, @TipoVenta,
                             @EstadoVenta, @FechaVenta, @Observaciones);
                        SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdV = new SqlCommand(sqlVenta, conn, trans);
                    cmdV.Parameters.AddWithValue("@IdCliente",     venta.IdCliente);
                    cmdV.Parameters.AddWithValue("@IdUsuario",     venta.IdUsuario);
                    cmdV.Parameters.AddWithValue("@IdMetodoPago",  venta.IdMetodoPago);
                    cmdV.Parameters.AddWithValue("@TipoVenta",     venta.TipoVenta);
                    cmdV.Parameters.AddWithValue("@EstadoVenta",   venta.EstadoVenta);
                    cmdV.Parameters.AddWithValue("@FechaVenta",    venta.FechaVenta);
                    cmdV.Parameters.AddWithValue("@Observaciones",
                        string.IsNullOrEmpty(venta.Observaciones) ? (object)DBNull.Value : venta.Observaciones);

                    idVenta = Convert.ToInt32(cmdV.ExecuteScalar());

                    // 2. Insertar detalles y descontar stock
                    InsertarDetallesYDescontarStock(conn, trans, idVenta, detalles);

                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
            return idVenta;
        }

        // ── Actualizar venta existente (transaccional) ────────────────────────────

        public void ActualizarVenta(Venta venta, List<DetalleVenta> nuevosDetalles)
        {
            using (SqlConnection conn = DBConnection.Connect())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    // 1. Actualizar cabecera
                    const string sqlUpd = @"
                        UPDATE [dbo].[Venta]
                        SET Id_Cliente     = @IdCliente,
                            Id_Metodo_Pago = @IdMetodoPago,
                            Tipo_Venta     = @TipoVenta,
                            Estado_Venta   = @EstadoVenta,
                            Observaciones  = @Observaciones
                        WHERE Id_Venta = @IdVenta";

                    SqlCommand cmdU = new SqlCommand(sqlUpd, conn, trans);
                    cmdU.Parameters.AddWithValue("@IdVenta",      venta.IdVenta);
                    cmdU.Parameters.AddWithValue("@IdCliente",    venta.IdCliente);
                    cmdU.Parameters.AddWithValue("@IdMetodoPago", venta.IdMetodoPago);
                    cmdU.Parameters.AddWithValue("@TipoVenta",    venta.TipoVenta);
                    cmdU.Parameters.AddWithValue("@EstadoVenta",  venta.EstadoVenta);
                    cmdU.Parameters.AddWithValue("@Observaciones",
                        string.IsNullOrEmpty(venta.Observaciones) ? (object)DBNull.Value : venta.Observaciones);
                    cmdU.ExecuteNonQuery();

                    // 2. Restaurar stock de los detalles anteriores
                    RestaurarStock(conn, trans, venta.IdVenta);

                    // 3. Eliminar detalles anteriores
                    EliminarDetalles(conn, trans, venta.IdVenta);

                    // 4. Insertar nuevos detalles y descontar stock
                    InsertarDetallesYDescontarStock(conn, trans, venta.IdVenta, nuevosDetalles);

                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
        }

        // ── Eliminar venta y restaurar stock (transaccional) ──────────────────────

        public void EliminarVenta(int idVenta)
        {
            using (SqlConnection conn = DBConnection.Connect())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    RestaurarStock(conn, trans, idVenta);
                    EliminarDetalles(conn, trans, idVenta);

                    SqlCommand cmdDel = new SqlCommand(
                        "DELETE FROM [dbo].[Venta] WHERE Id_Venta = @IdVenta", conn, trans);
                    cmdDel.Parameters.AddWithValue("@IdVenta", idVenta);
                    cmdDel.ExecuteNonQuery();

                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
        }

        // ── Consultas ─────────────────────────────────────────────────────────────

        public List<Venta> ObtenerPorFecha(DateTime desde, DateTime hasta)
        {
            var lista = new List<Venta>();
            using (SqlConnection conn = DBConnection.Connect())
            {
                conn.Open();
                const string sql = @"
                    SELECT v.Id_Venta, v.Id_Cliente, v.Id_Usuario, v.Id_Metodo_Pago,
                           v.Tipo_Venta, v.Estado_Venta, v.Fecha_Venta, v.Observaciones,
                           c.Nombre_Cliente,
                           u.Nombre_Usuario,
                           mp.Nombre_Metodo,
                           ISNULL((SELECT SUM(dv.Subtotal) FROM [dbo].[Detalle_Venta] dv
                                   WHERE dv.Id_Venta = v.Id_Venta), 0) AS Total
                    FROM   [dbo].[Venta]       v
                    LEFT JOIN [dbo].[Cliente]      c  ON c.Id_Cliente      = v.Id_Cliente
                    LEFT JOIN [dbo].[Usuario]      u  ON u.Id_Usuario      = v.Id_Usuario
                    LEFT JOIN [dbo].[Metodo_Pago]  mp ON mp.Id_Metodo_Pago = v.Id_Metodo_Pago
                    WHERE  v.Fecha_Venta >= @Desde AND v.Fecha_Venta < @Hasta
                    ORDER BY v.Fecha_Venta DESC";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Desde", desde.Date);
                cmd.Parameters.AddWithValue("@Hasta", hasta.Date.AddDays(1));
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    lista.Add(MapearVenta(reader));
            }
            return lista;
        }

        public List<DetalleVenta> ObtenerDetallesPorVenta(int idVenta)
        {
            var lista = new List<DetalleVenta>();
            using (SqlConnection conn = DBConnection.Connect())
            {
                conn.Open();
                const string sql = @"
                    SELECT dv.Id_Detalle_Venta, dv.Id_Venta, dv.Id_Producto,
                           dv.Id_Escala, dv.Cantidad_Vendida, dv.Precio_Unitario,
                           dv.Descuento, dv.Subtotal, p.Nombre_Producto
                    FROM   [dbo].[Detalle_Venta] dv
                    JOIN   [dbo].[Producto]       p  ON p.Id_Producto = dv.Id_Producto
                    WHERE  dv.Id_Venta = @IdVenta";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IdVenta", idVenta);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    lista.Add(MapearDetalle(reader));
            }
            return lista;
        }

        public Venta? ObtenerPorId(int idVenta)
        {
            using (SqlConnection conn = DBConnection.Connect())
            {
                conn.Open();
                const string sql = @"
                    SELECT v.Id_Venta, v.Id_Cliente, v.Id_Usuario, v.Id_Metodo_Pago,
                           v.Tipo_Venta, v.Estado_Venta, v.Fecha_Venta, v.Observaciones,
                           c.Nombre_Cliente, u.Nombre_Usuario, mp.Nombre_Metodo,
                           ISNULL((SELECT SUM(dv.Subtotal) FROM [dbo].[Detalle_Venta] dv
                                   WHERE dv.Id_Venta = v.Id_Venta), 0) AS Total
                    FROM   [dbo].[Venta]       v
                    LEFT JOIN [dbo].[Cliente]      c  ON c.Id_Cliente      = v.Id_Cliente
                    LEFT JOIN [dbo].[Usuario]      u  ON u.Id_Usuario      = v.Id_Usuario
                    LEFT JOIN [dbo].[Metodo_Pago]  mp ON mp.Id_Metodo_Pago = v.Id_Metodo_Pago
                    WHERE  v.Id_Venta = @IdVenta";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IdVenta", idVenta);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    return MapearVenta(reader);
            }
            return null;
        }

        // ── Helpers privados ──────────────────────────────────────────────────────

        private void InsertarDetallesYDescontarStock(
            SqlConnection conn, SqlTransaction trans, int idVenta, List<DetalleVenta> detalles)
        {
            foreach (var d in detalles)
            {
                // Verificar stock disponible
                SqlCommand cmdStock = new SqlCommand(
                    "SELECT Stock_Actual FROM [dbo].[Producto] WHERE Id_Producto = @IdProducto",
                    conn, trans);
                cmdStock.Parameters.AddWithValue("@IdProducto", d.IdProducto);
                int stockActual = Convert.ToInt32(cmdStock.ExecuteScalar());
                if (stockActual < d.CantidadVendida)
                    throw new InvalidOperationException(
                        $"Stock insuficiente para el producto ID {d.IdProducto}. " +
                        $"Disponible: {stockActual}, solicitado: {d.CantidadVendida}.");

                // Insertar detalle (Subtotal es columna calculada, no se inserta)
                const string sqlDet = @"
                    INSERT INTO [dbo].[Detalle_Venta]
                        (Id_Venta, Id_Producto, Id_Escala, Cantidad_Vendida,
                         Precio_Unitario, Descuento)
                    VALUES
                        (@IdVenta, @IdProducto, @IdEscala, @CantidadVendida,
                         @PrecioUnitario, @Descuento)";

                SqlCommand cmdDet = new SqlCommand(sqlDet, conn, trans);
                cmdDet.Parameters.AddWithValue("@IdVenta",        idVenta);
                cmdDet.Parameters.AddWithValue("@IdProducto",     d.IdProducto);
                cmdDet.Parameters.AddWithValue("@IdEscala",       DBNull.Value);
                cmdDet.Parameters.AddWithValue("@CantidadVendida", d.CantidadVendida);
                cmdDet.Parameters.AddWithValue("@PrecioUnitario",  d.PrecioUnitario);
                cmdDet.Parameters.AddWithValue("@Descuento",       d.Descuento);
                cmdDet.ExecuteNonQuery();

                // Descontar stock
                SqlCommand cmdDesSt = new SqlCommand(
                    "UPDATE [dbo].[Producto] SET Stock_Actual = Stock_Actual - @Cantidad WHERE Id_Producto = @IdProducto",
                    conn, trans);
                cmdDesSt.Parameters.AddWithValue("@Cantidad",    d.CantidadVendida);
                cmdDesSt.Parameters.AddWithValue("@IdProducto",  d.IdProducto);
                cmdDesSt.ExecuteNonQuery();
            }
        }

        private void RestaurarStock(SqlConnection conn, SqlTransaction trans, int idVenta)
        {
            SqlCommand cmdRead = new SqlCommand(
                "SELECT Id_Producto, Cantidad_Vendida FROM [dbo].[Detalle_Venta] WHERE Id_Venta = @IdVenta",
                conn, trans);
            cmdRead.Parameters.AddWithValue("@IdVenta", idVenta);
            SqlDataReader reader = cmdRead.ExecuteReader();
            var items = new List<(int IdProd, int Cantidad)>();
            while (reader.Read())
                items.Add((Convert.ToInt32(reader["Id_Producto"]), Convert.ToInt32(reader["Cantidad_Vendida"])));
            reader.Close();

            foreach (var (idProd, cantidad) in items)
            {
                SqlCommand cmdRes = new SqlCommand(
                    "UPDATE [dbo].[Producto] SET Stock_Actual = Stock_Actual + @Cantidad WHERE Id_Producto = @IdProducto",
                    conn, trans);
                cmdRes.Parameters.AddWithValue("@Cantidad",   cantidad);
                cmdRes.Parameters.AddWithValue("@IdProducto", idProd);
                cmdRes.ExecuteNonQuery();
            }
        }

        private void EliminarDetalles(SqlConnection conn, SqlTransaction trans, int idVenta)
        {
            SqlCommand cmd = new SqlCommand(
                "DELETE FROM [dbo].[Detalle_Venta] WHERE Id_Venta = @IdVenta", conn, trans);
            cmd.Parameters.AddWithValue("@IdVenta", idVenta);
            cmd.ExecuteNonQuery();
        }

        private Venta MapearVenta(SqlDataReader reader)
        {
            return new Venta
            {
                IdVenta          = Convert.ToInt32(reader["Id_Venta"]),
                IdCliente        = Convert.ToInt32(reader["Id_Cliente"]),
                IdUsuario        = Convert.ToInt32(reader["Id_Usuario"]),
                IdMetodoPago     = Convert.ToInt32(reader["Id_Metodo_Pago"]),
                TipoVenta        = reader["Tipo_Venta"].ToString()!,
                EstadoVenta      = reader["Estado_Venta"].ToString()!,
                FechaVenta       = Convert.ToDateTime(reader["Fecha_Venta"]),
                Observaciones    = reader["Observaciones"]   == DBNull.Value ? string.Empty : reader["Observaciones"].ToString()!,
                NombreCliente    = reader["Nombre_Cliente"]  == DBNull.Value ? string.Empty : reader["Nombre_Cliente"].ToString()!,
                NombreUsuario    = reader["Nombre_Usuario"]  == DBNull.Value ? string.Empty : reader["Nombre_Usuario"].ToString()!,
                NombreMetodoPago = reader["Nombre_Metodo"]   == DBNull.Value ? string.Empty : reader["Nombre_Metodo"].ToString()!,
                Total            = reader["Total"]           == DBNull.Value ? 0            : Convert.ToDecimal(reader["Total"])
            };
        }

        private DetalleVenta MapearDetalle(SqlDataReader reader)
        {
            return new DetalleVenta
            {
                IdDetalleVenta  = Convert.ToInt32(reader["Id_Detalle_Venta"]),
                IdVenta         = Convert.ToInt32(reader["Id_Venta"]),
                IdProducto      = Convert.ToInt32(reader["Id_Producto"]),
                IdEscala        = reader["Id_Escala"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Id_Escala"]),
                CantidadVendida = Convert.ToInt32(reader["Cantidad_Vendida"]),
                PrecioUnitario  = Convert.ToDecimal(reader["Precio_Unitario"]),
                Descuento       = Convert.ToDecimal(reader["Descuento"]),
                Subtotal        = Convert.ToDecimal(reader["Subtotal"]),
                NombreProducto  = reader["Nombre_Producto"].ToString()!
            };
        }
    }
}
