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

namespace VeterinariaElBuenAmigo.views.configuracion
{
    public partial class FormEspecieActions : Form
    {
        private EspecieDAO especieDAO;
        private Especie especie;

        public FormEspecieActions(bool isEdit, EspecieDAO especieDAO, Especie especie = null)
        {
            InitializeComponent();

            this.especieDAO = especieDAO;

            if (isEdit)
            {
                this.especie = especie;

                btnEdit.Location = btnAdd.Location;

                btnAdd.Visible = false;
                btnEdit.Visible = true;

                txtNombre.Text = especie.nombreEspecie;

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;

            bool isValidNombre = ValidFields.isValidInput(nombre, lblErrorNombre);

            if (isValidNombre)
            {
                Especie especie = new Especie();

                especie.nombreEspecie = nombre;

                especieDAO.insert(especie);
                this.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;

            bool isValidNombre = ValidFields.isValidInput(nombre, lblErrorNombre);

            if (isValidNombre)
            {
                DialogResult dialogQuestion = MessageBox.Show("¿Estas seguro de que lo quieres modificar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogQuestion == DialogResult.Yes)
                {
                    especie.nombreEspecie = nombre;

                    especieDAO.update(especie);

                    this.Close();
                }

            }
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.btnAdd.Visible)
                {
                    btnAdd_Click(sender, e);
                }

                else if (this.btnEdit.Visible)
                {
                    btnEdit_Click(sender, e);
                }
            }
        }
    }
}
