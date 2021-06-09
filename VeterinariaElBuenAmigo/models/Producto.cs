using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaElBuenAmigo.models
{
    public class Producto
    {
        private int idProducto;
        private string nombreProducto;
        private int cantidadDisponible;
        private string tipoProducto;
        private string marca;
        private string descripcion;
        private string fechaAdquisicion;

        public Producto()
        {
        }

        public Producto(int idProducto, string nombreProducto, int cantidadDisponible, string tipoProducto, string marca, string descripcion, string fechaAdquisicion)
        {
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
            this.cantidadDisponible = cantidadDisponible;
            this.tipoProducto = tipoProducto;
            this.marca = marca;
            this.descripcion = descripcion;
            this.fechaAdquisicion = fechaAdquisicion;
        }

        public int IdProducto
        {
            get
            {
                return this.idProducto;
            }
            set
            {
                this.idProducto = value;
            }
        }

        public string NombreProducto
        {
            get
            {
                return this.nombreProducto;
            }
            set
            {
                this.nombreProducto = value;
            }
        }

        public int CantidadDisponible
        {
            get
            {
                return this.cantidadDisponible;
            }
            set
            {
                this.cantidadDisponible = value;
            }
        }

        public String TipoProducto
        {
            get
            {
                return this.tipoProducto;
            }
            set
            {
                this.tipoProducto = value;
            }
        }

        public string Marca
        {
            get
            {
                return this.marca;
            }
            set
            {
                this.marca = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                this.descripcion = value;
            }
        }

        public string FechaAdquisicion
        {
            get
            {
                return this.fechaAdquisicion;
            }
            set
            {
                this.fechaAdquisicion = value;
            }
        }
    }
}
