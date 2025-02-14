﻿using System;
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

namespace VeterinariaElBuenAmigo.views.citas
{
    public partial class FormCitaActions : Form
    {
        private CitaDAO citaDao;
        private PacienteDAO pacienteDao;
        private Cita cita;
        private List<Paciente> listaPacientes;

        public FormCitaActions(bool isEdit, CitaDAO citaDao, Cita cita = null)
        {
            InitializeComponent();

            this.citaDao = citaDao;            
            this.pacienteDao = new PacienteDAO();
            cargarPacientes();

            if(listaPacientes.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un paciente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Le asigno el metodo a Close a Load para que una vez que cargue por completo el form este se cierre
                this.Load += (s, e) => Close();
            }

            btnEdit.Visible = false;
            gunaDateTimePickerCita.Value = DateTime.Now;

            if (isEdit)
            {
                btnAdd.Visible = false;
                btnEdit.Visible = true;
                btnEdit.Location = btnAdd.Location;

                this.cita = cita;

                gunaDateTimePickerCita.Value = DateTime.Parse(cita.Fecha_cita);              
                txtMotivo.Text = cita.Motivo;
                mascotas_collection.SelectedValue = cita.IdPaciente;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fecha = gunaDateTimePickerCita.Value.ToString("dddd, dd MMMM yyyy");           
            string motivo = txtMotivo.Text;
            int idPasiente = Convert.ToInt32(mascotas_collection.SelectedValue.ToString());

            bool isValidFecha = isValidInput(fecha.ToString(), lblErrorFecha); 
            bool isValidMotivo = isValidInput(motivo, lblErrorMotivo);

            if(isValidFecha && isValidMotivo)
            {
                citaDao.ingresarCita(new Cita(0, fecha, idPasiente, "", motivo));
                this.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int idCita = cita.IdCita;
            string fecha = gunaDateTimePickerCita.Value.ToString("dddd, dd MMMM yyyy");
            int idPasiente = Convert.ToInt32(mascotas_collection.SelectedValue.ToString());
            string motivo = txtMotivo.Text;

            bool isValidFecha = isValidInput(fecha.ToString(), lblErrorFecha);            
            bool isValidMotivo = isValidInput(motivo, lblErrorMotivo);

            if (isValidFecha && isValidMotivo)
            {
                DialogResult dialogResult = MessageBox.Show("¿Estas seguro de modificar la cita?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(dialogResult == DialogResult.Yes)
                {
                    citaDao.editarCita(new Cita(idCita, fecha, idPasiente, "", motivo));
                    this.Close();
                }
            }
        }

        private void cargarPacientes()
        {
            if(mascotas_collection.Items.Count > 0)
            {
                mascotas_collection.Items.Clear();
                listaPacientes.Clear();
            }

            listaPacientes = pacienteDao.getList();

            mascotas_collection.DataSource = listaPacientes;
            mascotas_collection.DisplayMember = "nombrePaciente";
            mascotas_collection.ValueMember = "idPaciente";
        }

        private bool isValidInput(String txtInput, Label lblMessageError)
        {
            lblMessageError.Visible = false;

            if (String.IsNullOrEmpty(txtInput))
            {
                lblMessageError.Visible = true;

                return false;
            }
            return true;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            int index = mascotas_collection.FindString(txtBuscar.Text);

            if (index != -1)
            {
                mascotas_collection.SelectedIndex = index;
            }
            else
            {
                mascotas_collection.SelectedIndex = 0;
            }
        }
    }
}
