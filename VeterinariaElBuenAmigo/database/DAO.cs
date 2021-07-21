using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaElBuenAmigo.database
{
    public class DAO
    {
        //CLAVE DE ACCESO
        protected const string CLAVEINGRESO = "a"; 

        //PRODUCTOS
        protected const string TABLE_PRODUCTO = "productos";
        protected const string IDPRODUCTO = "idProducto";
        protected const string NOMBREPRODUCTO = "nombreProducto";
        protected const string CANTIDAD_DISPONIBLE = "cantidad_disponible";
        protected const string TIPOPRODUCTO = "tipoProducto";
        protected const string MARCA = "marca";
        protected const string DESCRIPCION_PRODUCTO = "descripcion";
        protected const string FECHA_ADQUISICION = "fecha_adquisicion";

        //CLIENTES
        protected const string TABLE_CLIENTE = "clientes";
        protected const string IDCLIENTE = "idCliente";
        protected const string NOMBRECLIENTE = "nombreCliente";
        protected const string TELEFONO = "telefono";
        protected const string DIRECCION = "direccion";
        protected const string CORREO = "correo";

        //CITAS
        protected const string TABLE_CITA = "citas";
        protected const string IDCITA = "idCita";
        protected const string FECHA_CITA = "fecha_cita";      
        protected const string MOTIVO = "motivo";

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

        //ESPECIES
        protected const string TABLE_ESPECIE = "especies";
        protected const string IDESPECIE = "idEspecie";
        protected const string NOMBRE_ESPECIE = "nombreEspecie";

        //CONSULTAS
        protected const string TABLA_CONSULTA = "consultas";
        protected const string IDCONSULTA = "idConsulta";
        protected const string PADECIMIENTO = "padecimiento";
        protected const string TEMPERATURA = "temperatura";
        protected const string PESO = "peso";
        protected const string ID_PACIENTE = "idPaciente";
        protected const string CONTROLDECELO = "controlCelo";
        protected const string COMENTARIOS = "comentarios";

        //RESETA
        protected const string TABLA_RECETA = "recetas";
        protected const string IDRECETA = "idReceta";        
        protected const string TIPO_RECETA = "tipoReceta";
        protected const string NOMBREPRODUCTORECETA = "nombre_Producto";
        protected const string DOSIS = "dosis";
        protected const string REFUERZO = "refuerzo";

        // LOGIN
        protected const string TABLE_LOGIN = "login";
        protected const string IDPASSWORD = "idPassword";
        protected const string PASSWORD = "password";
    }
}
