using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula Poupanca");

            double valorInvestido = 1000;
            int cont=1;

            while (cont <= 12)
            {
                valorInvestido = valorInvestido + (valorInvestido * 0.0036);
                Console.WriteLine("Após " +cont +" mes, voce tera R$" + valorInvestido);
                cont++;
            }
            


            Console.ReadLine();
        }
    }
}
