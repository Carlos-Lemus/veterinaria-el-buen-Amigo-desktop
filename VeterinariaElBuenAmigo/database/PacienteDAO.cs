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

        // LISTA PARA ALMACENAR LOS DATOS RELACIONADOS ENTRE PACIENTES Y CLIENTES
        private List<templateClientePaciente> listaTemplateCP;

        public PacienteDAO()
        {
            lista = new List<Paciente>();            
            listaTemplateCP = new List<templateClientePaciente>();
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
