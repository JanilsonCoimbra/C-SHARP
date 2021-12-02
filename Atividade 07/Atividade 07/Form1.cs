using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_07
{
    
    public partial class Form1 : Form
    {
        public double val1;
        private double val2;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double valor1 = Double.Parse(textBox1.Text);
            double valor2 = Double.Parse(textBox2.Text);
            this.val1 = valor1;
            this.val2 = valor2;
            lbl_Resultado.Text = (valor1 + valor2).ToString();
           
            MessageBox.Show("o resultado é :" + (valor1 + valor2));

        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (lbl_Valor1.Text != "Valor 1")
            {
                barra_Progresso.Value = 50;
 
            }
            else
            {
                barra_Progresso.Value = 0;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 tela2 = new Form2(val1, val2);
            tela2.Show();
            tela2.Visible = true;


            
        }
    }
}
