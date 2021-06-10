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
    class RecetasDAO : DAO
    {
        private SQLiteConnection conn;
        private List<Recetas> lista;

        public RecetasDAO()
        {
            lista = new List<Recetas>();
        }

        public bool InsertarReceta(Recetas recetas)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"INSERT INTO {TABLA_RECETA} ({IDRECETA}, {IDPACIENTE}, {TIPO_RECETA}, {PADECIMIENTO}, {NOMBREPRODUCTORECETA}, {DOSIS}, {REFUERZO}) ";
                    sql += $"VALUES(NULL, @{IDPACIENTE},@{TIPO_RECETA}, @{PADECIMIENTO}, @{NOMBREPRODUCTORECETA}, @{DOSIS}, @{REFUERZO});";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"@{IDPACIENTE}", recetas.IdPaciente);
                    command.Parameters.AddWithValue($"@{TIPO_RECETA}", recetas.TipoReceta);
                    command.Parameters.AddWithValue($"@{PADECIMIENTO}", recetas.Padecimineto);
                    command.Parameters.AddWithValue($"@{NOMBREPRODUCTORECETA}", recetas.NombrePReceta);
                    command.Parameters.AddWithValue($"@{DOSIS}", recetas.Dosis);
                    command.Parameters.AddWithValue($"@{REFUERZO}", recetas.Refuerzo);                  
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

        //Retorna las vacunas
        public List<Recetas> getList(int tipo, int idP)
        {

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLA_RECETA} WHERE {TIPO_RECETA} = {tipo} AND {IDPACIENTE} = {idP}";
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
                                Recetas recetas = new Recetas();

                                recetas.IdReceta = Convert.ToInt32(result[IDRECETA].ToString());
                                recetas.IdPaciente = Convert.ToInt32(result[ID_PACIENTE].ToString());
                                recetas.TipoReceta = Convert.ToInt32(result[TIPO_RECETA].ToString());
                                recetas.Padecimineto = result[PADECIMIENTO].ToString();
                                recetas.NombrePReceta = result[NOMBREPRODUCTORECETA].ToString();
                                recetas.Dosis = Convert.ToInt32(result[DOSIS].ToString());
                                recetas.Refuerzo = result[REFUERZO].ToString();                              
                                lista.Add(recetas);
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

        public bool delete(int id)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"DELETE FROM {TABLA_RECETA} WHERE {IDRECETA} = @{IDRECETA};";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"@{IDRECETA}", id);
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
