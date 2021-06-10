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
    public class EspecieDAO : DAO
    {

        private List<Especie> lista;

        private SQLiteConnection conn;

        public EspecieDAO()
        {
            lista = new List<Especie>();
        }

        public bool insert(Especie especie)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"INSERT INTO {TABLE_ESPECIE} ({IDESPECIE}, {NOMBRE_ESPECIE}) ";
                    sql += $"VALUES(NULL, @{NOMBRE_ESPECIE});";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"@{NOMBRE_ESPECIE}", especie.nombreEspecie);
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

        public List<Especie> getList()
        {

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_ESPECIE}";
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
                                Especie especie = new Especie();

                                especie.idEspecie = Convert.ToInt32(result[IDESPECIE].ToString());
                                especie.nombreEspecie = result[NOMBRE_ESPECIE].ToString();

                                lista.Add(especie);
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

        public bool update(Especie especie)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"UPDATE {TABLE_ESPECIE} SET {NOMBRE_ESPECIE} = @{NOMBRE_ESPECIE} ";
                    sql += $"WHERE {IDESPECIE} = @{IDESPECIE};";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"@{IDESPECIE}", especie.idEspecie);
                    command.Parameters.AddWithValue($"@{NOMBRE_ESPECIE}", especie.nombreEspecie);
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

        public bool delete(int idEspecie)
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
                    sql += $"    WHERE {TABLE_PACIENTE}.{IDESPECIE} = @{IDESPECIE} ";
                    sql += $"); ";

                    sql += $"DELETE FROM {TABLE_CITA} ";
                    sql += $"WHERE {IDPACIENTE} IN ( ";
                    sql += $"    SELECT {TABLE_PACIENTE}.{IDPACIENTE} ";
                    sql += $"    FROM {TABLE_PACIENTE}";
                    sql += $"    WHERE {TABLE_PACIENTE}.{IDESPECIE} = @{IDESPECIE} ";
                    sql += $"); ";

                    sql += $"DELETE FROM {TABLE_PACIENTE} WHERE {IDESPECIE} = @{IDESPECIE}; ";

                    sql += $"DELETE FROM {TABLE_ESPECIE} WHERE {IDESPECIE} = @{IDESPECIE}; ";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"@{IDESPECIE}", idEspecie);
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
