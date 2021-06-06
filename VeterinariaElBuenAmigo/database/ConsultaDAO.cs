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
    public class ConsultaDAO : DAO
    {
        private SQLiteConnection conn;
        private List<Consulta> lista;

        public ConsultaDAO()
        {
            lista = new List<Consulta>();
        }

        public bool InsertarConsulta(Consulta consulta)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"INSERT INTO {TABLA_CONSULTA} ({IDCONSULTA}, {PADECIMIENTO}, {TEMPERATURA}, {PESO}, {ID_PACIENTE}, {CONTROLDECELO}, {COMENTARIOS}) ";
                    sql += $"VALUES(NULL, @{PADECIMIENTO}, @{TEMPERATURA}, @{PESO}, @{ID_PACIENTE}, @{CONTROLDECELO}, @{COMENTARIOS});";
                    
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"@{PADECIMIENTO}", consulta.Padecimineto);
                    command.Parameters.AddWithValue($"@{TEMPERATURA}", consulta.Temperatura);
                    command.Parameters.AddWithValue($"@{PESO}", consulta.Peso);
                    command.Parameters.AddWithValue($"@{ID_PACIENTE}", consulta.IdPaciente);
                    command.Parameters.AddWithValue($"@{CONTROLDECELO}", consulta.ControldeCelo);
                    command.Parameters.AddWithValue($"@{COMENTARIOS}", consulta.Comentarios);
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

        public List<Consulta> getListConsulta()
        {

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLA_CONSULTA}";
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
                                Consulta consulta = new Consulta(); 

                                consulta.IdConsulta = Convert.ToInt32(result[IDCONSULTA].ToString());
                                consulta.Padecimineto = result[PADECIMIENTO].ToString();
                                consulta.Temperatura = result[TEMPERATURA].ToString();
                                consulta.Peso = result[PESO].ToString();
                                consulta.IdPaciente = Convert.ToInt32(result[ID_PACIENTE].ToString());
                                consulta.ControldeCelo = result[CONTROLDECELO].ToString();
                                consulta.Comentarios = result[COMENTARIOS].ToString();
                                lista.Add(consulta);
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