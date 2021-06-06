using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaElBuenAmigo.database
{
    public class DAO
    {
        protected const string TABLE_CLIENTE = "clientes";
        protected const string IDCLIENTE = "idCliente";
        protected const string NOMBRECLIENTE = "nombreCliente";
        protected const string TELEFONO = "telefono";
        protected const string DIRECCION = "direccion";
        protected const string CORREO = "correo";

        protected const string TABLE_CITA = "citas";
        protected const string IDCITA = "idCita";
        protected const string FECHA_CITA = "fecha_cita";
        protected const string IDPACIENTE = "idPaciente";
        protected const string MOTIVO = "motivo";
    }
}
