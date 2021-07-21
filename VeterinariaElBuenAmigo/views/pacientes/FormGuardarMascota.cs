using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinariaElBuenAmigo.commons;
using VeterinariaElBuenAmigo.database;
using VeterinariaElBuenAmigo.models;

namespace VeterinariaElBuenAmigo.views.pacientes
{
    public partial class FormGuardarMascota : Form
    {
        private ClienteDAO clienteDao;
        private PacienteDAO pacienteDao;
        private List<Cliente> listaProp;
        Paciente paciente;

        private int idclienteActivo;
        private int idEspe;
        private int animal_raza;
        private string gener;

        public FormGuardarMascota() {            
            InitializeComponent();

            this.clienteDao = new ClienteDAO();
            this.pacienteDao = new PacienteDAO();
            cargarDatosProp();
            cargarRazas();
            cargarEspecies();

            if (dgvDatosPropietarios.Rows.Count > 0)
            {
                //idclienteActivo.Text = idCliente.ToString();
                generMascota.SelectedItem = "Hembra";
                idclienteActivo = Convert.ToInt32(dgvDatosPropietarios.Rows[dgvDatosPropietarios.SelectedRows.Count-1].Cells[0].Value.ToString());

                fechaMascota.Value = DateTime.Now;

                txtNombreMascota.Focus();
            } else
            {
                MessageBox.Show("Debe ingresar al menos un propietario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Le asigno el metodo a Close a Load para que una vez que cargue por completo el form este se cierre
                this.Load += (s, e) => Close();

                return;
            }
        }


        private void especieMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarEspecies();
            idEspe = Convert.ToInt32(especieMascota.SelectedValue.ToString());
        }        

        private void generMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            gener = generMascota.SelectedItem.ToString();
        }

        private void btnAddMascota_Click(object sender, EventArgs e)
        {
            this.paciente = new Paciente();

            int idPropietario = Int32.Parse(dgvDatosPropietarios.Rows[dgvDatosPropietarios.CurrentRow.Index].Cells[0].Value.ToString());
            //    MessageBox.Show(null, idPropietario.ToString(), MessageBoxButtons.OK);

            string nombre = txtNombreMascota.Text;
            string descripcion = descripcionMascota.Text;
            string color = txtcolor.Text;

            bool isValidNombre = ValidFields.isValidInput(nombre, lblErrorNombre);
            bool isValidDescripcion = ValidFields.isValidInput(descripcion, lblErrorDescripcion);
            bool isValidTelefono = ValidFields.isValidInput(color, lblErrorColor);

            if (isValidNombre && isValidDescripcion && isValidTelefono)
            {
                paciente.idCliente = idPropietario;
                paciente.idRaza = animal_raza;
                paciente.idEspecie = idEspe;
                paciente.color = txtcolor.Text;
                paciente.nombrePaciente = txtNombreMascota.Text;
                paciente.genero = gener;
                paciente.caracteristicasEspeciales = descripcionMascota.Text;
                paciente.fechaNacimiento = fechaMascota.Text;

                pacienteDao.insert(paciente);
                MessageBox.Show("Se ha Guardado Correctamente, saldrá de esta ventana", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }

        private void cargarEspecies()
        {
            List<Especie> l = new List<Especie>();
            l = pacienteDao.getListEspecie();

            especieMascota.DataSource = l;
            especieMascota.DisplayMember = "nombreEspecie";
            especieMascota.ValueMember = "idEspecie";
        }

        private void cargarRazas()
        {
            List<Raza> r = new List<Raza>();
            r = pacienteDao.getListRazas();
            animales_razas.DataSource = r;
            animales_razas.DisplayMember = "nombreRaza";
            animales_razas.ValueMember = "idRaza";
        }

        private void animales_razas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarRazas();
            animal_raza = Convert.ToInt32(animales_razas.SelectedValue.ToString());          
        }

        private void cargarDatosProp()
        {
            if (dgvDatosPropietarios.RowCount > 0)
            {
                dgvDatosPropietarios.Rows.Clear();
                listaProp.Clear();
            }

            listaProp = clienteDao.getList();
           

            foreach (Cliente cliente in listaProp)
            {
                dgvDatosPropietarios.Rows.Add(cliente.IdCliente, cliente.NombreCliente);
            }
        }

        private void dgvDatosPropietarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idclienteActivo = Convert.ToInt32(dgvDatosPropietarios.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void cargarPropSearch(List<Cliente> listaPropSearch)
        {
            if (dgvDatosPropietarios.RowCount > 0)
            {
                dgvDatosPropietarios.Rows.Clear();
            }

            foreach (Cliente cliente in listaPropSearch)
            {
                dgvDatosPropietarios.Rows.Add(cliente.IdCliente, cliente.NombreCliente);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var listaSearch = listaProp.Where(prop => prop.NombreCliente.ToLower().Contains(txtSearch.Text.ToLower()));
            cargarPropSearch(listaSearch.ToList());
        }

    }
}
