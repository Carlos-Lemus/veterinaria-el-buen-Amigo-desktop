using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinariaElBuenAmigo.database
{
    public class Conexion
    {
        private const string dataConnection = @"Data Source=./veterinaria.db; PRAGMA foreign_keys=ON; UTF8Encoding=True; Version=3";

        static private SQLiteConnection conn = null;
        static public SQLiteConnection Conn
        {
            get
            {

                if (conn == null)
                {
                    conn = new SQLiteConnection(dataConnection);

                    if (!File.Exists("./veterinaria.db"))
                    {
                        CreateDataBase();
                    }

                }

                return conn;
            }
        }

        private Conexion()
        {

        }


        static private void CreateDataBase()
        {

            try
            {
                SQLiteConnection.CreateFile("./veterinaria.db");

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = @"PRAGMA foreign_keys = ON;
                            CREATE TABLE login(
                                idPassword INTEGER PRIMARY KEY AUTOINCREMENT, 
                                password VARCHAR(50));

                            CREATE TABLE productos(
                                idProducto INTEGER PRIMARY KEY AUTOINCREMENT, 
                                nombreProducto VARCHAR(150),
                                cantidad_disponible INTEGER,
                                tipoProducto VARCHAR(50),
                                marca VARCHAR(50),
                                descripcion TEXT,
                                fecha_adquisicion TEXT);


                            CREATE TABLE vitaminas(
                                idVitamina INTEGER PRIMARY KEY AUTOINCREMENT, 
                                producto VARCHAR(150),
                                refuerzo VARCHAR(150));


                            CREATE TABLE vacunas(
                                idVacuna INTEGER PRIMARY KEY AUTOINCREMENT, 
                                nombreVacuna VARCHAR(150),
                                dosis INTEGER,
                                padecimiento VARCHAR(100),
                                refuerzo VARCHAR(150));


                            CREATE TABLE ResetaVacunas(
                                idResetaVacuna INTEGER PRIMARY KEY AUTOINCREMENT, 
                                idPaciente INTEGER,
                                idVacuna INTEGER,
                                FOREIGN KEY (idPaciente) REFERENCES pacientes(idPaciente)
                                ON DELETE CASCADE
                                ON UPDATE CASCADE
                                FOREIGN KEY (idVacuna) REFERENCES vacunas(idVacuna)
                                ON DELETE CASCADE
                                ON UPDATE CASCADE);

                            CREATE TABLE ResetaVitaminas(
                                idResetaVitamina INTEGER PRIMARY KEY AUTOINCREMENT, 
                                idPaciente INTEGER,
                                idVitamina INTEGER,
                                FOREIGN KEY (idPaciente) REFERENCES pacientes(idPaciente)
                                ON DELETE CASCADE
                                ON UPDATE CASCADE
                                FOREIGN KEY (idVitamina) REFERENCES vitaminas(idVitamina)
                                ON DELETE CASCADE
                                ON UPDATE CASCADE);

                            CREATE TABLE clientes(
                                idCliente INTEGER PRIMARY KEY AUTOINCREMENT, 
                                nombreCliente VARCHAR(150),
                                telefono INTEGER,
                                direccion TEXT,
                                correo VARCHAR(150));

                            CREATE TABLE especies(
                                idEspecie INTEGER PRIMARY KEY AUTOINCREMENT, 
                                nombreEspecie VARCHAR(100));

                            CREATE TABLE razas(
                                idRaza INTEGER PRIMARY KEY AUTOINCREMENT, 
                                nombreRaza VARCHAR(100),
                                descripcion TEXT);

                            CREATE TABLE pacientes(
                                idPaciente INTEGER PRIMARY KEY AUTOINCREMENT, 
                                nombrePaciente VARCHAR(150),
                                idCliente INTEGER,
                                idEspecie INTEGER,
                                idRaza INTEGER,
                                fechaNacimiento VARCHAR(150),
                                genero VARCHAR(25),
                                color VARCHAR(25),
                                caracteristicas_especiales TEXT,
                                FOREIGN KEY (idCliente ) REFERENCES clientes(idCliente)
                                ON DELETE CASCADE
                                ON UPDATE CASCADE
                                FOREIGN KEY (idEspecie) REFERENCES especies(idEspecie)
                                ON DELETE CASCADE
                                ON UPDATE CASCADE
                                FOREIGN KEY (idRaza) REFERENCES razas(idRaza)
                                ON DELETE CASCADE
                                ON UPDATE CASCADE);

                            CREATE TABLE citas(
                                idCita INTEGER PRIMARY KEY AUTOINCREMENT, 
                                fecha_cita VARCHAR(150),
                                idPaciente INTEGER,
                                motivo TEXT;

                            CREATE TABLE consultas(
                                idConsulta INTEGER PRIMARY KEY AUTOINCREMENT, 
                                padecimiento VARCHAR(150),
                                temperatura INTEGER,
                                peso INTEGER,
                                idPaciente INTEGER,
                                controlCelo VARCHAR(50),
                                comentarios TEXT,
                                FOREIGN KEY (idPaciente) REFERENCES pacientes(idPaciente)
                                ON DELETE CASCADE
                                ON UPDATE CASCADE);

                            ";


                    command.CommandText = sql;
                    command.Connection = conn;
                    command.ExecuteNonQuery();

                }

                conn.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error Create DataBase", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

/**
 * Codigo de tabla pacientes original
 * 
    CREATE TABLE citas(
    idCita INTEGER PRIMARY KEY AUTOINCREMENT, 
    fecha_cita VARCHAR(150),
    idPaciente INTEGER,
    motivo TEXT,
    FOREIGN KEY (idPaciente) REFERENCES pacientes(idPaciente)
    ON DELETE CASCADE
    ON UPDATE CASCADE);
 */