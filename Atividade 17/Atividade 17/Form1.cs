using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Atividade_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            atualizarLista();
        }

        private void atualizarLista()
        {
            listBox1.Items.Clear();
            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-RAT977S; Initial Catalog=cadastro; Integrated Security=true ");
            conectar.Open();
            SqlCommand comandoAtualizar = new SqlCommand();
            comandoAtualizar.Connection = conectar;
            comandoAtualizar.CommandType = CommandType.Text;
            comandoAtualizar.CommandText = "SELECT * FROM pessoas.usuario;";
            comandoAtualizar.ExecuteNonQuery();
            SqlDataReader leitura = comandoAtualizar.ExecuteReader();
            while (leitura.Read())
            {
                listBox1.Items.Add(String.Format("Nome: {0} Senha: {1}", leitura["login"], leitura["senha"]));
            }
            conectar.Close();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-RAT977S; Initial Catalog=cadastro; Integrated Security=true ");
            try
            {
                if (textBoxNome.Text == "")
                {
                    MessageBox.Show("Preencha o campo Nome!");
                } else if (textBoxSenha.Text == "")
                {
                    MessageBox.Show("Preencha o campo Senha!");
                }
                conectar.Open();
                SqlCommand comando = new SqlCommand("INSERT INTO pessoas.usuario values(@nome, @senha)");
                comando.Connection = conectar;
                comando.Parameters.AddWithValue("@nome", textBoxNome.Text);
                comando.Parameters.AddWithValue("@senha", textBoxSenha.Text);
                comando.ExecuteNonQuery();
                textBoxNome.Text = "";
                textBoxSenha.Text = "";
                MessageBox.Show("Cadastrado com sucesso");
                atualizarLista();
            }catch(SqlException ex) 
            {
                MessageBox.Show("Erro:" + ex);
            }
            finally
            {
                conectar.Close();
            }
            

        
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            atualizarLista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Atualizada");
            
        }
    }
}
