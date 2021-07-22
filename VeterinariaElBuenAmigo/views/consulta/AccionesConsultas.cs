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
using KimToo;
using VeterinariaElBuenAmigo.Properties;
using System.Threading;
using System.Globalization;
using VeterinariaElBuenAmigo.commons;

namespace VeterinariaElBuenAmigo.views.consulta
{

    public partial class AccionesConsultas : Form
    {
        private ConsultaDAO consultaDao;
        private List<Consulta> listaConsulta;

        private RecetasDAO recetaDao;
        private List<Recetas> listaReceta;
        private int id, idConsulta_;
        private string Nombre;
        private bool isEdit;

        private DataGridView receta;
        public AccionesConsultas(int id, string Nombre)
        {
            //    Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            Guna.UI.Lib.ScrollBar.PanelScrollHelper Scroll;
            consultaDao = new ConsultaDAO();
            recetaDao = new RecetasDAO();
            receta = new DataGridView();

            receta.Columns.Add("a", "a");

            this.id = id;
            this.Nombre = Nombre;
            this.isEdit = false;
            InitializeComponent();


            Nombre_Paciente.Text = "Consulta " + Nombre;
            ActualizarTabla();




            Scroll = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(panel2, gunaVScrollBar1, true);
            Scroll.UpdateScrollBar();

            campos_padecimineto.Visible = false;
            campos_temperatura.Visible = false;
            campos_peso.Visible = false;
            campos_control.Visible = false;
            campos_comentarios.Visible = false;



        }

        private void ActualizarTabla()
        {
            tbl_ConsultasAnteriores.Columns["Column1"].Visible = false;
            tbl_ConsultasAnteriores.Rows.Clear();
            tbl_ConsultasAnteriores.Refresh();


            listaConsulta = consultaDao.getListConsulta_porIDPaciente(this.id);


            foreach (Consulta consulta in listaConsulta)
            {

                tbl_ConsultasAnteriores.Rows.Add(consulta.IdConsulta, consulta.Padecimineto, consulta.Temperatura + " °C",
                       consulta.Peso + " Lbs", consulta.ControldeCelo, consulta.Comentarios);

            }
            tbl_ConsultasAnteriores.Refresh();
        }

        private void LimpiarText()
        {
            txt_Padecimineto.Text = "";
            txt_Peso.Text = "";
            txt_Temperatura.Text = "";
            txt_controlCelo.Text = "";
            txt_Comentarios.Text = "";
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

        private void AgregarTablasImpresion(int consultas, int vacunas, int vitaminas)
        {

            if (vacunas == 1)
            {

                receta.Columns.Clear();

                receta.Columns.Add("Paciente", "Paciente");
                receta.Columns.Add("Padecimiento", "Padecimiento");
                receta.Columns.Add("Producto", "Producto");
                receta.Columns.Add("Dosis", "Dosis");
                receta.Columns.Add("Refuerzo", "Refuerzo");

                receta.Rows.Clear();
                receta.Refresh();

                listaReceta = recetaDao.getList(1, this.id);
                foreach (Recetas receta_ in listaReceta)
                {//receta_.IdReceta,
                    receta.Rows.Add(this.Nombre, receta_.Padecimineto, receta_.NombrePReceta, receta_.Dosis, receta_.Refuerzo);
                }

                easyHTMLReports1.AddLineBreak();
                easyHTMLReports1.AddLineBreak();
                easyHTMLReports1.AddString("<h2>Control de Vacunas de " + this.Nombre + "</h2>");
                easyHTMLReports1.AddHorizontalRule();
                easyHTMLReports1.AddDatagridView(receta);

            }
            else { }

            if (vitaminas == 1)
            {

                receta.Columns.Clear();

                receta.Columns.Add("Paciente", "Paciente");
                receta.Columns.Add("Padecimiento", "Padecimiento");
                receta.Columns.Add("Producto", "Producto");
                receta.Columns.Add("Refuerzo", "Refuerzo");

                receta.Rows.Clear();
                receta.Refresh();
                listaReceta = recetaDao.getList(1, this.id);


                foreach (Recetas receta_ in listaReceta)
                {//receta_.IdReceta,
                    receta.Rows.Add(this.Nombre, receta_.Padecimineto, receta_.NombrePReceta, receta_.Refuerzo);
                }
                easyHTMLReports1.AddLineBreak();
                easyHTMLReports1.AddLineBreak();
                easyHTMLReports1.AddString("<h2>Control de Vitaminas de " + this.Nombre + "</h2>");
                easyHTMLReports1.AddHorizontalRule();
                easyHTMLReports1.AddDatagridView(receta);

            }
            else { }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rows = tbl_ConsultasAnteriores.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells["ColumnSelect"].Value) == true).ToList();

            if (rows.Count > 0)
            {
                DialogResult dialogQuestion = MessageBox.Show("¿Estas seguro de que quieres eliminar los registros?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogQuestion == DialogResult.Yes)
                {

                    for (int i = 0; i < rows.Count; i++)
                    {
                        DataGridViewRow row = rows[i];

                        consultaDao.deleteConsulta(Convert.ToInt32(row.Cells[0].Value));

                        ActualizarTabla();
                    }

                }
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string padecimineto = txt_Padecimineto.Text;
            string peso = txt_Peso.Text;
            string controlCelo = txt_controlCelo.Text;
            string temperatura = txt_Temperatura.Text;
            string comentarios = txt_Comentarios.Text;

            bool isValidPadecimineto = ValidFields.isValidInput(padecimineto, campos_padecimineto);
            bool isValidPeso = ValidFields.isValidInput(peso, campos_peso);
            bool isValidControlCelo = ValidFields.isValidInput(controlCelo, campos_control);
            bool isValidTemperatura = ValidFields.isValidInput(temperatura, campos_temperatura);
            bool isValidComentarios = ValidFields.isValidInput(comentarios, campos_comentarios);


            if (isValidPadecimineto && isValidPeso && isValidControlCelo && isValidTemperatura && isValidComentarios )
            {

                if (isEdit)
                {
                    //  MessageBox.Show("bool: " + isEdit.ToString() + "idconsulta:" + idConsulta_.ToString());
                    consultaDao.EditarConsulta(new Consulta(0, padecimineto, String.Format("{0:0.00}", temperatura), String.Format("{0:0.00}", peso), this.id, controlCelo, comentarios), this.idConsulta_);
                    MessageBox.Show("Se ha cambiado la consulta correctamente", "Actualizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // this.isEdit = false; 
                }
                else
                {
                    consultaDao.InsertarConsulta(new Consulta(0, padecimineto, String.Format("{0:0.00}", temperatura), String.Format("{0:0.00}", peso), this.id, controlCelo, comentarios));
                    MessageBox.Show("Se ha registrado la consulta correctamente", "Guardado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ActualizarTabla();
                LimpiarText();

            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Temperatura.Text))
            {
                txt_Temperatura.Text = "0";
            }
            else
            {
                double num = double.Parse(txt_Temperatura.Text, System.Globalization.CultureInfo.InvariantCulture);
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

        private void iconButton5_Click(object sender, EventArgs e)
        {
            DataGridView datos;
            datos = CloneDataGrid(tbl_ConsultasAnteriores);

            int n = datos.Columns.Count;

            if (n > 6)
            {
                datos.Columns.RemoveAt(6);
            }

            //datos.Columns.RemoveAt(7);
            Image imagen = Resources.Recurso_1_0_5x;

            easyHTMLReports1.Clear();

            easyHTMLReports1.AddImage(imagen, "width = 100");
            easyHTMLReports1.AddLineBreak();
            easyHTMLReports1.AddLineBreak();
            easyHTMLReports1.AddString("<h2>Consultas de " + this.Nombre + "</h2>");
            easyHTMLReports1.AddHorizontalRule();
            easyHTMLReports1.AddDatagridView(datos);
            AgregarTablasImpresion(1, 1, 1);

            easyHTMLReports1.ShowPrintPreviewDialog();
        }

        private void btn_Vitaminas_Click(object sender, EventArgs e)
        {
            using (RecetasForm formRecetas = new RecetasForm(this.Nombre, this.id, 2))
            {

                formRecetas.ShowDialog();
            }
        }

        private void btn_Vacunas_Click(object sender, EventArgs e)
        {
            using (RecetasForm formRecetas = new RecetasForm(this.Nombre, this.id, 1))
            {

                formRecetas.ShowDialog();
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

        private void tbl_ConsultasAnteriores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tbl_ConsultasAnteriores.Columns[e.ColumnIndex].Name == "ColumnEdit")
            {
                try
                {
                    int id = Convert.ToInt32(tbl_ConsultasAnteriores.Rows[e.RowIndex].Cells[0].Value);
                    string padecimineto = tbl_ConsultasAnteriores.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string temperatura = tbl_ConsultasAnteriores.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string peso = tbl_ConsultasAnteriores.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string controlcelo = tbl_ConsultasAnteriores.Rows[e.RowIndex].Cells[4].Value.ToString();
                    string comentarios = tbl_ConsultasAnteriores.Rows[e.RowIndex].Cells[5].Value.ToString();

                    this.idConsulta_ = id;
                    this.isEdit = true;

                    MessageBox.Show("Realice los cambios necesarios en los campos de texto", "Editando", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    txt_Padecimineto.Text = padecimineto;
                    txt_Peso.Text = peso;
                    txt_Temperatura.Text = temperatura;
                    txt_controlCelo.Text = controlcelo;
                    txt_Comentarios.Text = comentarios;
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

