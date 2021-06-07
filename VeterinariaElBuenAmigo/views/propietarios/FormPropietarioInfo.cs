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

            Guna.UI.Lib.ScrollBar.PanelScrollHelper Scroll;
            Scroll = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(panelContenido, gunaVScrollBar1, true);
            Scroll.UpdateScrollBar();

            this.dgvMascotas.Rows.Add(1, 2, 3, 4, 5);
            this.dgvMascotas.Rows.Add(1, 2, 3, 4, 5);
            this.dgvMascotas.Rows.Add(1, 2, 3, 4, 5);
            this.dgvMascotas.Rows.Add(1, 2, 3, 4, 5);
            this.dgvMascotas.Rows.Add(1, 2, 3, 4, 5);

            position = new Point(Location.X, Location.Y);
            size = new Size(Size.Width, Size.Height);

            this.clienteDao = clienteDao;

            this.id = Convert.ToInt32(id);

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
            btnMax.Visible = false;
            btnRestore.Visible = true;
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

            btnMax.Visible = true;
            btnRestore.Visible = false;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblId.Text);
            string nombreCompleto = lblNombre.Text;
            string direccion = lblDireccion.Text;
            int telefono = Convert.ToInt32(lblTelefono.Text);
            string correo = lblDireccion.Text;

            using (FormPropietarioActions formPropietarioActions = new FormPropietarioActions(true, clienteDao, new Cliente(id, nombreCompleto, direccion, telefono, correo)))
            {
                this.Visible = false;
                formPropietarioActions.ShowDialog();
            }
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogQuestion = MessageBox.Show("¿Estas seguro de que lo quieres eliminar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogQuestion == DialogResult.Yes)
            {
                clienteDao.delete(id);

                this.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //this.Parent.Parent.Visible = false;

            using (FormGuardarMascota formPropietarioActions = new FormGuardarMascota(this.id))
            {

                formPropietarioActions.ShowDialog();
            }
            
        }
    }
}
