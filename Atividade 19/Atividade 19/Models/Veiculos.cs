using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Atividade_19.Models
{
    public class Veiculos
    {
        private readonly static string conn = "Data Source=DESKTOP-RAT977S;Initial Catalog=AgenciaAuto;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Modelo { get; set; }
        public short Ano { get; set; }
        public short Fabricacao { get; set; }
        public string Cor { get; set; }
        public byte Combustivel { get; set; }
        public bool Automatico { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }

        public Veiculos() { }
        public Veiculos(int id, string nome, string modelo, short ano, short fabricacao, string cor, byte combustivel, bool automatico, decimal valor, bool ativo)
        {
            Id = id;
            Nome = nome;
            Modelo = modelo;
            Ano = ano;
            Fabricacao = fabricacao;
            Cor = cor;
            Combustivel = combustivel;
            Automatico = automatico;
            Valor = valor;
            Ativo = ativo;
        }
        public static List<Veiculos> GetCarros()
        {
            var listaCarros = new List<Veiculos>();
            var sql = "SELECT * FROM tb_Veiculos";
            
            var conect = new SqlConnection(conn);
            conect.Open();
            var comando = new SqlCommand(sql, conect);
            var execucao = comando.ExecuteReader();
            if (execucao.HasRows)
            {
                try
                {
                    while (execucao.Read())
                    {
                        listaCarros.Add(new Veiculos(
                            Convert.ToInt32(execucao["Id"]),
                            execucao["Nome"].ToString(),
                            execucao["Modelo"].ToString(),
                            Convert.ToInt16(execucao["Ano"]),
                            Convert.ToInt16(execucao["Fabricacao"]),
                            execucao["Cor"].ToString(),
                            Convert.ToByte(execucao["Combustivel"]),
                            Convert.ToBoolean(execucao["Automatico"]),
                            Convert.ToDecimal(execucao["Valor"]),
                            Convert.ToBoolean(execucao["Ativo"])
                            ));
                    }
                } catch (SqlException ex)
                {
                    Console.WriteLine("Erro :", ex);
                }
                finally
                {
                    conect.Close();
                }
            }
            return listaCarros;
        }
        public void salvar()
        {
            var conceccao = new SqlConnection(conn);
            conceccao.Open();
            var sql = "INSERT INTO tb_Veiculos ('Nome', 'Modelo','Fabricacao','Cor','Combustivel','Automatico','Valor','Ativo' )values (@nome, @modelo, @ano, @fabricacao, @cor, @combustivel, @automatico,@valor,@ativo)";
            var comando = new SqlCommand();
            comando.Parameters.AddWithValue("@nome", Nome);
            comando.Parameters.AddWithValue("@modelo", Modelo);
            comando.Parameters.AddWithValue("@fabricacao", Fabricacao);
            comando.Parameters.AddWithValue("@cor", Cor);
            comando.Parameters.AddWithValue("@combustivel", Combustivel);
            comando.Parameters.AddWithValue("@automatico", Automatico);
            comando.Parameters.AddWithValue("@valor", Valor);
            comando.Parameters.AddWithValue("@ativo", Ativo);

            comando.ExecuteNonQuery();


        }
    }
}