using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinariaElBuenAmigo.commons;
using VeterinariaElBuenAmigo.database;
using VeterinariaElBuenAmigo.models;

namespace VeterinariaElBuenAmigo.views.pacientes
{
    public partial class FormEditarMascota : Form
    {
        private PacienteDAO pacienteDao;

        private int id_client;
        private string genero_de_mascota;
        private int rm;
        private int especie_de_mascota;

        public FormEditarMascota(int idMascota)
        {
            InitializeComponent();
            pacienteDao = new PacienteDAO();
            id_client = idMascota;

            
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
            p = pacienteDao.searchPaciente(id_client);

            txtNombreMascota1.Text = p.nombrePaciente;
            fechaMascota1.Value = DateTime.Parse(p.fechaNacimiento);
            txtcolor1.Text = p.color;
            descripcionMascota1.Text = p.caracteristicasEspeciales;
            generMascota1.SelectedItem = p.genero;
            genero_de_mascota = p.genero;
            especieMascota1.SelectedValue = p.idEspecie;
            especie_de_mascota = p.idEspecie;
            //animales_razas1.SelectedValue = p.idRaza;
            rm = p.idRaza;
        }

        private void especieMascota1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarEspecies();
            especie_de_mascota = Convert.ToInt32(especieMascota1.SelectedValue.ToString());
        }

        private void animales_razas1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarRazas();
            rm = Convert.ToInt32(animales_razas1.SelectedValue.ToString());
        }

        private void generMascota1_SelectedIndexChanged(object sender, EventArgs e)
        {
            genero_de_mascota = generMascota1.SelectedItem.ToString();
        }

        private void btnEditMascota_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreMascota1.Text;
            string descripcion = descripcionMascota1.Text;
            string color = txtcolor1.Text;

            bool isValidNombre = ValidFields.isValidInput(nombre, lblErrorNombre);
            bool isValidDescripcion = ValidFields.isValidInput(descripcion, lblErrorDescripcion);
            bool isValidTelefono = ValidFields.isValidInput(color, lblErrorColor);

            if (isValidNombre && isValidDescripcion && isValidTelefono)
            {
                Paciente p = new Paciente();
                p.idPaciente = id_client;
                p.idRaza = rm;
                p.idEspecie = especie_de_mascota;
                p.color = txtcolor1.Text;
                p.nombrePaciente = txtNombreMascota1.Text;
                p.genero = genero_de_mascota;
                p.caracteristicasEspeciales = descripcionMascota1.Text;
                p.fechaNacimiento = fechaMascota1.Text;

                pacienteDao.update(p);
                MessageBox.Show("Se ha editado Correctamente, saldrá de esta ventana", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }
    }
}
