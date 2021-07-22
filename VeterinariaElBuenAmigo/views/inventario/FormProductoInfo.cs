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

namespace VeterinariaElBuenAmigo.views.inventario
{
    public partial class FormProductoInfo : Form
    {
        private Producto producto;
        private ProductosDAO productoDao;

        public FormProductoInfo(Producto producto)
        {
            this.producto = producto;
            productoDao = new ProductosDAO();

            InitializeComponent();
            txtLbIdProducto.Text = producto.IdProducto.ToString();
            txtLbNombreProducto.Text = producto.NombreProducto;
            txtLbCantidadProducto.Text = producto.CantidadDisponible.ToString();
            txtLbTipoProducto.Text = producto.TipoProducto;
            txtLbMarcaProducto.Text = producto.Marca;
            txtLbDescripcionProducto.Text = producto.Descripcion;
            txtLbFechaProducto.Text = producto.FechaAdquisicion;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (FormProductoAction formProductoAction = new FormProductoAction(true, true, productoDao, producto))
            {
                formProductoAction.ShowDialog();
                this.Close();
            }
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            DialogResult dialogQuestion = MessageBox.Show("¿Estas seguro de que quieres eliminar este producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogQuestion == DialogResult.Yes)
            {
                productoDao.eliminarProducto(producto.IdProducto);
                this.Close();
            }
        }
    }
}
