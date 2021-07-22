using Guna.UI.WinForms;
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
using VeterinariaElBuenAmigo.views.propietarios;

namespace VeterinariaElBuenAmigo.views
{
    public partial class FormPropietario : Form
    {
        private ClienteDAO clienteDao;
        private List<Cliente> lista;

        public FormPropietario(ClienteDAO clienteDao)
        {
            InitializeComponent();

            this.clienteDao = clienteDao;
            cargarPropietarios();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        using (FormPropietarioActions formPropietarioActions = new FormPropietarioActions(false, clienteDao)) {

            formPropietarioActions.ShowDialog();
        }

            cargarPropietarios();

        }              

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rows = dgvPropietarios.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells["ColumnSelect"].Value) == true).ToList();

            if (rows.Count > 0)
            {
                DialogResult dialogQuestion = MessageBox.Show("¿Estas seguro de que quieres eliminar los registros?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogQuestion == DialogResult.Yes)
                {
                   
                    for(int i = 0; i < rows.Count; i++ )
                    {
                        DataGridViewRow row = rows[i];

                        clienteDao.delete(Convert.ToInt32(row.Cells[0].Value));

                        cargarPropietarios();
                    }

                }
            }
        }

        private void dgvPropietarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPropietarios.Columns[e.ColumnIndex].Name == "ColumnEdit")
                {
                    int id = Convert.ToInt32(dgvPropietarios.Rows[e.RowIndex].Cells[0].Value);
                    Cliente cliente = lista.Single(c => c.IdCliente == id);

                    using (FormPropietarioActions formPropietarioActions = new FormPropietarioActions(true, clienteDao, cliente))
                    {
                        formPropietarioActions.ShowDialog();
                        cargarPropietarios();
                    }
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            
        private void cargarPropietarios()
        {
            if (dgvPropietarios.RowCount > 0)
            {
                dgvPropietarios.Rows.Clear();
                lista.Clear();
            }

            lista = clienteDao.getList();


            lblPropietarios.Text = "Numeros de propietarios: " + lista.Count;

            foreach (Cliente cliente in lista)
            {
                dgvPropietarios.Rows.Add(cliente.IdCliente, cliente.NombreCliente + " " + cliente.Apellido, cliente.Direccion, cliente.Telefono, cliente.Correo);
            }
        }

        private void dgvPropietarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int id = Convert.ToInt32(dgvPropietarios.Rows[e.RowIndex].Cells[0].Value);
                Cliente cliente = lista.Single(c => c.IdCliente == id);

                using (FormPropietarioInfo formPropietarioInfo = new FormPropietarioInfo(clienteDao, cliente))
                {
                    formPropietarioInfo.ShowDialog();
                }

            }
        }

        private void cargarPropietariosSearch(List<Cliente> listaSearch)
        {
            if (dgvPropietarios.RowCount > 0)
            {
                dgvPropietarios.Rows.Clear();
            }

            foreach (Cliente cliente in listaSearch)
            {
                dgvPropietarios.Rows.Add(cliente.IdCliente, cliente.NombreCliente + " " + cliente.Apellido, cliente.Direccion, cliente.Telefono, cliente.Correo);
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            var listaSearch = lista.Where(cliente => cliente.NombreCliente.ToLower().Contains(txtSearch.Text.ToLower()) || cliente.Apellido.ToLower().Contains(txtSearch.Text.ToLower()));

            cargarPropietariosSearch(listaSearch.ToList());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var listaSearch = lista.Where(cliente => cliente.NombreCliente.ToLower().Contains(txtSearch.Text.ToLower()));

            cargarPropietariosSearch(listaSearch.ToList());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            cargarPropietarios();
        }
    }
}
