using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinariaElBuenAmigo.database;
using VeterinariaElBuenAmigo.models;

namespace VeterinariaElBuenAmigo.views.consulta
{

    public partial class AccionesConsultas : Form
    {
        private ConsultaDAO consultaDao;
        private List<Consulta> lista;

       
        public AccionesConsultas()
        {
            Guna.UI.Lib.ScrollBar.PanelScrollHelper Scroll;
            consultaDao = new ConsultaDAO();

         
            InitializeComponent();

            ActualizarTabla();




            Scroll = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(panel2, gunaVScrollBar1, true);
            Scroll.UpdateScrollBar();

            campos_padecimineto.Visible = false;
            campos_temperatura.Visible = false;
            campos_peso.Visible = false;
            campos_control.Visible = false;
            campos_comentarios.Visible = false; 
                       
           
          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (verificarVacio(txt_Padecimineto.Text) || verificarVacio(txt_Peso.Text)
                || verificarVacio(txt_Temperatura.Text) || verificarVacio(txt_controlCelo.Text)
                || verificarVacio(txt_Comentarios.Text)) {

                if (verificarVacio(txt_Padecimineto.Text)) campos_padecimineto.Visible = true;
                if (verificarVacio(txt_Temperatura.Text)) campos_temperatura.Visible = true;
                if (verificarVacio(txt_Peso.Text)) campos_peso.Visible = true;
                if (verificarVacio(txt_controlCelo.Text)) campos_control.Visible = true;
                if (verificarVacio(txt_Comentarios.Text)) campos_comentarios.Visible = true;
          
            }
            else
            {
               
                consultaDao.InsertarConsulta(new Consulta(0,txt_Padecimineto.Text, String.Format("{0:0.00}", txt_Temperatura.Text) , String.Format("{0:0.00}", txt_Peso.Text),1, txt_controlCelo.Text,txt_Comentarios.Text));
                ActualizarTabla();
                MessageBox.Show("Se ha registrado la consulta correctamente", "Guardado!",MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
                //txt_Padecimineto.Text + "\n" + txt_Peso.Text + "\n" + txt_Temperatura.Text + "\n" + txt_controlCelo.Text + "\n" + txt_Comentarios.Text
               
            }

            
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarTabla()
        {

                tbl_CitasAnteriores.Rows.Clear();
                tbl_CitasAnteriores.Refresh();
               
             
                lista = consultaDao.getListConsulta();

                foreach (Consulta consulta in lista)
                {
                    tbl_CitasAnteriores.Rows.Add(consulta.IdConsulta, consulta.Padecimineto, consulta.Temperatura+ " °C",
                        consulta.Peso+" Lbs", consulta.ControldeCelo, consulta.Comentarios);
                    
                }
            tbl_CitasAnteriores.Refresh();
        }
       
        private void iconButton1_Click(object sender, EventArgs e)
        {
            /*
             * //decimal separator will always be '.'
                a.ToString(System.Globalization.CultureInfo.InvariantCulture);
               //back to a double
                double.Parse(txt, System.Globalization.CultureInfo.InvariantCulture);
            */
            if (String.IsNullOrEmpty(txt_Temperatura.Text))
            {
                txt_Temperatura.Text = "0";
            }
            else
            {
                double num = double.Parse(txt_Temperatura.Text,System.Globalization.CultureInfo.InvariantCulture);
                double sum = num + 0.01;
                txt_Temperatura.Text = sum.ToString(System.Globalization.CultureInfo.InvariantCulture);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Temperatura.Text))
            {
                txt_Temperatura.Text = "0";
            }
            else
            {
                double num = double.Parse(txt_Temperatura.Text, System.Globalization.CultureInfo.InvariantCulture);
                double sum = num - 0.01;
                txt_Temperatura.Text = sum.ToString(System.Globalization.CultureInfo.InvariantCulture);
            }
        }

        private void txt_Temperatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == '.' && txt_Temperatura.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            campos_temperatura.Visible = false;
        }

        private void txt_Peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == '.' && txt_Peso.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            campos_peso.Visible = false; 
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Peso.Text))
            {
                txt_Peso.Text = "0";
            }
            else
            {
                double num = double.Parse(txt_Peso.Text, System.Globalization.CultureInfo.InvariantCulture);
                double sum = num + 0.01;
                txt_Peso.Text = sum.ToString(System.Globalization.CultureInfo.InvariantCulture);
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Peso.Text))
            {
                txt_Peso.Text = "0";
            }
            else
            {// 
                double num = double.Parse(txt_Peso.Text, System.Globalization.CultureInfo.InvariantCulture);
                double sum = num - 0.01;
                txt_Peso.Text = sum.ToString(System.Globalization.CultureInfo.InvariantCulture);
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private bool verificarVacio(string txt)
        {
            if (String.IsNullOrEmpty(txt))
            {
                return true; 
            }

            return false; 
        }

        private void btn_Vacunas_Click(object sender, EventArgs e)
        {

        }

        private void btn_Vitaminas_Click(object sender, EventArgs e)
        {

        }

        private void txt_Padecimineto_KeyPress(object sender, KeyPressEventArgs e)
        {
            campos_padecimineto.Visible = false;
        }

        private void txt_controlCelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            campos_control.Visible = false; 
        }

        private void txt_Comentarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            campos_comentarios.Visible = false;
        }
    }
    }
