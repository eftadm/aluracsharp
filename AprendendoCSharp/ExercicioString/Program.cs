using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioString
{
    class Program
    {
        static void Main(string[] args)
        {
            string saudacao = "Olá, meu nome é ";
            string nome = "Romulo ";
            string continuacao = "e minha idade é ";
            int idade = 28;

            Console.WriteLine(saudacao+nome+continuacao+idade);
            Console.ReadLine();
        }
    }
}
