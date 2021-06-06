using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaElBuenAmigo.database
{
    public class DAO
    {
        //CLIENTES
        protected const string TABLE_CLIENTE = "clientes";
        protected const string IDCLIENTE = "idCliente";
        protected const string NOMBRECLIENTE = "nombreCliente";
        protected const string TELEFONO = "telefono";
        protected const string DIRECCION = "direccion";
        protected const string CORREO = "correo";

        //PACIENTES
        protected const string TABLE_PACIENTE = "pacientes";
        protected const string IDPACIENTE = "idPaciente";
        protected const string NOMBREPACIENTE = "nombrePaciente";
        protected const string FECHA_NACIMIENTO = "fechaNacimiento";
        protected const string GENERO = "genero";
        protected const string COLOR = "color";
        protected const string CARACTERISTICAS_ESPECIALES = "caracteristicas_especiales";

        //RAZAS
        protected const string TABLE_RAZA = "razas";
        protected const string IDRAZA = "idRaza";
        protected const string NOMBRE_RAZA = "nombreRaza";
        protected const string RAZA_DESCRIPCION = "descripcion";

        //PACIENTES
        protected const string TABLE_ESPECIE = "especies";
        protected const string IDESPECIE = "idEspecie";
        protected const string NOMBRE_ESPECIE = "nombreEspecie";

    }
}
