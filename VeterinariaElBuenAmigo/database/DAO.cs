using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaElBuenAmigo.database
{
    public class DAO
    {
        //Tabla Clientes
        protected const string TABLE_CLIENTE = "clientes";
        protected const string IDCLIENTE = "idCliente";
        protected const string NOMBRECLIENTE = "nombreCliente";
        protected const string TELEFONO = "telefono";
        protected const string DIRECCION = "direccion";
        protected const string CORREO = "correo";

        //Tabla Citas
        protected const string TABLE_CITA = "citas";
        protected const string IDCITA = "idCita";
        protected const string FECHA_CITA = "fecha_cita";
        protected const string IDPACIENTE = "idPaciente";
        protected const string MOTIVO = "motivo";


        //Tabla Consulta
        protected const string TABLA_CONSULTA = "consultas";
        protected const string IDCONSULTA = "idConsulta";
        protected const string PADECIMIENTO = "padecimiento";
        protected const string TEMPERATURA = "temperatura";
        protected const string PESO = "peso";
        protected const string ID_PACIENTE = "idPaciente";
        protected const string CONTROLDECELO = "controlCelo";
        protected const string COMENTARIOS = "comentarios";
    }
}
