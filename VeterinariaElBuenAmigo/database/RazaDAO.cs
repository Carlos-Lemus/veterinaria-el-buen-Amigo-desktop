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
    public class RazaDAO : DAO
    {
        private List<Raza> lista;

        private SQLiteConnection conn;

        public RazaDAO()
        {
            lista = new List<Raza>();
        }

        public bool insert(Raza raza)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"INSERT INTO {TABLE_RAZA} ({IDRAZA}, {NOMBRE_RAZA}, {IDESPECIE}) ";
                    sql += $"VALUES(NULL, @{NOMBRE_RAZA}, '');";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"@{NOMBRE_RAZA}", raza.nombreRaza);
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

        public List<Raza> getList()
        {

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_RAZA}";
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
                                Raza raza = new Raza();

                                raza.idRaza = Convert.ToInt32(result[IDRAZA].ToString());
                                raza.nombreRaza = result[NOMBRE_RAZA].ToString();
                                raza.idEspecie = Convert.ToInt32(result[IDESPECIE].ToString());

                                lista.Add(raza);
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

        public bool update(Raza raza)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"UPDATE {TABLE_RAZA} SET {NOMBRE_RAZA} = @{NOMBRE_RAZA} ";
                    sql += $"WHERE {IDRAZA} = @{IDRAZA};";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"@{IDRAZA}", raza.idRaza);
                    command.Parameters.AddWithValue($"@{NOMBRE_RAZA}", raza.nombreRaza);
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

        public bool delete(int idRaza)
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
                    sql += $"    WHERE {TABLE_PACIENTE}.{IDRAZA} = @{IDRAZA} ";
                    sql += $"); ";

                    sql += $"DELETE FROM {TABLE_CITA} ";
                    sql += $"WHERE {IDPACIENTE} IN ( ";
                    sql += $"    SELECT {TABLE_PACIENTE}.{IDPACIENTE} ";
                    sql += $"    FROM {TABLE_PACIENTE}";
                    sql += $"    WHERE {TABLE_PACIENTE}.{IDRAZA} = @{IDRAZA} ";
                    sql += $"); ";

                    sql += $"DELETE FROM {TABLE_PACIENTE} WHERE {IDRAZA} = @{IDRAZA}; ";

                    sql += $"DELETE FROM {TABLE_RAZA} WHERE {IDRAZA} = @{IDRAZA}; ";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"@{IDRAZA}", idRaza);
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
