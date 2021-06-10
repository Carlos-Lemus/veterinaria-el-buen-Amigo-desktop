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
using VeterinariaElBuenAmigo.views.consulta;
using KimToo;
using VeterinariaElBuenAmigo.Properties;

namespace VeterinariaElBuenAmigo.views
{
    public partial class FormConsulta : Form
    {
        private ConsultaDAO consultaDao;
      //  private List<Consulta> listaConsulta;

        private PacienteDAO pacienteDao;
        private List<Paciente> listaPaciente;
       
        public FormConsulta()
        {
            InitializeComponent();

            consultaDao = new ConsultaDAO();
            pacienteDao = new PacienteDAO();

            cargarMascotas();
        }

        private void btn_Acciones_Click(object sender, EventArgs e)
        {
            
        }

        private void tbl_Consulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                string id = tbl_Consulta.Rows[e.RowIndex].Cells[0].Value.ToString();
                string nombre = tbl_Consulta.Rows[e.RowIndex].Cells[1].Value.ToString();
                /* string direccion = dgvPropietarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                 string telefono = dgvPropietarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                 string correo = dgvPropietarios.Rows[e.RowIndex].Cells[4].Value.ToString();*/

                using (AccionesConsultas formAcciones = new AccionesConsultas(Convert.ToInt32(id), nombre))
                {

                    formAcciones.ShowDialog();
                }

                cargarMascotas();
            }
           
        }

        private void cargarMascotas()
        {
            
            String Especie = "", Nombre = "", Num = ""; 
            tbl_Consulta.Rows.Clear();       
            tbl_Consulta.Refresh();

            listaPaciente = pacienteDao.getList();
         //   listaConsulta = consultaDao.getListConsulta();

            foreach (Paciente paciente in listaPaciente)
            {
                Especie = consultaDao.EspecieporID(paciente.idEspecie);
                Nombre = consultaDao.NombrePropietarioporID(paciente.idCliente);
                Num = consultaDao.NumerodeConsultas(paciente.idPaciente);

                if(Nombre.Equals("No se encontró al propietario"))
                {

                }
                else
                {
                    tbl_Consulta.Rows.Add(paciente.idPaciente, paciente.nombrePaciente, Especie, Nombre, Num);
                }            
               

            }
        }

      

        private void cargarPacientesSearch(List<Paciente> listaPacientesSearch)
        {
            if (tbl_Consulta.RowCount > 0)
            {
                tbl_Consulta.Rows.Clear();
            }

            String Especie = "", Nombre = "", Num = "";

            foreach (Paciente paciente in listaPacientesSearch)
            {
                Especie = consultaDao.EspecieporID(paciente.idEspecie);
                Nombre = consultaDao.NombrePropietarioporID(paciente.idCliente);
                Num = consultaDao.NumerodeConsultas(paciente.idPaciente);

                tbl_Consulta.Rows.Add(paciente.idPaciente, paciente.nombrePaciente, Especie, Nombre, Num);
            }
        }

        private void gunaTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var listaSearch = listaPaciente.Where(paciente => paciente.nombrePaciente.ToLower().Contains(gunaTextBox1.Text.ToLower()));
            cargarPacientesSearch(listaSearch.ToList());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            gunaTextBox1.Text = "";
            cargarMascotas();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

            Image imagen = Resources.Recurso_1_0_5x;
            easyHTMLReports1.AddImage(imagen, "width = 100");

            easyHTMLReports1.AddString("<h1>Tabla Pacientes - Consulta</h1>");

            easyHTMLReports1.AddHorizontalRule();

            easyHTMLReports1.AddDatagridView(tbl_Consulta);
            easyHTMLReports1.ShowPrintPreviewDialog();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Image imagen = Resources.Recurso_1_0_5x;
            easyHTMLReports1.AddImage(imagen, "width = 100");

            easyHTMLReports1.AddString("<h1>Tabla Pacientes - Consulta</h1>");

            easyHTMLReports1.AddHorizontalRule();

            easyHTMLReports1.AddDatagridView(tbl_Consulta);
            easyHTMLReports1.ShowPrintPreviewDialog();
        }
    }
}
