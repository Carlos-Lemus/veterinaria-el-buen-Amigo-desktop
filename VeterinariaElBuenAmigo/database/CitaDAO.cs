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
    public class CitaDAO : DAO
    {
        private SQLiteConnection conn;
        private List<Cita> listaCitas;

        public CitaDAO()
        {
            listaCitas = new List<Cita>();
        }

        public bool ingresarCita(Cita cita)
        {
            try
            {
                conn = Conexion.Conn;
                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"INSERT INTO {TABLE_CITA} ({IDCITA}, {FECHA_CITA}, {IDPACIENTE}, {MOTIVO}) ";
                    sql += $"VALUES(NULL, @{FECHA_CITA}, @{IDPACIENTE}, @{MOTIVO});";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"@{FECHA_CITA}", cita.Fecha_cita);
                    command.Parameters.AddWithValue($"@{IDPACIENTE}", cita.IdPaciente);
                    command.Parameters.AddWithValue($"@{MOTIVO}", cita.Motivo);
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

        public List<Cita> getListaCitas()
        {
            try
            {
                conn = Conexion.Conn;
                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_CITA}";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        
                        
                        if (listaCitas.Count > 0)
                        {
                            listaCitas.Clear();
                        }

                        if (result.HasRows)
                        {
                            
                            while (result.Read())
                            {
                                Cita cita = new Cita();

                                cita.IdCita = Convert.ToInt32(result[IDCITA].ToString());
                                cita.Fecha_cita = result[FECHA_CITA].ToString();
                                cita.IdPaciente = Convert.ToInt32(result[IDPACIENTE].ToString());
                                cita.Motivo = result[MOTIVO].ToString();

                                listaCitas.Add(cita);
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
            return listaCitas;
        }

        public bool editarCita(Cita cita)
        {
            try
            {
                conn = Conexion.Conn;
                conn.Open();

                using(SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"UPDATE {TABLE_CITA} SET {FECHA_CITA} = @{FECHA_CITA}, {IDPACIENTE} = @{IDPACIENTE}, {MOTIVO} = @{MOTIVO} ";
                    sql += $"WHERE {IDCITA} = @{IDCITA};";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"@{IDCITA}", cita.IdCita);
                    command.Parameters.AddWithValue($"@{FECHA_CITA}", cita.Fecha_cita);
                    command.Parameters.AddWithValue($"@{IDPACIENTE}", cita.IdPaciente);
                    command.Parameters.AddWithValue($"@{MOTIVO}", cita.Motivo);
                    command.ExecuteNonQuery();

                    conn.Close();

                    return true;
                }

            }catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        public bool eliminarCita(int idCita)
        {
            try
            {
                conn = Conexion.Conn;
                conn.Open();

                using(SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"DELETE FROM {TABLE_CITA} WHERE {IDCITA} = @{IDCITA};";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"@{IDCITA}", idCita);
                    command.ExecuteNonQuery();

                    conn.Close();

                    return true;
                }
            }catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}