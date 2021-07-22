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
    public partial class FormRazaActions : Form
    {
        private RazaDAO razaDAO;
        private Raza raza;
        private EspecieDAO especieDAO;
        private int idEspe;

        public FormRazaActions(bool isEdit, RazaDAO razaDAO, EspecieDAO especieDAO, Raza raza = null)
        {
            InitializeComponent();

            this.razaDAO = razaDAO;
            this.especieDAO = especieDAO;

            llenarEspecie();

            if (isEdit)
            {
                this.raza = raza;

                btnEdit.Location = btnAdd.Location;

                btnAdd.Visible = false;
                btnEdit.Visible = true;

                txtNombre.Text = raza.nombreRaza;

            }
        }

        private void llenarEspecie()
        {
            List<Especie> l = especieDAO.getList();

            especieMascota.DataSource = l;
            especieMascota.DisplayMember = "nombreEspecie";
            especieMascota.ValueMember = "idEspecie";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            bool isValidNombre = ValidFields.isValidInput(nombre, lblErrorNombre);

            if (isValidNombre)
            {
                Raza raza = new Raza();

                raza.nombreRaza = nombre;
                raza.idEspecie = idEspe;

                razaDAO.insert(raza);
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
                    raza.nombreRaza = nombre;

                    razaDAO.update(raza);

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

        private void especieMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarEspecie();
            idEspe = Convert.ToInt32(especieMascota.SelectedValue.ToString());
        }

        private void especieMascota_KeyDown(object sender, KeyEventArgs e)
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
