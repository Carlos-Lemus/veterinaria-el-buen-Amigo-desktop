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

namespace VeterinariaElBuenAmigo.views.pacientes
{
    public partial class FormGuardarMascota : Form
    {
        private ClienteDAO clienteDao;
        private PacienteDAO pacienteDao;
        private List<Cliente> listaProp;
        Paciente paciente;                  
        public FormGuardarMascota() {            
            InitializeComponent();                        
            //idclienteActivo.Text = idCliente.ToString();
            this.clienteDao = new ClienteDAO();
            this.pacienteDao = new PacienteDAO();
            cargarDatosProp();
            cargarRazas();
            cargarEspecies();
            generMascota.SelectedItem = "Hembra";
            idclienteActivo.Text = dgvDatosPropietarios.Rows[dgvDatosPropietarios.SelectedRows.Count].Cells[0].Value.ToString();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void especieMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarEspecies();
            idEspe.Text = especieMascota.SelectedValue.ToString();
        }        

        private void generMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            gener.Text = generMascota.SelectedItem.ToString();
        }

        private void btnAddMascota_Click(object sender, EventArgs e)
        {
            this.paciente = new Paciente();

            int idPropietario = Int32.Parse(dgvDatosPropietarios.Rows[dgvDatosPropietarios.CurrentRow.Index].Cells[0].Value.ToString());
            MessageBox.Show(null, idPropietario.ToString(), MessageBoxButtons.OK);

            paciente.idCliente = idPropietario;
            paciente.idRaza = Int32.Parse(animal_raza.Text);
            paciente.idEspecie = Int32.Parse(idEspe.Text);
            paciente.color = txtcolor.Text;
            paciente.nombrePaciente = txtNombreMascota.Text;
            paciente.genero = gener.Text;
            paciente.caracteristicasEspeciales = descripcionMascota.Text;
            paciente.fechaNacimiento = fechaMascota.Text;

            pacienteDao.insert(paciente);
            this.Close();
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
            animal_raza.Text = animales_razas.SelectedValue.ToString();          
        }

        //private void btnEditMascota_Click(object sender, EventArgs e)
        //{
        //    Paciente p = new Paciente();
        //    //p.idPaciente = this.idCliente;
        //    p.idRaza = Int32.Parse(animal_raza.Text);
        //    p.idEspecie = Int32.Parse(idEspe.Text);
        //    p.color = txtcolor.Text;
        //    p.nombrePaciente = txtNombreMascota.Text;
        //    p.genero = gener.Text;
        //    p.caracteristicasEspeciales = descripcionMascota.Text;
        //    p.fechaNacimiento = fechaMascota.Text;

        //    pacienteDao.update(p);
        //    this.Close();
        //}

        //private void btnElminarMascota_Click(object sender, EventArgs e)
        //{
        //    //pacienteDao.delete(this.idCliente);
        //    this.Close();
        //}

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
            idclienteActivo.Text = dgvDatosPropietarios.Rows[e.RowIndex].Cells[0].Value.ToString();
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
