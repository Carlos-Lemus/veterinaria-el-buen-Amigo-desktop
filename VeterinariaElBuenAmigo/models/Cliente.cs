using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaElBuenAmigo.models
{
    public class Cliente
    {
        private int idCliente;
        private string nombreCliente;
        private string apellido;
        private string telefono;
        private string correo;
        private string direccion;

        public Cliente() {

        }

        public Cliente (int idCliente, string nombreCliente, string apellido, string direccion, string telefono, string correo)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellido = apellido;
            this.telefono = telefono;
            this.correo = correo;
            this.direccion = direccion;
        }

        public int IdCliente
        {
            get
            {
                return this.idCliente;
            }
            set
            {
                this.idCliente = value;
            }
        }

        public string NombreCliente
        {
            get
            {
                return this.nombreCliente;
            }
            set
            {
                this.nombreCliente = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public string Telefono
        {
            get
            {
                return this.telefono;
            }
            set
            {
                this.telefono = value;
            }
        }

        public string Direccion
        {
            get
            {
                return this.direccion;
            }

            set
            {
                this.direccion = value;
            }
        }

        public string Correo
        {
            get
            {
                return this.correo;
            }
            set
            {
                this.correo = value;
            }
        }
    }
}
