using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            char primeiraletra = 'a';
            Console.WriteLine(primeiraletra);

            primeiraletra = (char)65;
            Console.WriteLine(primeiraletra);

            primeiraletra =(char)(primeiraletra + 1);
            Console.WriteLine(primeiraletra);

            string titulo = "Alura Cursos de Tecnologia. " + 2020;
            string cursosProgramacao = 
@"- .NET
- Java
- JavaScript";
            Console.WriteLine(titulo);
            Console.Write(cursosProgramacao);
            

            Console.ReadLine();
        }
    }
}
