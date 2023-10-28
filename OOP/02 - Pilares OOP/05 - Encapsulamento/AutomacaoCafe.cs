using OOP._02___Pilares_OOP._04___Polimorfismo;

namespace OOP._02___Pilares_OOP._05___Encapsulamento
{
    // encapsulamento é a arte de encapsular comportamentos atras de exposicao de metodos publicos e privados
    public class AutomacaoCafe
    {
        // quando usamos o metodo ServirCafe quem implemanta ele
        // nao sabe como é a logica por de tras dele pos isso tudo esta encapsulado dentro do comportamento
        public void ServirCafe()
        {
            var espresso = new CafeteiraEspressa();
            espresso.Ligar();

            // o metodo prepararCafe tambem tem seus comportamentos encapsulados dentro dele de forma privadas
            // nao ha como instanciar a classe CafeteiraEspressa e acessar os comportamentos AquecerAgua(), MoerGraos() pois sao metodos privados
            espresso.PrepararCafe();
            espresso.Desligar();
        }
    }
}
