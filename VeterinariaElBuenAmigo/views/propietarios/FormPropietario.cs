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

        public FormPropietario()
        {
            InitializeComponent();

            clienteDao = new ClienteDAO();
            cargarPropietarios();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Visible = false;

            using (FormPropietarioActions formPropietarioActions = new FormPropietarioActions(false, clienteDao)) {

                formPropietarioActions.ShowDialog();
            }

            cargarPropietarios();
            this.Parent.Parent.Visible = true;

        }

        private void dgvPropietarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblPropietarios.Text = "Index: " + e.RowIndex;
            string id = dgvPropietarios.Rows[e.RowIndex].Cells[0].Value.ToString();
            string nombreCompleto = dgvPropietarios.Rows[e.RowIndex].Cells[1].Value.ToString();
            string direccion = dgvPropietarios.Rows[e.RowIndex].Cells[2].Value.ToString();
            string telefono = dgvPropietarios.Rows[e.RowIndex].Cells[3].Value.ToString();
            string correo = dgvPropietarios.Rows[e.RowIndex].Cells[4].Value.ToString();

            using (FormPropietarioInfo formPropietarioInfo = new FormPropietarioInfo(clienteDao, id, nombreCompleto, direccion, telefono, correo))
            {

                formPropietarioInfo.ShowDialog();
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
                    MessageBox.Show(rows.Count.ToString());
                    
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

            if (dgvPropietarios.Columns[e.ColumnIndex].Name == "ColumnEdit")
            {
                int id = Convert.ToInt32(dgvPropietarios.Rows[e.RowIndex].Cells[0].Value);
                string nombreCompleto = dgvPropietarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                string direccion = dgvPropietarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                int telefono = Convert.ToInt32(dgvPropietarios.Rows[e.RowIndex].Cells[3].Value);
                string correo = dgvPropietarios.Rows[e.RowIndex].Cells[4].Value.ToString();

                using (FormPropietarioActions formPropietarioActions = new FormPropietarioActions(true, clienteDao, new Cliente(id, nombreCompleto, direccion, telefono, correo)))
                {
                    formPropietarioActions.ShowDialog();

                }

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
                dgvPropietarios.Rows.Add(cliente.IdCliente, cliente.NombreCliente, cliente.Direccion, cliente.Telefono, cliente.Correo);
            }
        }

    }
}
