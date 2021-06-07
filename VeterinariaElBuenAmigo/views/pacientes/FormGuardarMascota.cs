using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinariaElBuenAmigo.database;
using VeterinariaElBuenAmigo.models;

namespace VeterinariaElBuenAmigo.views.pacientes
{
    public partial class FormGuardarMascota : Form
    {
        private PacienteDAO pacienteDao;      

        Paciente paciente;
        List<Especie> l;
        List<Raza> r;
        int idCliente;
        public FormGuardarMascota(int idCliente) { 
    
            InitializeComponent();
            this.idCliente = idCliente;
            idclienteActivo.Text = idCliente.ToString();
            this.pacienteDao = new PacienteDAO();

            l = new List<Especie>();
            r = new List<Raza>();
            
            
            l = pacienteDao.getListEspecie();
            r = pacienteDao.getListRazas();

            especieMascota.DataSource = l;
            especieMascota.DisplayMember = "nombreEspecie";
            especieMascota.ValueMember = "idEspecie";

            razaMascota.DataSource = r;
            razaMascota.DisplayMember = "nombreRaza";
            razaMascota.ValueMember = "idRaza";        
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void especieMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            idEspe.Text = especieMascota.SelectedValue.ToString();
        }

        private void razaMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            idraza.Text = razaMascota.SelectedValue.ToString();
        }

        private void generMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            gener.Text = generMascota.SelectedItem.ToString();
        }

        private void btnAddMascota_Click(object sender, EventArgs e)
        {
            this.paciente = new Paciente();
            paciente.idCliente = this.idCliente;
            paciente.idRaza = Int32.Parse(idraza.Text);
            paciente.idEspecie = Int32.Parse(idEspe.Text);
            paciente.color = txtcolor.Text;
            paciente.nombrePaciente = txtNombreMascota.Text;
            paciente.genero = gener.Text;
            paciente.caracteristicasEspeciales = descripcionMascota.Text;
            paciente.fechaNacimiento = fechaMascota.Text;

            pacienteDao.insert(paciente);
            this.Close();

        }
    }
}
