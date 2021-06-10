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

namespace VeterinariaElBuenAmigo.views.configuracion
{
    public partial class FormRazaActions : Form
    {
        private RazaDAO razaDAO;
        private Raza raza;

        public FormRazaActions(bool isEdit, RazaDAO razaDAO, Raza raza = null)
        {
            InitializeComponent();

            this.razaDAO = razaDAO;

            if (isEdit)
            {
                btnEdit.Location = btnAdd.Location;

                btnAdd.Visible = false;
                btnEdit.Visible = true;

                txtNombre.Text = raza.nombreRaza;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            
            bool isValidNombre = isValidInput(nombre, lblErrorNombre);
            
            if (isValidNombre)
            {
                Raza raza = new Raza();

                raza.nombreRaza = nombre;

                razaDAO.insert(raza);
                this.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;

            bool isValidNombre = isValidInput(nombre, lblErrorNombre);

            if (isValidNombre)
            {
                DialogResult dialogQuestion = MessageBox.Show("¿Estas seguro de que lo quieres modificar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogQuestion == DialogResult.Yes)
                {
                    raza.nombreRaza = txtNombre.Text;

                    razaDAO.update(raza);

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
