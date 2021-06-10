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

namespace VeterinariaElBuenAmigo.views.consulta
{
    public partial class RecetasForm : Form
    {
        private RecetasDAO recetaDao;
        private List<Recetas> listaReceta;

        private string mascota;
        private int idMascota;
        private int tipo;
        private int idReceta; 
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


            if (verificarVacio(txt_Padecimineto.Text) || verificarVacio(txt_Producto.Text) 
                || verificarVacio(txt_Refuerzo.Text) || verificarVacio(txt_Dosis.Text))
            {
                MessageBox.Show("No puede dejar Campos Vacios", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            
            }
            else
            {
                if (tipo.Equals(1))
                {
                   
                        recetaDao.InsertarReceta(new Recetas(0, this.idMascota, this.tipo, txt_Padecimineto.Text, txt_Producto.Text, Convert.ToInt32(txt_Dosis.Text), txt_Refuerzo.Text));
                        MessageBox.Show("Se ha registrado el control correctamente!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LlenartablaVacuna();
                        LimpiarText(1);                                
                   
                }
                else
                {
                   
                    recetaDao.InsertarReceta(new Recetas(0, this.idMascota, this.tipo, txt_Padecimineto.Text, txt_Producto.Text, 0, txt_Refuerzo.Text));
                    MessageBox.Show("Se ha registrado el control correctamente!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenartablaVitamina();
                    LimpiarText(2);
                }
               
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void LimpiarText(int t)
        {
            if (t.Equals(1))
            {
                txt_Padecimineto.Text = "";
                txt_Dosis.Text = "";
                txt_Producto.Text = "";
                txt_Refuerzo.Text = "";
            }
            else
            {
                txt_Padecimineto.Text = "";              
                txt_Producto.Text = "";
                txt_Refuerzo.Text = "";
            }
           
        }

        private bool verificarVacio(string txt)
        {
            if (String.IsNullOrEmpty(txt))
            {
                return true;
            }

            return false;
        }

        private void txt_Dosis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números enteros", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            if(txt_Dosis.Text.Length > 3)
            {
                e.Handled = true;
            }

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
