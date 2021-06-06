using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaElBuenAmigo.models
{/*
    protected const string IDCONSULTA = "idConsulta";
    protected const string PADECIMIENTO = "padecimineto";
    protected const string TEMPERATURA = "temperatura";
    protected const string PESO = "peso";
    protected const string ID_PACIENTE = "idPaciente";
    protected const string CONTROLDECELO = "controlDeCelo";
    protected const string COMENTARIOS = "comentarios";
    */
 
    public class Consulta
    {
        private int idConsulta;
        private string padecimineto;
        private string temperatura;
        private string peso;
        private int idPaciente;
        private string controldeCelo;
        private string comentarios;
        public Consulta()
        {

        }

        public Consulta(int idConsulta, string padecimineto, string temperatura, string peso, int idPaciente, string controldeCelo, string comentarios)
        {
            this.idConsulta = idConsulta;
            this.padecimineto = padecimineto;
            this.temperatura = temperatura;
            this.peso = peso;
            this.idPaciente = idPaciente;
            this.controldeCelo = controldeCelo;
            this.comentarios = comentarios; 
        }

        public int IdConsulta
        {
            get
            {
                return this.idConsulta;
            }
            set
            {
                this.idConsulta = value;
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
        public string Temperatura
        {
            get
            {
                return this.temperatura;
            }
            set
            {
                this.temperatura = value;
            }
        }
        public string Peso
        {
            get
            {
                return this.peso;
            }
            set
            {
                this.peso = value;
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
        public string ControldeCelo
        {
            get
            {
                return this.controldeCelo;
            }
            set
            {
                this.controldeCelo = value;
            }
        }
        public string Comentarios
        {
            get
            {
                return this.comentarios;
            }
            set
            {
                this.comentarios = value;
            }
        }
    }
}
