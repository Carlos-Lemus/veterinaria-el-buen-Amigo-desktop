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
using VeterinariaElBuenAmigo.views.pacientes;

namespace VeterinariaElBuenAmigo.views
{
    public partial class FormPacientes : Form
    {
        private PacienteDAO pacienteDao;
        private List<Paciente> lista;
        private List<templateClientePaciente> listaConsulta;

        public FormPacientes(PacienteDAO pacienteDao)
        {
            InitializeComponent();

            this.pacienteDao = pacienteDao;

            cargarDatosCP();
        }        

        // CARGA ALGUNOS DATOS DE LA RELACION ENTRE CLIENTES Y PACIENTES
        private void cargarDatosCP()
        {
            if (dgvMascotas.RowCount > 0)
            {
                dgvMascotas.Rows.Clear();
                listaConsulta.Clear();
            }

            listaConsulta = pacienteDao.getListPacienteCliente();


            lblPacientes.Text = "Numeros de propietarios: " + listaConsulta.Count;

            foreach (templateClientePaciente templateCP in listaConsulta)
            {
                dgvMascotas.Rows.Add(templateCP.idPaciente, templateCP.nombrePaciente, templateCP.nombreCliente + " " + templateCP.apellidoCliente, templateCP.color, templateCP.genero);
            }
        }       

        private void btnAgregarMascota_Click_1(object sender, EventArgs e)
        {
            using (FormGuardarMascota formPropietarioActions = new FormGuardarMascota())
            {
                formPropietarioActions.ShowDialog();
            }

            cargarDatosCP();
        }

        private void dgvMascotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvMascotas.Columns[e.ColumnIndex].Name == "editarColumna")
                {
                    string id = dgvMascotas.Rows[e.RowIndex].Cells[0].Value.ToString();
                    using (FormEditarMascota form = new FormEditarMascota(Int32.Parse(id)))
                    {
                        form.ShowDialog();
                    }

                    cargarDatosCP();                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rows = dgvMascotas.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells["ColumnSelect"].Value) == true).ToList();

            if (rows.Count > 0)
            {
                DialogResult dialogQuestion = MessageBox.Show("Se eliminaran todas las citas y consultas de este paciente tambien ¿Estas seguro de eliminar el paciente?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogQuestion == DialogResult.Yes)
                {

                    for (int i = 0; i < rows.Count; i++)
                    {
                        DataGridViewRow row = rows[i];

                        pacienteDao.delete(Convert.ToInt32(row.Cells[0].Value));

                        cargarDatosCP();
                    }

                }
            }
        }

        private void cargarPacientesSearch(List<templateClientePaciente> listaSearch)
        {
            if (dgvMascotas.RowCount > 0)
            {
                dgvMascotas.Rows.Clear();
            }

            foreach (templateClientePaciente templateCP in listaSearch)
            {
                dgvMascotas.Rows.Add(templateCP.idPaciente, templateCP.nombrePaciente, templateCP.nombreCliente, templateCP.color, templateCP.genero);
            }
        }

        private void txtBuscarPaciente_TextChanged(object sender, EventArgs e)
        {
            var listaSearch = listaConsulta.Where(templateCP => templateCP.nombrePaciente.ToLower().Contains(txtBuscarPaciente.Text.ToLower()));
            cargarPacientesSearch(listaSearch.ToList());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBuscarPaciente.Text = "";
            cargarDatosCP();
        }
    }
}
