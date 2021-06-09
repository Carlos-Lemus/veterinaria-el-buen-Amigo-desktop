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

        public FormPacientes()
        {
            InitializeComponent();
            pacienteDao = new PacienteDAO();
            cargarDatosCP();
        }

        private void dgvMascotas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblPacientes.Text = "Index: " + e.RowIndex;
            string id = dgvMascotas.Rows[e.RowIndex].Cells[0].Value.ToString();

            using (FormGuardarMascota formPropietarioInfo = new FormGuardarMascota(true, Int32.Parse(id)))
            {

                formPropietarioInfo.ShowDialog();
            }

            cargarDatosCP();
        }

        //CARGA ALGUNOS DATOS DE LA TABLA PACIENTES
        private void cargarDatos()
        {
            if (dgvMascotas.RowCount > 0)
            {
                dgvMascotas.Rows.Clear();
                lista.Clear();
            }

            lista = pacienteDao.getList();


            lblPacientes.Text = "Numeros de propietarios: " + lista.Count;

            foreach (Paciente paciente in lista)
            {
                dgvMascotas.Rows.Add(paciente.idPaciente, paciente.nombrePaciente, paciente.color, paciente.genero);
            }
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
                dgvMascotas.Rows.Add(templateCP.idPaciente, templateCP.nombrePaciente, templateCP.nombreCliente ,templateCP.color, templateCP.genero);
            }
        }
    }
}
