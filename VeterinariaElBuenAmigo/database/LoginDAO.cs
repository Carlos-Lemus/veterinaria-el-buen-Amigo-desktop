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
    public class LoginDAO : DAO
    {
        private SQLiteConnection conn;

        private Login login;

        public LoginDAO()
        {
            login = new Login();
        }

        public Login getLogin()
        {

            Login login = null;

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_LOGIN} LIMIT 1";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        
                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                login = new Login();
                                login.idPassword = Convert.ToInt32(result[IDPASSWORD].ToString());
                                login.password = result[PASSWORD].ToString();
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

            return login;
        }

        public bool update(Login login)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"UPDATE {TABLE_LOGIN} SET {PASSWORD} = @{PASSWORD} ";
                    sql += $"WHERE {IDPASSWORD} = @{IDPASSWORD};";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"@{IDPASSWORD}", login.idPassword);
                    command.Parameters.AddWithValue($"@{PASSWORD}", login.password);
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
