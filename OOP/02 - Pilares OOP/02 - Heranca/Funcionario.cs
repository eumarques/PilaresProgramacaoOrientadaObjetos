using OOP._02___Pilares_OOP._01___Estado_x_Comportamento;

namespace OOP._02___Pilares_OOP._02___Heranca
{
    // Herança e quando uma classe herda os atributos e comportamentos de uma outra classe chamada assim SuperClasse
    // Importante pensar que a subclasse/ClasseFilho é uma SuperClasse isso precisa fazer sentido para haver a herança da forma correta
    // quando herdamos de uma superclasse estamos extendendo os atributos da superclasse com a subclasse no caso a classe funcionario
    // funcionario é uma pessoa. isso precisa sempre fazer sentido caso contrario nao deve-se usar herenca
    // exemplo Funcionario é um livro.
    public class Funcionario : Pessoa
    {
        public DateTime DataAdmissao { get; set; }
        public string Registro { get; set; }
    }

    public class Processo
    {
        public void Execucao()
        {
            var funcionario = new Funcionario
            {
                // atributos herdados da superClasse/ClassePai
                Nome = "Joao",
                DataNascimento = Convert.ToDateTime(value: "1990/01/01"),

                // atributos da subclasse/ClasseFilho
                DataAdmissao = DateTime.Now,
                Registro = "0123456789"
            };

            // nesse exemplo podemos var que com a heranca recebemos nao so o estado da superClasse mas tambem o comportamento
            funcionario.CalcularIdade();
        }
    }
}
