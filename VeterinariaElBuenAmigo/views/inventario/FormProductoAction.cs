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

namespace VeterinariaElBuenAmigo.views.inventario
{
    public partial class FormProductoAction : Form
    {
        private ProductosDAO productoDao;
        private Point position;
        private Producto producto;
        private bool isView;

        public FormProductoAction(bool isEdit, bool isView, ProductosDAO productoDao, Producto producto = null)
        {
            InitializeComponent();

            position = new Point();
            this.productoDao = productoDao;
            this.isView = isView;

            btnEdit.Visible = false;
            dtFechaAdquisicion.Value = DateTime.Now;

            if (isEdit)
            {
                position.X = 330;
                position.Y = 530;

                btnAdd.Visible = false;
                btnEdit.Visible = true;
                btnEdit.Location = position;

                this.producto = producto;

                txtNombreProducto.Text = producto.NombreProducto;
                gnExistencias.Text = producto.CantidadDisponible.ToString();
                txtTipoProducto.Text = producto.TipoProducto;
                txtMarcaProducto.Text = producto.Marca;
                txtDescripcionProducto.Text = producto.Descripcion;
                dtFechaAdquisicion.Value = DateTime.Parse(producto.FechaAdquisicion);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nombreproducto = txtNombreProducto.Text;
            string existencias = gnExistencias.Text;
            string tipoProducto = txtTipoProducto.Text;
            string marca = txtMarcaProducto.Text;
            string descripcion = txtDescripcionProducto.Text;
            string fechaAdquisicion = dtFechaAdquisicion.Value.ToString("dddd, dd MMMM yyyy");

            bool vNombreproducto = ValidFields.isValidInput(nombreproducto, lblErrorNombreProducto);
            bool vExistencia = ValidFields.isValidInput(existencias, lblErrorExistencia);
            bool vTipoProducto = ValidFields.isValidInput(tipoProducto, lblErrorTipoProducto);
            bool vMarca = ValidFields.isValidInput(marca, lblErrorMarcaProducto);
            bool vDescripcion = ValidFields.isValidInput(descripcion, lblErrorDescripcionProducto);

            if(vNombreproducto && vTipoProducto && vMarca && vDescripcion && vExistencia)
            {
                productoDao.ingresarProducto(new Producto(0, nombreproducto, Convert.ToInt32(gnExistencias.Text), tipoProducto, marca, descripcion, fechaAdquisicion));
                this.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int idProducto = producto.IdProducto;
            string nombreproducto = txtNombreProducto.Text;
            int existencias = Convert.ToInt32(gnExistencias.Text);
            string tipoProducto = txtTipoProducto.Text;
            string marca = txtMarcaProducto.Text;
            string descripcion = txtDescripcionProducto.Text;
            string fechaAdquisicion = dtFechaAdquisicion.Value.ToString("dddd, dd MMMM yyyy");

            bool vNombreproducto = ValidFields.isValidInput(nombreproducto, lblErrorNombreProducto);
            bool vTipoProducto = ValidFields.isValidInput(tipoProducto, lblErrorTipoProducto);
            bool vMarca = ValidFields.isValidInput(marca, lblErrorMarcaProducto);
            bool vDescripcion = ValidFields.isValidInput(descripcion, lblErrorDescripcionProducto);

            if (vNombreproducto && vTipoProducto && vMarca && vDescripcion)
            {
                DialogResult dialogResult = MessageBox.Show("¿Estas seguro de modificar este producto?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    productoDao.editarProducto(new Producto(idProducto, nombreproducto, existencias, tipoProducto, marca, descripcion, fechaAdquisicion));
                    this.Close();
                    if (isView)
                    {
                        Producto productoView = productoDao.getProducto(idProducto);

                        using (FormProductoInfo formProductoInfo = new FormProductoInfo(productoView))
                        {
                            this.Visible = false;
                            formProductoInfo.ShowDialog();
                        }
                    }
                }
            }
        }

        private void gnExistencias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
