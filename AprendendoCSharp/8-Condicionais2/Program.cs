using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - condicionais 2");

            int idadeJoao = 18;
            int quantidadePessoas = 2;
            bool acompanhado = quantidadePessoas >= 2;
            Console.WriteLine(acompanhado);


            if (idadeJoao >= 18 && acompanhado)
            {
                Console.WriteLine("Joao pode entrar.");
            }
            else
            {
                Console.WriteLine("Joao não pode entrar.");
            }




            Console.ReadLine();
        }
    }
}
