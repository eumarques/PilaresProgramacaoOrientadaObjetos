namespace OOP._02___Pilares_OOP._01___Estado_x_Comportamento
{
    // Estado e comportamento fazem referencia a mesma classe
    public class Pessoa
    {
        // Estado é reprensentado pelas propriedades da classe
        // a classe possui atributos que sao informacao sobre o estado da entidade no ex: nome e data de nascimento
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }


        // Comportamento é quando geramos uma informacao da propria classe usando os metodos mudando o estado da classe
        // metodos podem alterar o estado da entidade
        public int CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;

            if (dataAtual < dataAtual.AddYears(idade))
            {
                idade--;
            }

            return idade;
        }
    }
}
