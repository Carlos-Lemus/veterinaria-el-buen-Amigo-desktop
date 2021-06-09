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

namespace VeterinariaElBuenAmigo.views.citas
{
    public partial class FormCitaActions : Form
    {
        private CitaDAO citaDao;
        private Point position;
        Cita cita;

        public FormCitaActions(bool isEdit, CitaDAO citaDao, Cita cita = null)
        {
            InitializeComponent();

            position = new Point();
            this.citaDao = citaDao;

            btnEdit.Visible = false;

            if (isEdit)
            {
                position.X = 70;
                position.Y = 552;

                btnAdd.Visible = false;
                btnEdit.Visible = true;
                btnEdit.Location = position;

                this.cita = cita;

                gunaDateTimePickerCita.Value = DateTime.Parse(cita.Fecha_cita);
                txtPaciente.Text = cita.IdPaciente.ToString();
                txtMotivo.Text = cita.Motivo;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fecha = gunaDateTimePickerCita.Value.ToString("dddd, dd MMMM yyyy");
            string paciente = txtPaciente.Text;
            string motivo = txtMotivo.Text;

            bool isValidFecha = isValidInput(fecha.ToString(), lblErrorFecha);
            bool isValidPaciente = isValidInput(paciente, lblErrorPaciente);
            bool isValidMotivo = isValidInput(motivo, lblErrorMotivo);

            if(isValidFecha && isValidPaciente && isValidMotivo)
            {
                citaDao.ingresarCita(new Cita(0, fecha, Convert.ToInt32(paciente), motivo));
                this.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int idCita = cita.IdCita;
            string fecha = gunaDateTimePickerCita.Value.ToString("dddd, dd MMMM yyyy");
            string paciente = txtPaciente.Text;
            string motivo = txtMotivo.Text;

            bool isValidFecha = isValidInput(fecha.ToString(), lblErrorFecha);
            bool isValidPaciente = isValidInput(paciente, lblErrorPaciente);
            bool isValidMotivo = isValidInput(motivo, lblErrorMotivo);


            if (isValidFecha && isValidPaciente && isValidMotivo)
            {
                DialogResult dialogResult = MessageBox.Show("¿Estas seguro de modificar la cita?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(dialogResult == DialogResult.Yes)
                {
                    citaDao.editarCita(new Cita(idCita, fecha, Convert.ToInt32(paciente), motivo));
                    this.Close();
                }
            }
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
