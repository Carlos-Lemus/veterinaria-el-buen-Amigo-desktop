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
                MessageBox.Show("Debe ingresar la Clave", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                if (txt_Clave.Text == clave) //Aqui comprueba la clave
                {
                    using (MainForm main = new MainForm())
                    {
                        this.Hide();
                        main.ShowDialog();

                    }
                }
                else
                {
                    MessageBox.Show("Clave Incorrecta", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            evaluar();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
