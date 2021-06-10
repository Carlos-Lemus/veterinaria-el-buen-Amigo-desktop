using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinariaElBuenAmigo.views;

namespace VeterinariaElBuenAmigo
{
    public partial class MainForm : Form
    {
        private Form currentForm = null;
        private IconButton btnCurrent = null;
        private Color colorPrimary = Color.FromArgb(0, 173, 181);
        private Color colorSelect = Color.FromArgb(170, 216, 211);

        private int posicionFormX;
        private int posicionFormY;
        private int WindowWidth;
        private int WindowHeight;

        private Point position;
        private Size size;

        public MainForm()
        {
            InitializeComponent();

            position = new Point(Location.X, Location.Y);
            size = new Size(Size.Width, Size.Height);

            activaButton(btnPropietario);
            openFormInPane(new FormPropietario());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            // obtengo la posicion de la ventana previo a maximizar la ventana
            posicionFormX = Location.X;
            posicionFormY = Location.Y;

            // obtengo la tamaño de la ventana previo a maximizar la ventana
            WindowWidth =  Size.Width;
            WindowHeight = Size.Height;

            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMax.Visible = false;
            btnRestore.Visible = true;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            size.Width = WindowWidth;
            size.Height = WindowHeight;
            Size = size;
            
            // devulvo a la ventana a la posicion previo a maximizar la ventana
            
            position.X = posicionFormX;
            position.Y = posicionFormY;
            
            Location = position;
            
            btnMax.Visible = true;
            btnRestore.Visible = false;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // disabledButton();

            if (panelNavegacion.Width == 270)
            {
                panelNavegacion.Visible = false;

                panelNavegacion.Width = 62;

                pbLogo.Image = Properties.Resources.logo_menu2;

                AnimacionPanelNavegacion.ShowSync(panelNavegacion);
            }
            else
            {
                panelNavegacion.Visible = false;

                panelNavegacion.Width = 270;

                pbLogo.Image = Properties.Resources.logo_menu;

                AnimacionPanelNavegacion.ShowSync(panelNavegacion);
            }
        }

        private void btnPropietario_Click(object sender, EventArgs e)
        {
            activaButton(btnPropietario);
            openFormInPane(new FormPropietario());
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            activaButton(btnPacientes);
            openFormInPane(new FormPacientes());
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            activaButton(btnCitas);
            openFormInPane(new FormCitas());
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            activaButton(btnConsulta);
            openFormInPane(new FormConsulta());
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            activaButton(btnInventario);
            openFormInPane(new FormInventario());
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            activaButton(btnConfiguracion);
            openFormInPane(new FormConfiguracion());
        }

        // cambia los estilos del button que esten en el panel de navegacion cuando se haga click en el
        private void activaButton(object senderBtn)
        {
            if (btnCurrent != null)
            {
                btnCurrent.BackColor = colorPrimary;
            }

            btnCurrent = (IconButton)senderBtn;

            btnCurrent.BackColor = colorSelect;
        }

        // abre un form dentro del panel de contenido
        private void openFormInPane(object childForm)
        {
            if (currentForm != null)
            {
                currentForm.Dispose();
            }

            if(panelContenido.Controls.Count > 0)
            {
                panelContenido.Controls.RemoveAt(0);
            }

            currentForm = childForm as Form;
            currentForm.TopLevel = false;
            currentForm.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(currentForm);
            panelContenido.Tag = currentForm;
            currentForm.Show();

        }

    }
}
