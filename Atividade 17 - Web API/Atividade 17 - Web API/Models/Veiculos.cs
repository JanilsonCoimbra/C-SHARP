public class Veiculos

{

    public int Id { get; set; }
    public String Modelo { get; set; }
    public short Ano { get; set; }
    public short Fabricacao { get; set; }
    public String Cor { get; set; }
    public byte Combustivel { get; set; }
    public bool Automatico { get; set; }
    public decimal Valor { get; set; }
    public bool Ativo { get; set; }



    // método construtor 

    public Veiculos(int id, String modelo, short ano, short fabricacao, String cor,

        byte combustivel, bool automatico, decimal valor, bool ativo)

    {

        // parâmetros da classe recebem informações dos parâmetros do método constrututor 

        Id = id;

        Modelo = modelo;

        Ano = ano;

        Fabricacao = fabricacao;

        Cor = cor;

        Combustivel = combustivel;

        Automatico = automatico;

        Valor = valor;

        Ativo = ativo;

    }

}