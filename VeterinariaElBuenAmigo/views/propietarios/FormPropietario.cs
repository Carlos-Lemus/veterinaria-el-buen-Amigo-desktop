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
            cargarDatos();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Visible = false;

            using (FormPropietarioActions formPropietarioActions = new FormPropietarioActions(false, clienteDao)) {

                formPropietarioActions.ShowDialog();
            }

            cargarDatos();
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

            cargarDatos();
        }

        private void cargarDatos()
        {
            if(dgvPropietarios.RowCount > 0)
            {
                dgvPropietarios.Rows.Clear();
                lista.Clear();
            }

            lista = clienteDao.getList();


            lblPropietarios.Text = "Numeros de propietarios: " + lista.Count;

            foreach (Cliente cliente in lista)
            {
                dgvPropietarios.Rows.Add(cliente.IdCliente, cliente.NombreCliente, cliente.Telefono, cliente.Direccion, cliente.Correo);
            }
        }

    }
}
