using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 12");

            double valorInvestido = 1000;
            double fator = 1.0036;

            for (int contAno = 1; contAno <= 5; contAno++)
            {
                Console.WriteLine(fator);
                for (int cont = 1; cont <= 12; cont++)
                {
                    //valorInvestido *= fator;
                    valorInvestido = valorInvestido * fator;
                }
                fator = fator + 0.0010;
            }
            Console.WriteLine("Ao termino voce tera R$" + valorInvestido);


            Console.ReadLine();
        }
    }
}
