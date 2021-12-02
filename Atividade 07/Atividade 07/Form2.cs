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
    
    public partial class Form2 : Form
    {
        private double valor1;
        private double valor2;
        public Form2(double v1, double v2)
        {
            InitializeComponent();
            this.valor1 = v1;
            this.valor2 = v2;
            lbl_resultado.Text = "A soma entre "+valor1+" e "+valor2+" é igual a " + (valor1 + valor2);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void lbl_resultado_Click(object sender, EventArgs e)
        {

        }
    }
}
