using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaElBuenAmigo.models
{
    public class templateClientePaciente
    {
        public int idPaciente { get; set; }
        public string nombrePaciente { get; set; }
        public string nombreCliente { get; set; }
        public string apellidoCliente { get; set; }
        public string nombreEspecie { get; set; }
        public string genero { get; set; }
        public string nombreRaza { get; set;}
        public string color { get; set; }

        public templateClientePaciente()
        {

        }

        public templateClientePaciente(int idPaciente, string nombrePaciente, string apellidoCliente, string nombreCliente, string genero, string color)
        {
            this.idPaciente = idPaciente;
            this.nombrePaciente = nombrePaciente;
            this.apellidoCliente = apellidoCliente;
            this.genero = genero;
            this.color = color;
            this.nombreCliente = nombreCliente;
        }
    }
}
