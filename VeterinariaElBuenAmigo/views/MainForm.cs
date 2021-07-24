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
using VeterinariaElBuenAmigo.database;
using VeterinariaElBuenAmigo.views;

namespace VeterinariaElBuenAmigo
{
    public partial class MainForm : Form
    {
        private Form currentForm = null;
        private IconButton btnCurrent = null;
        private Color colorPrimary = Color.FromArgb(0, 173, 181);
        private Color colorSelect = Color.FromArgb(170, 216, 211);

        // Class DAOs
        private ClienteDAO clienteDao;
        private PacienteDAO pacienteDao;
        private CitaDAO citaDao;
        private ConsultaDAO consultaDao;
        private ProductosDAO productoDao;
        private RazaDAO razaDAO;
        private EspecieDAO especieDAO;
        private LoginDAO loginDAO;

        private bool isSignOut = false;

        public MainForm()
        {
            InitializeComponent();

            activaButton(btnPropietario);

            InitDAOs();

            openFormInPane(new FormPropietario(clienteDao));

            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void InitDAOs()
        {
            clienteDao = new ClienteDAO();
            pacienteDao = new PacienteDAO();
            citaDao = new CitaDAO();
            consultaDao = new ConsultaDAO();
            productoDao = new ProductosDAO();
            razaDAO = new RazaDAO();
            especieDAO = new EspecieDAO();
            loginDAO = new LoginDAO();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!isSignOut)
            {
                Application.Exit();
            }

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
            openFormInPane(new FormPropietario(clienteDao));
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            activaButton(btnPacientes);
            openFormInPane(new FormPacientes(pacienteDao));
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            activaButton(btnCitas);
            openFormInPane(new FormCitas(citaDao));
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            activaButton(btnConsulta);
            openFormInPane(new FormConsulta(consultaDao, pacienteDao));
        }                                   

        private void btnInventario_Click(object sender, EventArgs e)
        {
            activaButton(btnInventario);
            openFormInPane(new FormInventario(productoDao));
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            activaButton(btnConfiguracion);
            openFormInPane(new FormConfiguracion(loginDAO, razaDAO, especieDAO));
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

        private void btnSingOut_Click(object sender, EventArgs e)
        {
            isSignOut = true;
            this.Close();
        }

    }
}
