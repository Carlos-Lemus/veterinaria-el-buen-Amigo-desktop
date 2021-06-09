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
        //Retorna Todos los Datos
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
        //Retorna los datos filtrados por un id
        public List<Consulta> getListConsulta_porIDPaciente(int id)
        {

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLA_CONSULTA} WHERE {IDPACIENTE} = {id}";
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


        //Retorna el nombre dela especie
        public String EspecieporID(int id)
        {
            String Especie_ = ""; 

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_ESPECIE} WHERE {IDESPECIE} = {id}";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        
                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                Especie_ = result[NOMBRE_ESPECIE].ToString();
                            }
                        }
                        else
                        {
                            Especie_ = "No se encontró la raza"; 
                        }
                    }

                }

                conn.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Especie_;

        }

        //Retorna el nombre dela especie
        public String NombrePropietarioporID(int id)
        {
            String Nombre = "";

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_CLIENTE} WHERE {IDCLIENTE} = {id}";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {

                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                Nombre = result[NOMBRECLIENTE].ToString();
                            }
                        }
                        else
                        {
                            Nombre = "No se encontró al propietario";
                        }
                    }

                }

                conn.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Nombre;

        }
        public String NumerodeConsultas(int id)
        {
            String N = "";

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT count(*) FROM {TABLA_CONSULTA} WHERE {IDPACIENTE} = {id}";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {

                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                N = result["count(*)"].ToString();
                            }
                        }
                        else
                        {
                            N = "No se encontró";
                        }
                    }

                }

                conn.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return N;

        }


        public bool deleteConsulta(int id)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"DELETE FROM {TABLA_CONSULTA} WHERE {IDCONSULTA} = @{IDCONSULTA};";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"@{IDCONSULTA}", id);
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

        public bool EditarConsulta(Consulta consulta, int id)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    
                    string sql = $"UPDATE {TABLA_CONSULTA} SET {PADECIMIENTO} =  @{PADECIMIENTO}, {TEMPERATURA} = @{TEMPERATURA}, {PESO} = @{PESO}, {CONTROLDECELO} = @{CONTROLDECELO}, {COMENTARIOS} = @{COMENTARIOS} ";
                    sql += $" WHERE {IDCONSULTA} = {id};";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"@{PADECIMIENTO}", consulta.Padecimineto);
                    command.Parameters.AddWithValue($"@{TEMPERATURA}", consulta.Temperatura);
                    command.Parameters.AddWithValue($"@{PESO}", consulta.Peso);
                   // command.Parameters.AddWithValue($"@{ID_PACIENTE}", consulta.IdPaciente);
                    command.Parameters.AddWithValue($"@{CONTROLDECELO}", consulta.ControldeCelo);
                    command.Parameters.AddWithValue($"@{COMENTARIOS}", consulta.Comentarios);
                   // command.Parameters.AddWithValue($"@{IDCONSULTA}", id);
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