﻿using System;
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
using VeterinariaElBuenAmigo.Properties;
using VeterinariaElBuenAmigo.views.inventario;

namespace VeterinariaElBuenAmigo.views
{
    public partial class FormInventario : Form
    {
        private ProductosDAO productoDao;
        private List<Producto> listaProductos;

        public FormInventario(ProductosDAO productoDao)
        {
            InitializeComponent();

            this.productoDao = productoDao;

            cargarProductos();
        }

        private void btnAddProducto_Click(object sender, EventArgs e)
        {
            using(FormProductoAction formProductoAction = new FormProductoAction(false, false, productoDao))
            {
                formProductoAction.ShowDialog();
            }
            cargarProductos();
        }

        private void cargarProductos()
        {
            if(dgvInventario.RowCount > 0)
            {
                dgvInventario.Rows.Clear();
                listaProductos.Clear();
            }

            listaProductos = productoDao.getListaProductos();
            foreach(Producto producto in listaProductos)
            {
                dgvInventario.Rows.Add(producto.IdProducto, producto.NombreProducto, producto.CantidadDisponible, producto.TipoProducto);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rows = dgvInventario.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells["Eliminar"].Value) == true).ToList();

            if(rows.Count > 0)
            {
                DialogResult dialogQuestion = MessageBox.Show("¿Estas seguro de que quieres eliminar lo/s producto/s?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogQuestion == DialogResult.Yes)
                {

                    for (int i = 0; i < rows.Count; i++)
                    {
                        DataGridViewRow row = rows[i];

                        productoDao.eliminarProducto(Convert.ToInt32(row.Cells[0].Value));
                        cargarProductos();
                    }
                }
            }
        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idProducto = Convert.ToInt32(dgvInventario.Rows[e.RowIndex].Cells[0].Value.ToString());

                if (this.dgvInventario.Columns[e.ColumnIndex].Name == "Editar")
                {
                    Producto productoEdit = productoDao.getProducto(idProducto);

                    using (FormProductoAction formProductoAction = new FormProductoAction(true, false, productoDao, productoEdit))
                    {
                        formProductoAction.ShowDialog();
                    }
                    cargarProductos();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvInventario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idProducto = Convert.ToInt32(dgvInventario.Rows[e.RowIndex].Cells[0].Value.ToString());
                Producto productoView = productoDao.getProducto(idProducto);

                using (FormProductoInfo formProductoInfo = new FormProductoInfo(productoView))
                {
                    formProductoInfo.ShowDialog();
                }
                cargarProductos();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarProductosSearch(List<Producto> listaProductosSearch)
        {
            if(dgvInventario.RowCount > 0)
            {
                dgvInventario.Rows.Clear();
            }

            foreach (Producto producto in listaProductosSearch)
            {
                dgvInventario.Rows.Add(producto.IdProducto, producto.NombreProducto, producto.CantidadDisponible, producto.TipoProducto);
            }
        }

        private void txtBuscarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            var listaSearch = listaProductos.Where(producto => producto.NombreProducto.ToLower().Contains(txtBuscarProducto.Text.ToLower()));
            cargarProductosSearch(listaSearch.ToList());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBuscarProducto.Text = "";
            cargarProductos();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            DataGridView datos;
            datos = CloneDataGrid(dgvInventario);

            int n = datos.Columns.Count;
            
            if (n > 5)
            {
                //datos.Columns.RemoveAt(4);
                datos.Columns.RemoveAt(4);
                // datos.Columns.RemoveAt(6);

            }
            
            Image imagen = Resources.Recurso_1_0_5x;
            easyHTMLReports1.AddImage(imagen, "width = 100");

            easyHTMLReports1.AddString("<h1>Inventario</h1>");

            easyHTMLReports1.AddHorizontalRule();

            easyHTMLReports1.AddDatagridView(datos);
            easyHTMLReports1.ShowPrintPreviewDialog();
        }
        public DataGridView CloneDataGrid(DataGridView mainDataGridView)
        {
            DataGridView cloneDataGridView = new DataGridView();

            if (cloneDataGridView.Columns.Count == 0)
            {
                foreach (DataGridViewColumn datagrid in mainDataGridView.Columns)
                {
                    cloneDataGridView.Columns.Add(datagrid.Clone() as DataGridViewColumn);
                }
            }

            DataGridViewRow dataRow = new DataGridViewRow();

            for (int i = 0; i < mainDataGridView.Rows.Count; i++)
            {
                dataRow = (DataGridViewRow)mainDataGridView.Rows[i].Clone();
                int Index = 0;
                foreach (DataGridViewCell cell in mainDataGridView.Rows[i].Cells)
                {
                    dataRow.Cells[Index].Value = cell.Value;
                    Index++;
                }
                cloneDataGridView.Rows.Add(dataRow);
            }
            cloneDataGridView.AllowUserToAddRows = false;
            cloneDataGridView.Refresh();


            return cloneDataGridView;
        }
    }
}
