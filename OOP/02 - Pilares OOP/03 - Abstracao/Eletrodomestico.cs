namespace OOP._02___Pilares_OOP._03___Abstracao
{
    // abstracao é um pilar suportado pela Herença 
    // a ideia da abstracao é oferencer um conjunto de estados e comportamentos que abstraia uma certa especilizacao
    // no exemplo a baixo vemos que a classe Eletrodomestico sendo abstrata ao ser herdade passa conjutos de estados e comportamentos
    // para subClasse especializadas exemplo: geladeira, micoondas podem ser subClasse especializadas
    // o quando pensamos e usar abstracao importante pensar em criar uma superClasse que sera a base de outra classe
    // vale lembrar que classes que usam o modificador (abstract nao podem ser instanciadas e devem ser somente herdadas )
    public abstract class Eletrodomestico
    {
        // usar o ( _ ) em atributos privados 
        private readonly string _nome;
        private readonly int _voltagem;

        // metodos protected nao podem serem instanciado. somente sao acessados pelo construtor da subClasse usando o ( : base )
        protected Eletrodomestico(string nome, int voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }

        // em classes abstratas nao é necessario implementar o comportamento delas posso somente informar o cabeçalho delas
        // metodos abstratos sao obrigatorios a implementacao deles em subClasses usando o Overaid para serem sobre escritos
        public abstract void Ligar();
        public abstract void Desligar();

        // posso criar implementaçoes dentro da classe abstrata mas eles nao poderam serem re escritos por subClasse que queram implementalos
        // caso queira deixar um comportamento pre definido mas tambem deixando a opaçao de sobEscrita poderia usar o modificador VIRTUAL no metodo 
        public void TestarAparelho()
        {
            // testar aparelho
        }

    }
}
