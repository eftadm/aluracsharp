using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 13");

            for (int linha = 0; linha < 10; linha++)
            {
                Console.WriteLine();
                for(int coluna=0; coluna<10; coluna++)
                {
                    Console.Write("*");
                    if (coluna >= linha)
                        break;
                }
            }


            for (int linha = 0; linha < 10; linha++)
            {
                Console.WriteLine();
                for (int coluna = 0; coluna <= linha; coluna++)
                {
                    Console.Write("*");
                }
            }


            Console.ReadLine();
            
        }
    }
}
