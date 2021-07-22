using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinariaElBuenAmigo.models;

namespace VeterinariaElBuenAmigo.database
{
    public class ClienteDAO : DAO
    {
        private SQLiteConnection conn;
        private List<Cliente> lista;

        public ClienteDAO()
        {
            lista = new List<Cliente>();
        }

        public bool insert(Cliente cliente)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"INSERT INTO {TABLE_CLIENTE} ({IDCLIENTE}, {NOMBRECLIENTE}, {APELLIDO}, {TELEFONO}, {DIRECCION}, {CORREO}) ";
                    sql += $"VALUES(NULL, @{NOMBRECLIENTE}, @{APELLIDO}, @{TELEFONO}, @{DIRECCION}, @{CORREO});";
                    
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"@{NOMBRECLIENTE}", cliente.NombreCliente);
                    command.Parameters.AddWithValue($"@{APELLIDO}", cliente.Apellido);
                    command.Parameters.AddWithValue($"@{TELEFONO}", cliente.Telefono);
                    command.Parameters.AddWithValue($"@{DIRECCION}", cliente.Direccion);
                    command.Parameters.AddWithValue($"@{CORREO}", cliente.Correo);
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

        public List<Cliente> getList()
        {

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_CLIENTE}";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        if (lista.Count > 0)
                        {
                            lista.Clear();
                        }

                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                Cliente cliente = new Cliente();

                                cliente.IdCliente = Convert.ToInt32(result[IDCLIENTE].ToString());
                                cliente.NombreCliente = result[NOMBRECLIENTE].ToString();
                                cliente.Apellido = result[APELLIDO].ToString();
                                cliente.Direccion = result[DIRECCION].ToString();
                                cliente.Telefono = result[TELEFONO].ToString();
                                cliente.Correo = result[CORREO].ToString();

                                lista.Add(cliente);
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

            return lista;

        }

        public bool searchCliente(string field, string value)
        {
            bool isExistClient = false;

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_CLIENTE} WHERE {field} = '{value}';";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {

                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                isExistClient = true;
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

            return isExistClient;

        }

        public bool update(Cliente cliente)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"UPDATE {TABLE_CLIENTE} SET {NOMBRECLIENTE} = @{NOMBRECLIENTE}, {APELLIDO} = @{APELLIDO}, {TELEFONO} = @{TELEFONO}, {DIRECCION} = @{DIRECCION}, {CORREO} = @{CORREO} ";
                    sql += $"WHERE {IDCLIENTE} = @{IDCLIENTE};";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"@{IDCLIENTE}", cliente.IdCliente);
                    command.Parameters.AddWithValue($"@{NOMBRECLIENTE}", cliente.NombreCliente);
                    command.Parameters.AddWithValue($"@{APELLIDO}", cliente.Apellido);
                    command.Parameters.AddWithValue($"@{TELEFONO}", cliente.Telefono);
                    command.Parameters.AddWithValue($"@{DIRECCION}", cliente.Direccion);
                    command.Parameters.AddWithValue($"@{CORREO}", cliente.Correo);
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

        public bool delete(int id)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = "";

                    sql += $"DELETE FROM {TABLA_CONSULTA} ";
                    sql += $"WHERE {IDPACIENTE} IN ( ";
                    sql += $"    SELECT {TABLE_PACIENTE}.{IDPACIENTE} ";
                    sql += $"    FROM {TABLE_PACIENTE}";
                    sql += $"    WHERE {TABLE_PACIENTE}.{IDCLIENTE} = @{IDCLIENTE} ";
                    sql += $"); ";

                    sql += $"DELETE FROM {TABLE_CITA} ";
                    sql += $"WHERE {IDPACIENTE} IN ( ";
                    sql += $"    SELECT {TABLE_PACIENTE}.{IDPACIENTE} ";
                    sql += $"    FROM {TABLE_PACIENTE}";
                    sql += $"    WHERE {TABLE_PACIENTE}.{IDCLIENTE} = @{IDCLIENTE} ";
                    sql += $"); ";

                    sql += $"DELETE FROM {TABLE_PACIENTE} WHERE {IDCLIENTE} = @{IDCLIENTE}; ";

                    sql += $"DELETE FROM {TABLE_CLIENTE} WHERE {IDCLIENTE} = @{IDCLIENTE};";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"@{IDCLIENTE}", id);
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