using System.Reflection.Metadata.Ecma335;

namespace OOP._01___Clase_x_Objeto
{
    // definicao de classe 
    // Objeto da classe e mapear um objeto da vida real 
    public class Casa
    {
        public int TamanhoM2 { get; set; }
        public int Andares { get; set; }
        public decimal Valor { get; set; }
        public int NumeroVagas { get; set; }
    }

    // Definicao de Objeto
    // Quando temos um clase instanciada passando a existir na memoria do computador
    public class Objeto
    {
        public Objeto()
        {
            var casa = new Casa
            {
                TamanhoM2 = 100,
                Andares = 2,
                Valor = 100000,
                NumeroVagas = 3,
            };
        }
    }

}
