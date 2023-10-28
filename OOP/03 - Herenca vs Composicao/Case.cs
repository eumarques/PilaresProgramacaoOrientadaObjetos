using OOP._02___Pilares_OOP._01___Estado_x_Comportamento;

namespace OOP._03___Herenca_vs_Composicao
{

    // herenca
    // no solid vemos melhor quando devo ou nao devo usar heranca
    public class PessoalFisica : Pessoa
    {
        public string Cpf { get; set; }
    }


    // composicao
    // prefira composicao doque uma heranca
    public class PessoalFisica02
    {
        public Pessoa Pessoa { get; set; }
        public string Cpf { get; set; }
    }
    public class TesteHerancaComposicao
    {
        public TesteHerancaComposicao()
        {
            var pessoaHeranca = new PessoalFisica
            {
                Nome = "JOAO",
                DataNascimento = Convert.ToDateTime(value: "1990/01/01"),
                Cpf = "012345679"
            };

            var pessoaComposicao = new PessoalFisica02
            {
                Pessoa = new Pessoa
                {
                    Nome = "MARIA",
                    DataNascimento = Convert.ToDateTime(value: "2000/01/01")
                },
                Cpf = "0123456789"
            };

            var nomeHeranca = pessoaHeranca.Nome;
            var nomeComposicao = pessoaComposicao.Pessoa.Nome;
    }
}
}
