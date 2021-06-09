using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinariaElBuenAmigo.models;

namespace VeterinariaElBuenAmigo.database
{
    public class ProductosDAO : DAO
    {
        private SQLiteConnection conn;
        private List<Producto> listaProductos;

        public ProductosDAO()
        {
            listaProductos = new List<Producto>();
        }

        public bool ingresarProducto(Producto producto)
        {
            try
            {
                conn = Conexion.Conn;
                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"INSERT INTO {TABLE_PRODUCTO} ({IDPRODUCTO}, {NOMBREPRODUCTO}, {CANTIDAD_DISPONIBLE}, {TIPOPRODUCTO}, {MARCA}, {DESCRIPCION_PRODUCTO}, {FECHA_ADQUISICION}) ";
                    sql += $"VALUES(NULL, @{NOMBREPRODUCTO}, @{CANTIDAD_DISPONIBLE}, @{TIPOPRODUCTO}, @{MARCA}, @{DESCRIPCION_PRODUCTO}, @{FECHA_ADQUISICION});";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"{NOMBREPRODUCTO}", producto.NombreProducto);
                    command.Parameters.AddWithValue($"{CANTIDAD_DISPONIBLE}", producto.CantidadDisponible);
                    command.Parameters.AddWithValue($"{TIPOPRODUCTO}", producto.TipoProducto);
                    command.Parameters.AddWithValue($"{MARCA}", producto.Marca);
                    command.Parameters.AddWithValue($"{DESCRIPCION_PRODUCTO}", producto.Descripcion);
                    command.Parameters.AddWithValue($"{FECHA_ADQUISICION}", producto.FechaAdquisicion);
                    command.ExecuteNonQuery();

                    conn.Close();

                    return true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Producto getProducto(int id)
        {
            Producto producto = new Producto();
            try
            {
                conn = Conexion.Conn;
                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_PRODUCTO} WHERE {IDPRODUCTO} = @{IDPRODUCTO}";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"@{IDPRODUCTO}", id);

                    

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                producto.IdProducto = Convert.ToInt32(result[IDPRODUCTO].ToString());
                                producto.NombreProducto = result[NOMBREPRODUCTO].ToString();
                                producto.CantidadDisponible = Convert.ToInt32(result[CANTIDAD_DISPONIBLE].ToString());
                                producto.TipoProducto = result[TIPOPRODUCTO].ToString();
                                producto.Marca = result[MARCA].ToString();
                                producto.Descripcion = result[DESCRIPCION_PRODUCTO].ToString();
                                producto.FechaAdquisicion = result[FECHA_ADQUISICION].ToString();
                            }
                        }
                    }
                }
                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return producto;
        }

        public List<Producto> getListaProductos()
        {
            try
            {
                conn = Conexion.Conn;
                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_PRODUCTO}";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        if (listaProductos.Count > 0)
                        {
                            listaProductos.Clear();
                        }

                        if (result.HasRows)
                        {

                            while (result.Read())
                            {
                                Producto producto = new Producto();

                                producto.IdProducto = Convert.ToInt32(result[IDPRODUCTO].ToString());
                                producto.NombreProducto = result[NOMBREPRODUCTO].ToString();
                                producto.CantidadDisponible = Convert.ToInt32(result[CANTIDAD_DISPONIBLE].ToString());
                                producto.TipoProducto = result[TIPOPRODUCTO].ToString();
                                producto.Marca = result[MARCA].ToString();
                                producto.Descripcion = result[DESCRIPCION_PRODUCTO].ToString();
                                producto.FechaAdquisicion = result[FECHA_ADQUISICION].ToString();

                                listaProductos.Add(producto);
                            }
                        }
                    }
                }
                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listaProductos;
        }

        public bool editarProducto(Producto producto)
        {
            try
            {
                conn = Conexion.Conn;
                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"UPDATE {TABLE_PRODUCTO} SET {NOMBREPRODUCTO} = @{NOMBREPRODUCTO}, {CANTIDAD_DISPONIBLE} = @{CANTIDAD_DISPONIBLE}, {TIPOPRODUCTO} = @{TIPOPRODUCTO}, " +
                        $"{MARCA} = @{MARCA}, {DESCRIPCION_PRODUCTO} = @{DESCRIPCION_PRODUCTO}, {FECHA_ADQUISICION} = @{FECHA_ADQUISICION} ";

                    sql += $"WHERE {IDPRODUCTO} = @{IDPRODUCTO}";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"{IDPRODUCTO}", producto.IdProducto);
                    command.Parameters.AddWithValue($"{NOMBREPRODUCTO}", producto.NombreProducto);
                    command.Parameters.AddWithValue($"{CANTIDAD_DISPONIBLE}", producto.CantidadDisponible);
                    command.Parameters.AddWithValue($"{TIPOPRODUCTO}", producto.TipoProducto);
                    command.Parameters.AddWithValue($"{MARCA}", producto.Marca);
                    command.Parameters.AddWithValue($"{DESCRIPCION_PRODUCTO}", producto.Descripcion);
                    command.Parameters.AddWithValue($"{FECHA_ADQUISICION}", producto.FechaAdquisicion);
                    command.ExecuteNonQuery();

                    conn.Close();

                    return true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool eliminarProducto(int id)
        {
            try
            {
                conn = Conexion.Conn;
                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"DELETE FROM {TABLE_PRODUCTO} WHERE {IDPRODUCTO} = @{IDPRODUCTO};";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"@{IDPRODUCTO}", id);
                    command.ExecuteNonQuery();

                    conn.Close();

                    return true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
