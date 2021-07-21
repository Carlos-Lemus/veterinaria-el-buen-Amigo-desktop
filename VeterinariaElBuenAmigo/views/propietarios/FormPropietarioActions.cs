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

namespace VeterinariaElBuenAmigo.views.propietarios
{
    public partial class FormPropietarioActions : Form
    {
        private ClienteDAO clienteDao;

        private Point position;

        Cliente cliente;

        public FormPropietarioActions(bool isEdit, ClienteDAO clienteDao, Cliente cliente = null)
        {
            InitializeComponent();

            position = new Point();
            
            this.clienteDao = clienteDao;

            btnEdit.Visible = false;

            if (isEdit)
            {
                position.X = 183;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;

            bool isValidNombre = ValidFields.isValidInput(nombre, lblErrorNombre);
            bool isValidDireccion = ValidFields.isValidInput(direccion, lblErrorDireccion);
            bool isValidTelefono = txtTelefono.MaskFull;

            if(!isValidTelefono)
            {
                ValidFields.isValidInput("", lblErrorTelefono);
            } else
            {
                ValidFields.isValidInput(txtTelefono.Text, lblErrorTelefono);
            }
            
            if (isValidNombre && isValidDireccion && isValidTelefono)
            {
                clienteDao.insert(new Cliente(0, nombre, direccion, telefono, correo));
                this.Close();
            }  
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;

            bool isValidNombre = ValidFields.isValidInput(nombre, lblErrorNombre);
            bool isValidDireccion = ValidFields.isValidInput(direccion, lblErrorDireccion);
            bool isValidTelefono = txtTelefono.MaskFull;

            if (!isValidTelefono)
            {
                ValidFields.isValidInput("", lblErrorTelefono);
            }
            else
            {
                ValidFields.isValidInput(txtTelefono.Text, lblErrorTelefono);
            }

            if (isValidNombre && isValidDireccion && isValidTelefono)
            {
                DialogResult dialogQuestion = MessageBox.Show("¿Estas seguro de que lo quieres modificar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogQuestion == DialogResult.Yes)
                {
                    clienteDao.update(new Cliente(cliente.IdCliente, nombre, direccion, telefono, correo));

                    this.Close();
                }
            }
            
        }

    }
}
