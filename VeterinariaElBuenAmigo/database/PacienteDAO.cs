using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaElBuenAmigo.models;
using System.Windows.Forms;

namespace VeterinariaElBuenAmigo.database
{
    public class PacienteDAO : DAO
    {
        private SQLiteConnection conn;

        // LISTA PARA ALMACENAR LOS PACIENTES
        private List<Paciente> lista;
        private List<Paciente> listaMascotasDePropietario;
        private List<Especie> listaEspecies;
        private List<Raza> listaRazas;

        // LISTA PARA ALMACENAR LOS DATOS RELACIONADOS ENTRE PACIENTES Y CLIENTES
        private List<templateClientePaciente> listaTemplateCP;

        public PacienteDAO()
        {
            lista = new List<Paciente>();            
            listaEspecies = new List<Especie>();
            listaRazas = new List<Raza>();
            listaMascotasDePropietario = new List<Paciente>();
            listaTemplateCP = new List<templateClientePaciente>();
        }

        public bool insert(Paciente paciente)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"INSERT INTO {TABLE_PACIENTE} ({IDPACIENTE}, {NOMBREPACIENTE}, {IDCLIENTE}, {IDESPECIE}, {IDRAZA}, {FECHA_NACIMIENTO}, {GENERO}, {COLOR}, {CARACTERISTICAS_ESPECIALES}) ";
                    sql += $"VALUES(NULL, @{NOMBREPACIENTE}, @{IDCLIENTE}, @{IDESPECIE}, @{IDRAZA}, @{FECHA_NACIMIENTO}, @{GENERO}, @{COLOR}, @{CARACTERISTICAS_ESPECIALES});";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"@{NOMBREPACIENTE}", paciente.nombrePaciente);
                    command.Parameters.AddWithValue($"@{IDCLIENTE}", paciente.idCliente);
                    command.Parameters.AddWithValue($"@{IDESPECIE}", paciente.idEspecie);
                    command.Parameters.AddWithValue($"@{IDRAZA}", paciente.idRaza);
                    command.Parameters.AddWithValue($"@{FECHA_NACIMIENTO}", paciente.fechaNacimiento);
                    command.Parameters.AddWithValue($"@{GENERO}", paciente.genero);
                    command.Parameters.AddWithValue($"@{COLOR}", paciente.color);
                    command.Parameters.AddWithValue($"@{CARACTERISTICAS_ESPECIALES}", paciente.caracteristicasEspeciales);
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

        public bool update(Paciente paciente)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"UPDATE {TABLE_PACIENTE} SET {NOMBREPACIENTE} = @{NOMBREPACIENTE}, {IDESPECIE} = @{IDESPECIE}, {IDRAZA} = @{IDRAZA}, {GENERO} = @{GENERO}, {COLOR} = @{COLOR}, {FECHA_NACIMIENTO} = @{FECHA_NACIMIENTO},{CARACTERISTICAS_ESPECIALES} = @{CARACTERISTICAS_ESPECIALES} ";
                    sql += $"WHERE {IDPACIENTE} = @{IDPACIENTE};";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"@{NOMBREPACIENTE}", paciente.nombrePaciente);
                    command.Parameters.AddWithValue($"@{IDESPECIE}", paciente.idEspecie);
                    command.Parameters.AddWithValue($"@{IDRAZA}", paciente.idRaza);
                    command.Parameters.AddWithValue($"@{GENERO}", paciente.genero);
                    command.Parameters.AddWithValue($"@{COLOR}", paciente.color);
                    command.Parameters.AddWithValue($"@{FECHA_NACIMIENTO}", paciente.fechaNacimiento);
                    command.Parameters.AddWithValue($"@{CARACTERISTICAS_ESPECIALES}", paciente.caracteristicasEspeciales);
                    command.Parameters.AddWithValue($"@{IDPACIENTE}", paciente.idPaciente);
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

        public bool delete(int idMascota)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                deleteCitas(idMascota);

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"DELETE FROM {TABLE_PACIENTE} WHERE {IDPACIENTE} = @{IDPACIENTE};";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"@{IDPACIENTE}", idMascota);
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

        private void deleteCitas(int idMascota)
        {
            try
            {

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"DELETE FROM {TABLE_CITA} WHERE {IDPACIENTE} = @{IDPACIENTE};";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"@{IDPACIENTE}", idMascota);
                    command.ExecuteNonQuery();

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Paciente searchPaciente(int idPaciente)
        {
            Paciente p = new Paciente();
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_PACIENTE} WHERE {IDPACIENTE} = {idPaciente}";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        if (listaRazas.Count > 0)
                        {
                            listaRazas.Clear();
                        }

                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                p.idPaciente = Convert.ToInt32(result[IDPACIENTE].ToString());
                                p.nombrePaciente = result[NOMBREPACIENTE].ToString();
                                p.fechaNacimiento = result[FECHA_NACIMIENTO].ToString();
                                p.genero = result[GENERO].ToString();
                                p.color = result[COLOR].ToString();
                                p.caracteristicasEspeciales = result[CARACTERISTICAS_ESPECIALES].ToString();
                                p.idCliente = Convert.ToInt32(result[IDCLIENTE].ToString());
                                p.idRaza = Int32.Parse(result[IDRAZA].ToString());
                                p.idEspecie = Convert.ToInt32(result[IDESPECIE].ToString());
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

            return p;
        }

        public List<Paciente> getListMascotasDePropietario(int id)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_PACIENTE} WHERE idCliente = {id}";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        if (listaMascotasDePropietario.Count > 0)
                        {
                            listaMascotasDePropietario.Clear();
                        }

                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                Paciente paciente = new Paciente();

                                paciente.idPaciente = Convert.ToInt32(result[IDPACIENTE].ToString());
                                paciente.nombrePaciente = result[NOMBREPACIENTE].ToString();
                                paciente.fechaNacimiento = result[FECHA_NACIMIENTO].ToString();
                                paciente.genero = result[GENERO].ToString();
                                paciente.color = result[COLOR].ToString();
                                paciente.caracteristicasEspeciales = result[CARACTERISTICAS_ESPECIALES].ToString();
                                paciente.idCliente = Convert.ToInt32(result[IDCLIENTE].ToString());
                                paciente.idRaza = Convert.ToInt32(result[IDRAZA].ToString());
                                paciente.idEspecie = Convert.ToInt32(result[IDESPECIE].ToString());

                                listaMascotasDePropietario.Add(paciente);
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

            return listaMascotasDePropietario;
        }


        // FUNCION QUE DEVUELVE TODOS LOS PACIENTES 
        public List<Paciente> getList()
        {

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_PACIENTE}";
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
                                Paciente paciente = new Paciente();

                                paciente.idPaciente = Convert.ToInt32(result[IDPACIENTE].ToString());
                                paciente.nombrePaciente = result[NOMBREPACIENTE].ToString();
                                paciente.fechaNacimiento = result[FECHA_NACIMIENTO].ToString();
                                paciente.genero = result[GENERO].ToString();
                                paciente.color = result[COLOR].ToString();
                                paciente.caracteristicasEspeciales = result[CARACTERISTICAS_ESPECIALES].ToString();
                                paciente.idCliente = Convert.ToInt32(result[IDCLIENTE].ToString());
                                paciente.idRaza = Convert.ToInt32(result[IDRAZA].ToString());
                                paciente.idEspecie = Convert.ToInt32(result[IDESPECIE].ToString());                            

                                lista.Add(paciente);
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

        public List<Especie> getListEspecie()
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
                        if (listaEspecies.Count > 0)
                        {
                            listaEspecies.Clear();
                        }

                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                Especie especie = new Especie();

                                especie.idEspecie = Convert.ToInt32(result[IDESPECIE].ToString());
                                especie.nombreEspecie = result[NOMBRE_ESPECIE].ToString();                                

                                listaEspecies.Add(especie);
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

            return listaEspecies;
        }

        public List<Raza> getListRazas()
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
                        if (listaRazas.Count > 0)
                        {
                            listaRazas.Clear();
                        }

                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                Raza raza = new Raza();

                                raza.idRaza = Convert.ToInt32(result[IDRAZA].ToString());
                                raza.nombreRaza = result[NOMBRE_RAZA].ToString();
                                raza.descripcion = result[RAZA_DESCRIPCION].ToString();

                                listaRazas.Add(raza);
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

            return listaRazas;
        }

        // FUNCION QUE DEVUELVE EL ARREGLO CON LA RELACION DE CLIENTES Y PACIENTES (INNER JOIN)
        public List<templateClientePaciente> getListPacienteCliente()
        {

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT p.{IDPACIENTE}, p.{NOMBREPACIENTE}, c.{NOMBRECLIENTE}, p.{COLOR}, p.{GENERO} FROM {TABLE_PACIENTE} AS p INNER JOIN {TABLE_CLIENTE} AS c ON p.{IDCLIENTE} = c.{IDCLIENTE}";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        if (listaTemplateCP.Count > 0)
                        {
                            listaTemplateCP.Clear();
                        }

                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                templateClientePaciente consulta = new templateClientePaciente();

                                consulta.idPaciente = Convert.ToInt32(result[IDPACIENTE].ToString());
                                consulta.nombrePaciente = result[NOMBREPACIENTE].ToString();
                                consulta.nombreCliente = result[NOMBRECLIENTE].ToString();
                                consulta.genero = result[GENERO].ToString();
                                consulta.color = result[COLOR].ToString();                           

                                listaTemplateCP.Add(consulta);
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

            return listaTemplateCP;
        }
    }
}
