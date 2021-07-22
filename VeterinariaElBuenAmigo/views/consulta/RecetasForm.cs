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

namespace VeterinariaElBuenAmigo.views.consulta
{
    public partial class RecetasForm : Form
    {
        private RecetasDAO recetaDao;
        private List<Recetas> listaReceta;

        private string mascota;
        private int idMascota;
        private int tipo;

        public RecetasForm(string mascota, int idMascota, int tipo)
        {
            recetaDao = new RecetasDAO();

            this.tipo = tipo; 
            this.mascota = mascota;
            this.idMascota = idMascota; 

            InitializeComponent();

            if (tipo.Equals(1))
            {
                titulo.Text = "Vacunas";
                LlenartablaVacuna();
            }
            else
            {
                titulo.Text = "Vitaminas";
                LlenartablaVitamina();
                label4.Visible = false;
                txt_Dosis.Text = "a"; 
                txt_Dosis.Visible = false;
                iconButton1.Visible = false;
                iconButton2.Visible = false;

            }


        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string padecimiento = txt_Padecimineto.Text;
            string producto = txt_Producto.Text;
            string refuerzo = txt_Refuerzo.Text;
            string dosis = txt_Dosis.Text;

            bool isValidPadecimiento = ValidFields.isValidInput(padecimiento, lblErrorPadecimiento);
            bool isValidProducto = ValidFields.isValidInput(producto, lblErrorProducto);
            bool isValidRefuerzo = ValidFields.isValidInput(refuerzo, lblErrorRefuerzo);
            bool isValidDosis = ValidFields.isValidInput(dosis, lblErrorDosis);

            if (isValidPadecimiento && isValidProducto && isValidRefuerzo && isValidDosis)
            {
             
                if (tipo.Equals(1))
                {
                   
                    recetaDao.InsertarReceta(new Recetas(0, this.idMascota, this.tipo, padecimiento, producto, Convert.ToInt32(dosis), refuerzo));
                    LlenartablaVacuna();
                    LimpiarText(1);                                
                   
                }
                else
                {
                   
                    recetaDao.InsertarReceta(new Recetas(0, this.idMascota, this.tipo, padecimiento, producto, 0, refuerzo));
                    LlenartablaVitamina();
                    LimpiarText(2);
                }
               
                MessageBox.Show("Se ha registrado el control correctamente!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Dosis.Text))
            {
                txt_Dosis.Text = "0";
            }
            else
            {
                int num = Convert.ToInt32(txt_Dosis.Text);
                int sum = num + 1;
                txt_Dosis.Text = sum.ToString();
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Dosis.Text))
            {
                txt_Dosis.Text = "0";
            }
            else
            {
                int num = Convert.ToInt32(txt_Dosis.Text);
                int sum = num - 1;
                txt_Dosis.Text = sum.ToString();
            }
        }

        private void LlenartablaVacuna()
        {
            tbl_Control.Columns["id"].Visible = false;
            // tbl_Control.Columns["Column4"].Visible = false;

            tbl_Control.Rows.Clear();
            tbl_Control.Refresh();


            listaReceta = recetaDao.getList(this.tipo, this.idMascota); 


            foreach (Recetas receta in listaReceta)
            {
               
                tbl_Control.Rows.Add(receta.IdReceta, this.mascota, receta.Padecimineto, receta.NombrePReceta, receta.Dosis, receta.Refuerzo);
            }
            tbl_Control.Refresh();
        }

        private void LlenartablaVitamina()
        {
            tbl_Control.Columns["id"].Visible = false;
            tbl_Control.Columns["Column4"].Visible = false;

            tbl_Control.Rows.Clear();
            tbl_Control.Refresh();


            listaReceta = recetaDao.getList(this.tipo, this.idMascota);


            foreach (Recetas receta in listaReceta)
            {
                tbl_Control.Rows.Add(receta.IdReceta, this.mascota, receta.Padecimineto, receta.NombrePReceta, receta.Dosis, receta.Refuerzo);
            }
            tbl_Control.Refresh();
        }

        private void LimpiarText(int t)
        {
            txt_Padecimineto.Text = "";
            txt_Producto.Text = "";
            txt_Refuerzo.Text = "";

            if (t.Equals(1))
            {   
                txt_Dosis.Text = "";
                
            }
           
        }


        private void txt_Dosis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                lblErrorDosis.Text = "Ingresa solo numeros";
            }
            
            if(txt_Dosis.Text.Length > 3)
            {
                e.Handled = true;
            }
            lblErrorDosis.Text = "Obligatorio";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rows = tbl_Control.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells["ColumnSelect"].Value) == true).ToList();

            if (rows.Count > 0)
            {
                DialogResult dialogQuestion = MessageBox.Show("¿Estas seguro de que quieres eliminar los registros?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogQuestion == DialogResult.Yes)
                {

                    for (int i = 0; i < rows.Count; i++)
                    {
                        DataGridViewRow row = rows[i];

                        recetaDao.delete(Convert.ToInt32(row.Cells[0].Value));
                        if (this.tipo.Equals(1))
                        {
                            LlenartablaVacuna();
                        }
                        else
                        {
                            LlenartablaVitamina();
                        }
                    }

                }
            }
        }
    }
}
