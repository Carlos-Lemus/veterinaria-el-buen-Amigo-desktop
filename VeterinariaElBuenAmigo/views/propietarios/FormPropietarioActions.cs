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

namespace VeterinariaElBuenAmigo.views.propietarios
{
    public partial class FormPropietarioActions : Form
    {
        private ClienteDAO clienteDao;

        private int posicionFormX;
        private int posicionFormY;
        private int WindowWidth;
        private int WindowHeight;

        private Point position;
        private Size size;

        Cliente cliente;

        public FormPropietarioActions(bool isEdit, ClienteDAO clienteDao, Cliente cliente)
        {
            InitializeComponent();

            position = new Point(Location.X, Location.Y);
            size = new Size(Size.Width, Size.Height);

            this.clienteDao = clienteDao;

            btnEdit.Visible = false;

            if (isEdit)
            {
                position.X = 70;
                position.Y = 552;

                btnAdd.Visible = false;
                btnEdit.Visible = true;
                btnEdit.Location = position;

                this.cliente = cliente;

                txtNombre.Text = cliente.NombreCliente;
                txtDireccion.Text = cliente.Direccion;
                txtTelefono.Text = cliente.Telefono.ToString();
                txtCorreo.Text = cliente.Correo;
            }
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;

            bool isValidNombre = isValidInput(nombre, lblErrorNombre);
            bool isValidDireccion = isValidInput(direccion, lblErrorDireccion);
            bool isValidTelefono = isValidInput(telefono, lblErrorTelefono);

            if(isValidNombre && isValidDireccion && isValidTelefono)
            {
                clienteDao.insert(new Cliente(0, nombre, direccion, Convert.ToInt32(telefono), correo));
                this.Close();
            }  
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;

            bool isValidNombre = isValidInput(nombre, lblErrorNombre);
            bool isValidDireccion = isValidInput(direccion, lblErrorDireccion);
            bool isValidTelefono = isValidInput(telefono, lblErrorTelefono);

            if (isValidNombre && isValidDireccion && isValidTelefono)
            {
                DialogResult dialogQuestion = MessageBox.Show("¿Estas seguro de que lo quieres modificar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogQuestion == DialogResult.Yes)
                {
                    clienteDao.update(new Cliente(cliente.IdCliente, nombre, direccion, Convert.ToInt32(telefono), correo));

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

    }
}
