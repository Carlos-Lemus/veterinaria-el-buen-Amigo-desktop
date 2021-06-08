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
        int idCliente;        
        public FormGuardarMascota(bool isEdit, int idCliente) {            
            InitializeComponent();            
            this.idCliente = idCliente;
            idclienteActivo.Text = idCliente.ToString();
            this.pacienteDao = new PacienteDAO();
            cargarRazas();
            cargarEspecies();

            btnEditMascota.Visible = false;
            btnElminarMascota.Visible = false;
            btnInfo.Visible = false;
            
            if(isEdit)
            {                
                btnAddMascota.Visible = false;
                btnEditMascota.Visible = true;
                btnElminarMascota.Visible = true;
                btnInfo.Visible = true;
                cargarValores();
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void especieMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarEspecies();
            idEspe.Text = especieMascota.SelectedValue.ToString();
        }        

        private void generMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            gener.Text = generMascota.SelectedItem.ToString();
        }

        private void btnAddMascota_Click(object sender, EventArgs e)
        {
            this.paciente = new Paciente();
            paciente.idCliente = this.idCliente;
            paciente.idRaza = Int32.Parse(animal_raza.Text);
            paciente.idEspecie = Int32.Parse(idEspe.Text);
            paciente.color = txtcolor.Text;
            paciente.nombrePaciente = txtNombreMascota.Text;
            paciente.genero = gener.Text;
            paciente.caracteristicasEspeciales = descripcionMascota.Text;
            paciente.fechaNacimiento = fechaMascota.Text;

            pacienteDao.insert(paciente);
            this.Close();
        }

        private void cargarEspecies()
        {
            List<Especie> l = new List<Especie>();
            l = pacienteDao.getListEspecie();

            especieMascota.DataSource = l;
            especieMascota.DisplayMember = "nombreEspecie";
            especieMascota.ValueMember = "idEspecie";
        }

        private void cargarRazas()
        {
            List<Raza> r = new List<Raza>();
            r = pacienteDao.getListRazas();
            animales_razas.DataSource = r;
            animales_razas.DisplayMember = "nombreRaza";
            animales_razas.ValueMember = "idRaza";
        }

        public void cargarValores()
        {
            Paciente p = new Paciente();
            p = pacienteDao.searchPaciente(this.idCliente);

            txtNombreMascota.Text = p.nombrePaciente;
            fechaMascota.Value = DateTime.Parse(p.fechaNacimiento);
            txtcolor.Text = p.color;
            descripcionMascota.Text = p.caracteristicasEspeciales;
            generMascota.SelectedItem = p.genero;
            especieMascota.SelectedValue = p.idEspecie;
            //animales_razas.SelectedValue = p.idRaza-1;
            animal_raza.Text = p.idRaza.ToString();            
        }

        private void animales_razas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarRazas();
            animal_raza.Text = animales_razas.SelectedValue.ToString();          
        }

        private void btnEditMascota_Click(object sender, EventArgs e)
        {
            Paciente p = new Paciente();
            p.idPaciente = this.idCliente;
            p.idRaza = Int32.Parse(animal_raza.Text);
            p.idEspecie = Int32.Parse(idEspe.Text);
            p.color = txtcolor.Text;
            p.nombrePaciente = txtNombreMascota.Text;
            p.genero = gener.Text;
            p.caracteristicasEspeciales = descripcionMascota.Text;
            p.fechaNacimiento = fechaMascota.Text;

            pacienteDao.update(p);
            this.Close();
        }

        private void btnElminarMascota_Click(object sender, EventArgs e)
        {
            pacienteDao.delete(this.idCliente);
            this.Close();
        }
    }
}
