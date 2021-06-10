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
using VeterinariaElBuenAmigo.views.configuracion;

namespace VeterinariaElBuenAmigo.views
{
    public partial class FormConfiguracion : Form
    {
        private List<Raza> listaRazas;
        private List<Especie> listaEspecies;

        private RazaDAO razaDAO;
        private EspecieDAO especieDAO;

        public FormConfiguracion()
        {
            InitializeComponent();

            razaDAO = new RazaDAO();
            especieDAO = new EspecieDAO();

            cargarRazas();
            cargarEspecies();
        }

        private void btnAddRaza_Click(object sender, EventArgs e)
        {
            using (FormRazaActions formRazaActions= new FormRazaActions(false, razaDAO))
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
                    string nombre = dvgRazas.Rows[e.RowIndex].Cells[1].Value.ToString();

                    Raza raza = new Raza();
                    raza.idRaza = id;
                    raza.nombreRaza = nombre;

                    using (FormRazaActions formRazaActions = new FormRazaActions(true, razaDAO, raza))
                    {

                        formRazaActions.ShowDialog();
                    }
                    cargarRazas();
                }
            }
            catch (Exception exception)
            {

            }
        }

        private void dvgEspecies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dvgRazas.Columns[e.ColumnIndex].Name == "ColumnEditRaza")
                {
                    int id = Convert.ToInt32(dvgRazas.Rows[e.RowIndex].Cells[0].Value);
                    string nombre = dvgRazas.Rows[e.RowIndex].Cells[1].Value.ToString();

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

    }
}
