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

        Cliente cliente;

        public FormPropietarioActions(bool isEdit, ClienteDAO clienteDao, Cliente cliente = null)
        {
            InitializeComponent();
            
            this.clienteDao = clienteDao;

            btnEdit.Visible = false;

            if (isEdit)
            {
                btnEdit.Location = btnAdd.Location;

                btnAdd.Visible = false;
                btnEdit.Visible = true;

                this.cliente = cliente;

                txtNombre.Text = cliente.NombreCliente;
                txtApellido.Text = cliente.Apellido;
                txtDireccion.Text = cliente.Direccion;
                txtTelefono.Text = cliente.Telefono.ToString();
                txtCorreo.Text = cliente.Correo;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;

            lblErrorTelefono.Text = "El telefono es obligatorio";

            bool isValidNombre = ValidFields.isValidInput(nombre, lblErrorNombre);
            bool isValidApellido = ValidFields.isValidInput(apellido, lblErrorApellido);
            bool isValidDireccion = ValidFields.isValidInput(direccion, lblErrorDireccion);
            bool isValidTelefono = txtTelefono.MaskFull;

            if(!isValidTelefono)
            {
                ValidFields.isValidInput("", lblErrorTelefono);
            } else
            {
                ValidFields.isValidInput(txtTelefono.Text, lblErrorTelefono);
            }
            
            if (isValidNombre && isValidApellido && isValidDireccion && isValidTelefono && isValidTelefonoAndCorreo(telefono, correo))
            {
                clienteDao.insert(new Cliente(0, nombre, apellido, direccion, telefono, correo));
                this.Close();

            }  
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;

            bool isValidNombre = ValidFields.isValidInput(nombre, lblErrorNombre);
            bool isValidApellido = ValidFields.isValidInput(apellido, lblErrorApellido);
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

            if (isValidNombre && isValidApellido && isValidDireccion && isValidTelefono)
            {
                DialogResult dialogQuestion = MessageBox.Show("¿Estas seguro de que lo quieres modificar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogQuestion == DialogResult.Yes)
                {
                    clienteDao.update(new Cliente(cliente.IdCliente, nombre, apellido, direccion, telefono, correo));

                    this.Close();
                }
            }
            
        }

        private bool isValidTelefonoAndCorreo(string telefono, string correo)
        {

            bool isExistTelefono = clienteDao.searchCliente("telefono", telefono);
            bool isExistCorreo = clienteDao.searchCliente("correo", correo);

            if (isExistTelefono || (isExistCorreo && !string.IsNullOrEmpty(correo)))
            {
                if (isExistTelefono)
                {
                    lblErrorTelefono.Visible = true;
                    lblErrorTelefono.Text = "El telefono ya existe";
                }

                if (isExistCorreo && !string.IsNullOrEmpty(correo))
                {
                    lblErrorCorreo.Visible = true;
                }

                return false;
            }

            return true;

        }

    }
}
