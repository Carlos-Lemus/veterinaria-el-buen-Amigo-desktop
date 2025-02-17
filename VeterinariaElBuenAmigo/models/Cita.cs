﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaElBuenAmigo.models
{
    public class Cita
    {
        private int idCita;
        private string fecha_cita;
        private int idPaciente;
        private string nombrePaciente;
        private string motivo;

        public Cita()
        {

        }

        public Cita(int idCita, string fecha_cita, int idPaciente, string nombrePaciente, string motivo)
        {
            this.idCita = idCita;
            this.fecha_cita = fecha_cita;
            this.idPaciente = idPaciente;
            this.nombrePaciente = nombrePaciente;
            this.motivo = motivo;
        }

        public int IdCita
        {
            get
            {
                return this.idCita;
            }
            set
            {
                this.idCita = value;
            }
        }

        public string Fecha_cita
        {
            get
            {
                return this.fecha_cita;
            }
            set
            {
                this.fecha_cita = value;
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

        public string NombrePaciente
        {
            get
            {
                return this.nombrePaciente;
            }
            set
            {
                this.nombrePaciente = value;
            }
        }

        public string Motivo
        {
            get
            {
                return this.motivo;
            }
            set
            {
                this.motivo = value;
            }
        }
    }
}

