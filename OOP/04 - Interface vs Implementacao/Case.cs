namespace OOP._04___Interface_vs_Implementacao
{
    // A interface e uma especie de contrato
    // no caso toda classe que implementa uma interface ela é obrigada a implementar os comportamentos da interface
    // uso de uma interface nao pode ser comparada com o uso de uma classe abstrata
    public interface IRepositorio
    {
        void Adicionar();
    }

    public class Repositorio : IRepositorio
    {

        // descomentar o construtor abaixo para ver a quebra da classe UsoImplementacao ( principio do aclopamento )
        //public Repositorio(int a)
        //{
            
        //}

        // sou obrigado a implementar todos os comportamentos da interface
        public void Adicionar() 
        { 
            // adicionar item
        }
    }

    public class UsoImplementacao
    {
        public void Processo()
        {
            // aqui vemos o principio do aclopamento
            // que seria instaciar uma classe concreta dentro de outra classe
            // caso eu altere qualquer coisa na classe repositorio a classe UsoImplementacao quebra
            var repositorio = new Repositorio();
            repositorio.Adicionar();
        }
    }


    // aqui estou fazendo uma abstracao do uso da classe. nao é o mesmo que abstracao de OOP
    public class UsoAbstraco
    {
        // nesse exemplo vemo um repositorio que esta sendo representado pelo proprio contrato
        private readonly IRepositorio _repositorio;

        // nessa classe ao inves de cria uma instancia do objeto eu injeto ela no construtor da classe que estou ultilizando
        public UsoAbstraco(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Processo()
        {
            // desta forma caso ao mude na classe repositorio minha classe nao quebra 
            // principio da coesao
            _repositorio.Adicionar();
        }
    }

    public class TesteInterfaceImplementacao
    {
        public TesteInterfaceImplementacao()
        {
            var repoImp = new UsoImplementacao();
            repoImp.Processo();

            // na injecao de dependencia mudamos as responsabilidades 
            var usoAbs = new UsoAbstraco(new Repositorio());
            usoAbs.Processo();

        }
    }
}
