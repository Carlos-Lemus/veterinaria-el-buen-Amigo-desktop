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
                    string sql = $"INSERT INTO {TABLE_CLIENTE} ({IDCLIENTE}, {NOMBRECLIENTE}, {TELEFONO}, {DIRECCION}, {CORREO}) ";
                    sql += $"VALUES(NULL, @{NOMBRECLIENTE}, @{TELEFONO}, @{DIRECCION}, @{CORREO});";
                    
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"@{NOMBRECLIENTE}", cliente.NombreCliente);
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
                                cliente.Direccion = result[DIRECCION].ToString();
                                cliente.Telefono = Convert.ToInt32(result[TELEFONO].ToString());
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

    }
}