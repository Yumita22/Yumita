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
    public partial class FormMenu : Form
    {
      private Maqexp _maqexp;
      private List<Lata> latas;

        public Maqexp exp
        {
            get
            {
                return _maqexp;

            }
        }
        public FormMenu(Maqexp exp)
        {
            _maqexp = exp;
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //public void Listalatas(List<Lata> latas)
        //{
        //    listBox1.DataSource = null;
        //    listBox1.DataSource = latas;
        //}

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        public void Menu_Load(object sender, EventArgs e)
        {
            //Listalatas(_maqexp.Latas);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_maqexp.EstaVacia() == true)
            { MessageBox.Show("No hay stock disponible"); }
            else
            { 
                MessageBox.Show("El stock disponible es"+_maqexp.Latas.Count()); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formagregar exp = new Formagregar (_maqexp, this);
            exp.Owner = this;
            exp.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_maqexp.Latas.Count == 0)
            {
                MessageBox.Show("No hay latas en este momento");
            }
            else
            {
                Formextraer2 exp = new Formextraer2(_maqexp, this);
                exp.Owner = this;
                exp.Show();
                this.Hide();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show( _maqexp.GetBalance());
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
