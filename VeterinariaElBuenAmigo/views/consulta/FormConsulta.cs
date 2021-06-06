using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinariaElBuenAmigo.views.consulta;

namespace VeterinariaElBuenAmigo.views
{
    public partial class FormConsulta : Form
    {
        public FormConsulta()
        {
            InitializeComponent();
        }

        private void btn_Acciones_Click(object sender, EventArgs e)
        {
            Form f = new AccionesConsultas();
            //f.ShowDialog(this);
            f.ShowDialog();
        }
    }
}
