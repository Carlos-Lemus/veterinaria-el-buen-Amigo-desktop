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
using VeterinariaElBuenAmigo.views.citas;

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
            cargarCitas();
        }

        private void btnAddCita_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Visible = false;

            using (FormCitaActions formCitasActions = new FormCitaActions(false, citaDao))
            {
                formCitasActions.ShowDialog();
            }

            cargarCitas();
            this.Parent.Parent.Visible = true;
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

                dvgCitasProgramadas.Rows.Add(cita.IdCita, cita.IdPaciente.ToString(), cita.Fecha_cita, cita.Motivo);

                if (cita.Fecha_cita == fechaDelDia)
                {
                    dvgCitasDelDia.Rows.Add(cita.IdCita, cita.IdPaciente.ToString(), cita.Fecha_cita, cita.Motivo);
                    countCitasDelDia++;
                }
                
            }
            lblCitasDelDia.Text = " Citas del Dia: " + countCitasDelDia;
        }



        private void dvgCitasProgramadas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        //Escucha el clic en las celdas la tabala Citas Programadas
        private void dvgCitasProgramadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idCita = Convert.ToInt32(dvgCitasProgramadas.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (this.dvgCitasProgramadas.Columns[e.ColumnIndex].Name == "Editar")
                {
                    int idPaciente = Convert.ToInt32(dvgCitasProgramadas.Rows[e.RowIndex].Cells[1].Value.ToString());
                    string fechaCita = dvgCitasProgramadas.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string motivo = dvgCitasProgramadas.Rows[e.RowIndex].Cells[3].Value.ToString();

                    using (FormCitaActions formCitaActions = new FormCitaActions(true, citaDao, new Cita(idCita, fechaCita, idPaciente, motivo)))
                    {
                        this.Visible = false;
                        formCitaActions.ShowDialog();
                    }
                    cargarCitas();
                    this.Visible = true;
                }

                if (this.dvgCitasProgramadas.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    DialogResult dialogQuestion = MessageBox.Show("¿Estas seguro de que quieres eliminar esta Cita?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogQuestion == DialogResult.Yes)
                    {
                        citaDao.eliminarCita(idCita);
                        cargarCitas();
                    }
                }
            }
            catch(Exception exception)
            {
                //MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
