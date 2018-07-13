using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1_TestaPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio testando ponto flutuante.");

            double salario = 1250.70;
            Console.WriteLine("Meu salario é " + salario);

            int divisao = 5 / 2;
            Console.WriteLine(divisao);

            double divisao2 = 5.0 / 2.0;
            Console.WriteLine(divisao2);

            
            Console.WriteLine("Fim da execucao, tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
