using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("Nome, sobrennome");
            
        }
        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conec = new SqlConnection(@"Data Source=DESKTOP-RAT977S;Initial Catalog=recode;Integrated Security=True");
            try
            {
                conec.Open();
                for (int cont = 101; cont <= 10000; cont++)
                {
                    SqlCommand comando = new SqlCommand("INSERT INTO dbo.aluno values(@id, @nome, @endereco, @bairro, @cidade, @uf)");
                    comando.Connection = conec;
                    comando.Parameters.AddWithValue("@id", Convert.ToInt32(cont));
                    comando.Parameters.AddWithValue("@nome", txt_nome.Text+cont);
                    comando.Parameters.AddWithValue("@endereco", txt_endereco.Text);
                    comando.Parameters.AddWithValue("@bairro", txt_bairro.Text);
                    comando.Parameters.AddWithValue("@cidade", txt_Cidade.Text);
                    comando.Parameters.AddWithValue("@uf", txt_Uf.Text);
                    comando.ExecuteNonQuery();
                }
                
                MessageBox.Show("Sucesso!");

            } catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conec.Close();
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            SqlConnection excluir = new SqlConnection("Data Source=DESKTOP-RAT977S; Initial Catalog=recode; Integrated Security=SSPI;");
            excluir.Open();
            SqlCommand comando = new SqlCommand("delete from aluno where id_alu = @id", excluir);
            comando.Parameters.AddWithValue("@id", Convert.ToInt32(txt_id.Text));
            comando.ExecuteNonQuery();

            MessageBox.Show("Excluido com sucesso!");
            excluir.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection consulta = new SqlConnection("Data Source=DESKTOP-RAT977S; Initial Catalog=recode; Integrated Security=SSPI");

            consulta.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = consulta;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM dbo.aluno;";
            SqlDataReader execultar = comando.ExecuteReader();
            listBox1.Items.Clear();
            while (execultar.Read())
            {
                listBox1.Items.Add("Nome: " + execultar["nome"] +" "+ execultar["id_alu"]);
            }
            consulta.Close();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
