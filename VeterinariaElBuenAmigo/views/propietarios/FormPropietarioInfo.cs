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

namespace VeterinariaElBuenAmigo.views.propietarios
{
    public partial class FormPropietarioInfo : Form
    {
        private ClienteDAO clienteDao;
        private PacienteDAO pacienteDao;        

        private int id;

        public FormPropietarioInfo(ClienteDAO clienteDao, Cliente cliente)
        {
            InitializeComponent();

            pacienteDao = new PacienteDAO();            

            Guna.UI.Lib.ScrollBar.PanelScrollHelper Scroll;
            Scroll = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(panelContenido, gunaVScrollBar1, true);
            Scroll.UpdateScrollBar();            

            this.clienteDao = clienteDao;

            this.id = Convert.ToInt32(id);            
            cargarMascotas();

            lblId.Text = cliente.IdCliente.ToString();
            lblNombre.Text = cliente.NombreCliente;
            lblApellido.Text = cliente.Apellido;
            lblDireccion.Text = cliente.Direccion;
            lblTelefono.Text = cliente.Telefono;
            lblCorreo.Text = cliente.Correo;
        }

        private void cargarMascotas()
        {
            List<templateClientePaciente> lista = new List<templateClientePaciente>();
            if (dgvMascotas1.RowCount > 0)
            {
                dgvMascotas1.Rows.Clear();
                lista.Clear();
            }

            lista = pacienteDao.getListMascotasDePropietario(this.id);

            foreach (templateClientePaciente consulta in lista)
            {
                dgvMascotas1.Rows.Add(consulta.idPaciente, consulta.nombrePaciente, consulta.nombreRaza, consulta.nombreEspecie, consulta.genero);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FormGuardarMascota formPropietarioActions = new FormGuardarMascota())
            {

                formPropietarioActions.ShowDialog();
            }
        }
    }
}
