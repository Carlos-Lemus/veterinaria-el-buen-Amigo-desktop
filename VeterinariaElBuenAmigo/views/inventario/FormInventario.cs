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
using VeterinariaElBuenAmigo.views.inventario;

namespace VeterinariaElBuenAmigo.views
{
    public partial class FormInventario : Form
    {
        private ProductosDAO productoDao;
        private List<Producto> listaProductos;

        public FormInventario()
        {
            InitializeComponent();

            productoDao = new ProductosDAO();
            cargarProductos();
        }

        private void btnAddProducto_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Visible = false;
            using(FormProductoAction formProductoAction = new FormProductoAction(false, false, productoDao))
            {
                formProductoAction.ShowDialog();
            }
            cargarProductos();
            this.Parent.Parent.Visible = true;
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
                        this.Visible = false;
                        formProductoAction.ShowDialog();
                    }
                    this.Visible = true;
                }

                if (this.dgvInventario.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    DialogResult dialogQuestion = MessageBox.Show("¿Estas seguro de que quieres eliminar este producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogQuestion == DialogResult.Yes)
                    {
                        productoDao.eliminarProducto(idProducto);
                    }
                }

            }catch(Exception exception)
            {
                //MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cargarProductos();
        }

        private void dgvInventario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idProducto = Convert.ToInt32(dgvInventario.Rows[e.RowIndex].Cells[0].Value.ToString());
                Producto productoView = productoDao.getProducto(idProducto);

                using (FormProductoInfo formProductoInfo = new FormProductoInfo(productoView))
                {
                    this.Visible = false;
                    formProductoInfo.ShowDialog();
                }
                cargarProductos();
                this.Visible = true;
            }
            catch(Exception exception)
            {

            }
        }
    }
}
