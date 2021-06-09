using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaElBuenAmigo.models
{
    public class Paciente
    {
        public int idPaciente { get; set; }
        public string nombrePaciente { get; set; }
        public string fechaNacimiento { get; set; }
        public string genero { get; set; }
        public string color { get; set; }
        public string caracteristicasEspeciales { get; set; }
        public int idRaza { get; set; }
        public int idEspecie { get; set; }
        public int idCliente { get; set; }

        public Paciente()
        {

        }

        public Paciente(int idPaciente, string nombrePaciente, string fechaNacimiento, string genero, string color, string caracteristicasEspeciales, int idRaza, int idEspecie, int idCliente)
        {
            this.idPaciente = idPaciente;
            this.nombrePaciente = nombrePaciente;
            this.fechaNacimiento = fechaNacimiento;
            this.genero = genero;
            this.color = color;
            this.caracteristicasEspeciales = caracteristicasEspeciales;
            this.idRaza = idRaza;
            this.idEspecie = idEspecie;
            this.idCliente = idCliente;
        }
    }
}
