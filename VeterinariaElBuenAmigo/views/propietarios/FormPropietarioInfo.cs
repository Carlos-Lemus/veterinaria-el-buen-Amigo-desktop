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

        private int posicionFormX;
        private int posicionFormY;
        private int WindowWidth;
        private int WindowHeight;

        private int id;

        private Point position;
        private Size size;

        public FormPropietarioInfo(ClienteDAO clienteDao, string id, string nombreCompleto, string telefono, string direccion, string correo)
        {
            InitializeComponent();

            pacienteDao = new PacienteDAO();            

            Guna.UI.Lib.ScrollBar.PanelScrollHelper Scroll;
            Scroll = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(panelContenido, gunaVScrollBar1, true);
            Scroll.UpdateScrollBar();            

            position = new Point(Location.X, Location.Y);
            size = new Size(Size.Width, Size.Height);

            this.clienteDao = clienteDao;

            this.id = Convert.ToInt32(id);            
            cargarMascotas();

            lblId.Text = id;
            lblNombre.Text = nombreCompleto;
            lblDireccion.Text = direccion;
            lblTelefono.Text = telefono;
            lblCorreo.Text = correo;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnMax_Click(object sender, EventArgs e)
        {
            // obtengo la posicion de la ventana previo a maximizar la ventana
            posicionFormX = Location.X;
            posicionFormY = Location.Y;

            // obtengo la tamaño de la ventana previo a maximizar la ventana
            WindowWidth = Size.Width;
            WindowHeight = Size.Height;

            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            size.Width = WindowWidth;
            size.Height = WindowHeight;
            Size = size;

            // devulvo a la ventana a la posicion previo a maximizar la ventana

            position.X = posicionFormX;
            position.Y = posicionFormY;

            Location = position;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
