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
using VeterinariaElBuenAmigo.Properties;
using VeterinariaElBuenAmigo.views.citas;
using KimToo; 

namespace VeterinariaElBuenAmigo.views
{
    public partial class FormCitas : Form
    {
        private CitaDAO citaDao;
        private List<Cita> listaCitas;

        public FormCitas()
        {
            InitializeComponent();

            citaDao = new CitaDAO();
            gunaDateTimePickerCita.Value = DateTime.Now;
            cargarCitas();
        }

        private void btnAddCita_Click(object sender, EventArgs e)
        {
            using (FormCitaActions formCitasActions = new FormCitaActions(false, citaDao))
            {
                formCitasActions.ShowDialog();
            }
            cargarCitas();
        }

        private void cargarCitas()
        {
            if(dvgCitasProgramadas.RowCount > 0 || dvgCitasDelDia.RowCount > 0)
            {
                dvgCitasProgramadas.Rows.Clear();
                dvgCitasDelDia.Rows.Clear();

                listaCitas.Clear();
            }

            listaCitas = citaDao.getListaCitas();
            int countCitasDelDia = 0;
            String fechaDelDia = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            lblCitasProgramadas.Text = " Citas Programadas: " + listaCitas.Count;


            foreach (Cita cita in listaCitas)
            {

                dvgCitasProgramadas.Rows.Add(cita.IdCita, cita.NombrePaciente, cita.Fecha_cita, cita.Motivo);

                if (cita.Fecha_cita == fechaDelDia)
                {
                    dvgCitasDelDia.Rows.Add(cita.IdCita, cita.NombrePaciente, cita.Fecha_cita, cita.Motivo);
                    countCitasDelDia++;
                }
                
            }
            lblCitasDelDia.Text = " Citas del Dia: " + countCitasDelDia;
        }

        //Escucha el clic en las celdas la tabala Citas Programadas
        private void dvgCitasProgramadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dvgCitasProgramadas.Columns[e.ColumnIndex].Name == "Editar")
                {
                    int idCita = Convert.ToInt32(dvgCitasProgramadas.Rows[e.RowIndex].Cells[0].Value.ToString());
                    Cita cita = citaDao.getCita(idCita);

                    using (FormCitaActions formCitaActions = new FormCitaActions(true, citaDao, cita))
                    {
                        formCitaActions.ShowDialog();
                    }
                    cargarCitas();
                }
            }catch(Exception exception)
            {

            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rows = dvgCitasProgramadas.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells["Eliminar"].Value) == true).ToList();

            if (rows.Count > 0)
            {
                DialogResult dialogQuestion = MessageBox.Show("¿Estas seguro de que quieres eliminar lo/s producto/s?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogQuestion == DialogResult.Yes)
                {

                    for (int i = 0; i < rows.Count; i++)
                    {
                        DataGridViewRow row = rows[i];

                        citaDao.eliminarCita(Convert.ToInt32(row.Cells[0].Value));
                        cargarCitas();
                    }
                }
            }

        }

        private void cargarCitasSearch(List<Cita> listaCitasSearch)
        {
            if (dvgCitasProgramadas.RowCount > 0)
            {
                dvgCitasProgramadas.Rows.Clear();
            }

            foreach (Cita cita in listaCitasSearch)
            {
                dvgCitasProgramadas.Rows.Add(cita.IdCita, cita.NombrePaciente, cita.Fecha_cita, cita.Motivo);
            }
        }

        private void txtBuscarCita_KeyPress(object sender, KeyPressEventArgs e)
        {
            var listaSearch = listaCitas.Where(cita => cita.NombrePaciente.ToLower().Contains(txtBuscarCita.Text.ToLower()));
            cargarCitasSearch(listaSearch.ToList());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBuscarCita.Text = "";
            gunaDateTimePickerCita.Value = DateTime.Now;
            cargarCitas();
        }

        private void gunaDateTimePickerCita_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string fecha = gunaDateTimePickerCita.Value.ToString("dddd, dd MMMM yyyy");
                var listaSearch = listaCitas.Where(cita => cita.Fecha_cita.ToLower().Contains(fecha.ToLower()));
                cargarCitasSearch(listaSearch.ToList());
            }
            catch(Exception exception)
            {

            }
        }
        public DataGridView CloneDataGrid(DataGridView mainDataGridView)
        {
            DataGridView cloneDataGridView = new DataGridView();

            if (cloneDataGridView.Columns.Count == 0)
            {
                foreach (DataGridViewColumn datagrid in mainDataGridView.Columns)
                {
                    cloneDataGridView.Columns.Add(datagrid.Clone() as DataGridViewColumn);
                }
            }

            DataGridViewRow dataRow = new DataGridViewRow();

            for (int i = 0; i < mainDataGridView.Rows.Count; i++)
            {
                dataRow = (DataGridViewRow)mainDataGridView.Rows[i].Clone();
                int Index = 0;
                foreach (DataGridViewCell cell in mainDataGridView.Rows[i].Cells)
                {
                    dataRow.Cells[Index].Value = cell.Value;
                    Index++;
                }
                cloneDataGridView.Rows.Add(dataRow);
            }
            cloneDataGridView.AllowUserToAddRows = false;
            cloneDataGridView.Refresh();


            return cloneDataGridView;
        }
        private void Imprimir_Click(object sender, EventArgs e)
        {
            DataGridView datos;
            datos = CloneDataGrid(dvgCitasProgramadas);

            int n = datos.Columns.Count;
            
            if (n > 5)
            {
                //datos.Columns.RemoveAt(4);
                datos.Columns.RemoveAt(4);
               // datos.Columns.RemoveAt(6);

            }
        
            Image imagen = Resources.Recurso_1_0_5x;
            easyHTMLReports1.AddImage(imagen, "width = 100");

            easyHTMLReports1.AddString("<h1>Citas Programadas</h1>");

            easyHTMLReports1.AddHorizontalRule();

            easyHTMLReports1.AddDatagridView(datos);
            easyHTMLReports1.ShowPrintPreviewDialog();
        }
    }
}
