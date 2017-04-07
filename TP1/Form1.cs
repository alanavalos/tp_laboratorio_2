using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Numero num1 = new Numero(textBox1.Text);
            Numero num2 = new Numero(textBox2.Text);

            Calculadora.operar(num1,num2,comboBox1.Text);

            label1.Text = Calculadora.operar(num1, num2, comboBox1.Text).ToString();//convierte a string
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label1.Text = "0";
            comboBox1.Text = "";


        }
    }
}
