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

namespace VeterinariaElBuenAmigo.views
{
    public partial class VentanaInicial : Form 
    {
       
        private string clave;
        private LoginDAO loginDAO;
        public VentanaInicial()
        {
           
            InitializeComponent();

            loginDAO = new LoginDAO();
            clave = loginDAO.getLogin().password;
        }

        private void evaluar()
        {
            if (String.IsNullOrEmpty(txt_Clave.Text))
            {
                lblError.Text = "Debe ingresar la clave";
                lblError.Visible = true;
            }
            else
            {
                lblError.Text = "La clave es incorrecta";
                lblError.Visible = false;

                if (txt_Clave.Text == clave) //Aqui comprueba la clave
                {
                    txt_Clave.Text = "";

                    using (MainForm main = new MainForm())
                    {
                        this.Visible = false;
                        main.ShowDialog();
                        this.Visible = true;
                    }
                }
                else
                {
                    lblError.Visible = true;
                }
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            evaluar();
        }

        private void txt_Clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                evaluar();
            }
        }
    }
}
