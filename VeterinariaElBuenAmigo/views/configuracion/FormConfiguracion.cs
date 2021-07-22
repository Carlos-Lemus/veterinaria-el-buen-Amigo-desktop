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
using VeterinariaElBuenAmigo.views.configuracion;

namespace VeterinariaElBuenAmigo.views
{
    public partial class FormConfiguracion : Form
    {
        private List<Raza> listaRazas;
        private List<Especie> listaEspecies;
        private LoginDAO loginDAO;

        private RazaDAO razaDAO;
        private EspecieDAO especieDAO;

        public FormConfiguracion(LoginDAO loginDAO, RazaDAO razaDAO, EspecieDAO especieDAO)
        {
            InitializeComponent();

            this.loginDAO = loginDAO;
            this.razaDAO = razaDAO; 
            this.especieDAO = especieDAO;
            
            cargarRazas();
            cargarEspecies();
        }

        private void btnAddRaza_Click(object sender, EventArgs e)
        {
            using (FormRazaActions formRazaActions= new FormRazaActions(false, razaDAO, especieDAO))
            {

                formRazaActions.ShowDialog();
            }
            cargarRazas();
        }

        private void btnDeleteDelete_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rows = dvgRazas.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells["ColumnSelectRaza"].Value) == true).ToList();

            if (rows.Count > 0)
            {
                DialogResult dialogQuestion = MessageBox.Show("¿Estas seguro de que quieres eliminar los registros?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogQuestion == DialogResult.Yes)
                {

                    for (int i = 0; i < rows.Count; i++)
                    {
                        DataGridViewRow row = rows[i];

                        razaDAO.delete(Convert.ToInt32(row.Cells[0].Value));

                        cargarRazas();
                    }

                }
            }
        }

        private void btnAddEspecie_Click(object sender, EventArgs e)
        {
            using (FormEspecieActions formEspecieActions = new FormEspecieActions(false, especieDAO))
            {

                formEspecieActions.ShowDialog();
            }
            cargarEspecies();
        }

        private void btnDeleteEspecie_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rows = dvgEspecies.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells["ColumnSelectEspecie"].Value) == true).ToList();

            if (rows.Count > 0)
            {
                DialogResult dialogQuestion = MessageBox.Show("¿Estas seguro de que quieres eliminar los registros?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogQuestion == DialogResult.Yes)
                {

                    for (int i = 0; i < rows.Count; i++)
                    {
                        DataGridViewRow row = rows[i];

                        especieDAO.delete(Convert.ToInt32(row.Cells[0].Value));

                        cargarEspecies();
                    }

                }
            }
        }

        private void dvgRazas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dvgRazas.Columns[e.ColumnIndex].Name == "ColumnEditRaza")
                {
                    int id = Convert.ToInt32(dvgRazas.Rows[e.RowIndex].Cells[0].Value);

                    Raza raza = listaRazas.Single(r => r.idRaza == id);

                    using (FormRazaActions formRazaActions = new FormRazaActions(true, razaDAO, especieDAO, raza))
                    {

                        formRazaActions.ShowDialog();
                    }
                    cargarRazas();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dvgEspecies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dvgEspecies.Columns[e.ColumnIndex].Name == "ColumnEditEspecie")
                {
                    int id = Convert.ToInt32(dvgEspecies.Rows[e.RowIndex].Cells[0].Value);
                    string nombre = dvgEspecies.Rows[e.RowIndex].Cells[1].Value.ToString();

                    Especie especie = new Especie();
                    especie.idEspecie = id;
                    especie.nombreEspecie = nombre;

                    using (FormEspecieActions formEspecieActions = new FormEspecieActions(true, especieDAO, especie))
                    {

                        formEspecieActions.ShowDialog();
                    }
                    cargarEspecies();

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarRazas()
        {
            if (dvgRazas.RowCount > 0)
            {
                dvgRazas.Rows.Clear();
                listaRazas.Clear();
            }

            listaRazas = razaDAO.getList();
            
            foreach (Raza raza in listaRazas)
            {
                dvgRazas.Rows.Add(raza.idRaza, raza.nombreRaza);
            }
        }

        private void cargarEspecies()
        {
            if (dvgEspecies.RowCount > 0)
            {
                dvgEspecies.Rows.Clear();
                listaEspecies.Clear();
            }

            listaEspecies= especieDAO.getList();
            
            foreach (Especie especie in listaEspecies)
            {
                dvgEspecies.Rows.Add(especie.idEspecie, especie.nombreEspecie);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string key = txtChangeKey.Text;
            bool isValidKey = ValidFields.isValidInput(key, lblErrorClave);

            if (isValidKey)
            {

                DialogResult dialogQuestion = MessageBox.Show("¿Estas seguro de cambiar la clave de acceso?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogQuestion == DialogResult.Yes)
                {

                    Login login = loginDAO.getLogin();

                    login.password = txtChangeKey.Text;

                    loginDAO.update(login);

                    txtChangeKey.Text = "";

                }
            }
        }
    }
}
