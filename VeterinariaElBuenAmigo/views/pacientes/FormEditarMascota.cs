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
    public partial class FormEditarMascota : Form
    {
        private ClienteDAO clienteDao;
        private PacienteDAO pacienteDao;
        private List<Cliente> listaProp;
        Paciente paciente;
        public FormEditarMascota(int idMascota)
        {
            InitializeComponent();
            pacienteDao = new PacienteDAO();
            id_client.Text = idMascota.ToString();
            cargarRazas();
            cargarEspecies();
            cargarValores();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }        

        private void cargarEspecies()
        {
            List<Especie> l = new List<Especie>();
            l = pacienteDao.getListEspecie();

            especieMascota1.DataSource = l;
            especieMascota1.DisplayMember = "nombreEspecie";
            especieMascota1.ValueMember = "idEspecie";
        }

        private void cargarRazas()
        {
            List<Raza> r = new List<Raza>();
            r = pacienteDao.getListRazas();
            animales_razas1.DataSource = r;
            animales_razas1.DisplayMember = "nombreRaza";
            animales_razas1.ValueMember = "idRaza";
        }

        public void cargarValores()
        {
            Paciente p = new Paciente();
            p = pacienteDao.searchPaciente(Int32.Parse(id_client.Text));

            txtNombreMascota1.Text = p.nombrePaciente;
            fechaMascota1.Value = DateTime.Parse(p.fechaNacimiento);
            txtcolor1.Text = p.color;
            descripcionMascota1.Text = p.caracteristicasEspeciales;
            generMascota1.SelectedItem = p.genero;
            genero_de_mascota.Text = p.genero;
            especieMascota1.SelectedValue = p.idEspecie;
            especie_de_mascota.Text = p.idEspecie.ToString();
            //animales_razas1.SelectedValue = p.idRaza;
            rm.Text = p.idRaza.ToString();
        }

        private void especieMascota1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarEspecies();
            especie_de_mascota.Text = especieMascota1.SelectedValue.ToString();
        }

        private void animales_razas1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarRazas();
            rm.Text = animales_razas1.SelectedValue.ToString();
        }

        private void generMascota1_SelectedIndexChanged(object sender, EventArgs e)
        {
            genero_de_mascota.Text = generMascota1.SelectedItem.ToString();
        }

        private void btnEditMascota_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombreMascota1.Text) || String.IsNullOrEmpty(descripcionMascota1.Text)
                || String.IsNullOrEmpty(txtcolor1.Text))
            {
                MessageBox.Show("Tiene Campos Vacios", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Paciente p = new Paciente();
                p.idPaciente = Int32.Parse(id_client.Text);
                p.idRaza = Int32.Parse(rm.Text);
                p.idEspecie = Int32.Parse(especie_de_mascota.Text);
                p.color = txtcolor1.Text;
                p.nombrePaciente = txtNombreMascota1.Text;
                p.genero = genero_de_mascota.Text;
                p.caracteristicasEspeciales = descripcionMascota1.Text;
                p.fechaNacimiento = fechaMascota1.Text;

                pacienteDao.update(p);
                MessageBox.Show("Se ha editado Correctamente, saldrá de esta ventana", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            
        
        }
    }
}
