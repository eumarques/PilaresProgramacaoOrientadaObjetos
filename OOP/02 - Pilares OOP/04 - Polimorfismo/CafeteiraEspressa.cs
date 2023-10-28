using OOP._02___Pilares_OOP._03___Abstracao;

namespace OOP._02___Pilares_OOP._04___Polimorfismo
{
    // Poli-morfismo igual a muitos comportamentos para alguma coisa
    public class CafeteiraEspressa : Eletrodomestico
    {
        public CafeteiraEspressa(string nome, int voltagem)
            : base(nome, voltagem) { }

        // um exemplo de outra forma de criar um construtor com dados padrao
        public CafeteiraEspressa()
            : base(nome: "PADRAO", voltagem: 220) { }


        // metodos privados so podem serem usados dentro da classe que foram criados no caso CafeteiraEspressa
        private static void AquecerAgua() { }

        private static void MoerGraos() { }

        public void PrepararCafe()
        {
            // no exemplo o metodo TestarAparelho pode ser usado pela subClasse mas nao podem serem sob escritos
            // não ha a obrigatoriedade da implementacao.
            TestarAparelho();
            AquecerAgua();
            MoerGraos();

        }

        // palavra Override é uma palavra chave do Polimorfismo
        // com o override podemos sobre escrever um comportamento de uma classe base no exemplo a superClasse Abstrata Eletrodomistico
        public override void Ligar()
        {
            // Resfriar aquecedor
        }

        // comportamentos abstratos sao obrigatorios serem re escritos pela subClasse que esta implementando
        public override void Desligar()
        {
            // Verificar recipiente de agua
        }


    }
}
