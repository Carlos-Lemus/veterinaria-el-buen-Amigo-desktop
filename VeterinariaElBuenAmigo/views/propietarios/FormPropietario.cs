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

namespace VeterinariaElBuenAmigo.views
{
    public partial class FormPropietario : Form
    {
        private ClienteDAO clienteDao;
        private List<Cliente> lista;

        public FormPropietario()
        {
            InitializeComponent();

            clienteDao = new ClienteDAO();
            /*
            clienteDao.insert(new Cliente(0, "Pedro Torres", "Que te importa", 12345678, "example@gmail.com"));
            clienteDao.insert(new Cliente(0, "Pedro Torres", "Que te importa", 12345678, "example@gmail.com"));
            clienteDao.insert(new Cliente(0, "Pedro Torres", "Que te importa", 12345678, "example@gmail.com"));
            */
            lista = clienteDao.getList();
            
            foreach(Cliente cliente in lista)
            {
                dgvPropietarios.Rows.Add(cliente.IdCliente, cliente.NombreCliente, cliente.Telefono, cliente.Direccion, cliente.Correo);
            }

        }
    }
}
