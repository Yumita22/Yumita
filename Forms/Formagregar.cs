using Datos.Expendedora2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Formagregar : Form
    {
        private Maqexp _maqexp;
        public Formagregar(Maqexp _maqexp, FormMenu formMenu)
        {
            this._maqexp = _maqexp;
            this.Owner = formMenu;
            this.Owner.Hide();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _maqexp.AgregarLata(new Lata("CO1", "Coca Cola Regular", 50.00, 0.5, "Regular"));
            MessageBox.Show("Se ha agregado una lata");
          
        }
        private void button2_Click(object sender, EventArgs e)
        {
            _maqexp.AgregarLata(new Lata("CO2", "Coca Cola Zero", 50.00, 0.5, "Sin Azúcar"));
            MessageBox.Show("Se ha agregado una lata");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            _maqexp.AgregarLata(new Lata("FA2", "Fanta Zero", 50.00, 0.5, "Sin Azúcar"));
            MessageBox.Show("Se ha agregado una lata");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _maqexp.AgregarLata(new Lata("SP1", "Sprite Regular", 50.00, 0.5, "Regular"));
            MessageBox.Show("Se ha agregado una lata");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _maqexp.AgregarLata(new Lata("SP2", "Sprite Zero", 50.00, 0.5, "Sin Azúcar"));
            MessageBox.Show("Se ha agregado una lata");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _maqexp.AgregarLata(new Lata("FA1", "Fanta Regular", 50.00, 0.5, "Regular"));
            MessageBox.Show("Se ha agregado una lata");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        private void Formagregar_Load(object sender, EventArgs e)
        {
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
