using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaElBuenAmigo.models
{


    class Recetas
    {
        private int idReceta;
        private int idPaciente;
        private int tipoReceta;
        private string padecimineto;
        private string nombreProducto_receta;
        private int dosis;
        private string refuerzo;

        public Recetas()
        {

        }

        public Recetas(int idReceta, int idPaciente, int tipoReceta, string padecimineto, string nombreProducto_receta, int dosis,string refuerzo)
        {
            this.idReceta = idReceta;
            this.idPaciente = idPaciente;
            this.tipoReceta = tipoReceta;
            this.padecimineto = padecimineto;
            this.nombreProducto_receta = nombreProducto_receta;
            this.dosis = dosis;
            this.refuerzo = refuerzo; 
        }

        public int IdReceta
        {
            get
            {
                return this.idReceta;
            }
            set
            {
                this.idReceta = value;
            }
        }

        public int IdPaciente
        {
            get
            {
                return this.idPaciente;
            }
            set
            {
                this.idPaciente = value;
            }
        }

        public int TipoReceta
        {
            get
            {
                return this.tipoReceta;
            }
            set
            {
                this.tipoReceta = value;
            }
        }
        public string Padecimineto
        {
            get
            {
                return this.padecimineto;
            }
            set
            {
                this.padecimineto = value;
            }
        }
        public string NombrePReceta
        {
            get
            {
                return this.nombreProducto_receta;
            }
            set
            {
                this.nombreProducto_receta = value;
            }
        }

        public int Dosis
        {
            get
            {
                return this.dosis;
            }
            set
            {
                this.dosis = value;
            }
        }

        public string Refuerzo
        {
            get
            {
                return this.refuerzo;
            }
            set
            {
                this.refuerzo = value;
            }
        }
    }
}
