using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YLayer.Entidades;
using YLayer.Negocio;

namespace YumiBank
{
    public partial class ListaClientes : Form
    {
        private ClienteServicio _clienteservicio;

        public ListaClientes(ClienteServicio c)
        {
            this._clienteservicio = c;
            InitializeComponent();
        }

        private void CargarListaClientes(List<Cliente> listaclientes)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = listaclientes;
        }

        private void ListaClientes_Load(object sender, EventArgs e)
        {
            CargarListaClientes(_clienteservicio.TraerClientes());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            this.Dispose();
        }
        private void ListaCompleta_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            this.Dispose();
        }

    }
}
