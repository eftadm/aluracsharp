using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra = 'a';
            Console.WriteLine(letra);

            char valor = (char)65;
            Console.WriteLine(valor);

            valor = (char)(valor +1);
            Console.WriteLine(valor);

            string palavra = "Isso é uma string...";
            Console.WriteLine(palavra);

            palavra = palavra + 123;
            Console.WriteLine(palavra);

            Console.ReadLine();
        }
    }
}
