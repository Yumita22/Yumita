using Datos.Expendedora2;
using Excepciones;
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
    public partial class Formextraer2 : Form
    {
        Maqexp _maqexp;
        

        public Formextraer2(Maqexp exp, Form formMenu)
        {
            this._maqexp = exp;
            this.Owner = formMenu;
            this.Owner.Hide();
            InitializeComponent();
        }

       // public class Lataextraida (string codigo, double precio);
        


        private void button2_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar dinero");
            }

            else
            {

                try
                {

                    _maqexp.Extraerlata("CO2", Convert.ToDouble(textBox1.Text));
                    MessageBox.Show("Gracias por su compra, retire su lata");

                }
                catch (SinStockExcepción mensaje)
                {
                    MessageBox.Show(mensaje.Message);
                }

                catch (DineroInsuficienteExcepcion mensaje)
                {
                    MessageBox.Show(mensaje.Message);
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar dinero");
            }

            else
            {
                 try
                {
                    
                    _maqexp.Extraerlata("CO1", Convert.ToDouble(textBox1.Text));
                    MessageBox.Show("Gracias por su compra, retire su lata");
                    
                }
                catch(SinStockExcepción mensaje)
                {
                    MessageBox.Show(mensaje.Message);
                }

                catch (DineroInsuficienteExcepcion mensaje)
                {
                    MessageBox.Show(mensaje.Message);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar dinero");
            }

            else
            {
                try
                {
                    
                    _maqexp.Extraerlata("SP1", Convert.ToDouble(textBox1.Text));
                    MessageBox.Show("Gracias por su compra, retire su lata");
                    
                }
                catch(SinStockExcepción mensaje)
                {
                    MessageBox.Show(mensaje.Message);
                }

                catch (DineroInsuficienteExcepcion mensaje)
                {
                    MessageBox.Show(mensaje.Message);
                }


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar dinero");
            }

            else
            {
                try
                {

                    _maqexp.Extraerlata("SP2", Convert.ToDouble(textBox1.Text));
                    MessageBox.Show("Gracias por su compra, retire su lata");

                }
                catch (SinStockExcepción mensaje)
                {
                    MessageBox.Show(mensaje.Message);
                }

                catch (DineroInsuficienteExcepcion mensaje)
                {
                    MessageBox.Show(mensaje.Message);
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar dinero");
            }

            else
            {
                try
                {

                    _maqexp.Extraerlata("FA1", Convert.ToDouble(textBox1.Text));
                    MessageBox.Show("Gracias por su compra, retire su lata");

                }
                catch (SinStockExcepción mensaje)
                {
                    MessageBox.Show(mensaje.Message);
                }

                catch (DineroInsuficienteExcepcion mensaje)
                {
                    MessageBox.Show(mensaje.Message);
                }


            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar dinero");
            }

            else
            {
                try
                {

                    _maqexp.Extraerlata("FA2", Convert.ToDouble(textBox1.Text));
                    MessageBox.Show("Gracias por su compra, retire su lata");

                }
                catch (SinStockExcepción mensaje)
                {
                    MessageBox.Show(mensaje.Message);
                }

                catch (DineroInsuficienteExcepcion mensaje)
                {
                    MessageBox.Show(mensaje.Message);
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Formextraer2_Load(object sender, EventArgs e)
        {

        }
    }
}
