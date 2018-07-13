using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Escopo");

            int idadeJoao = 17;
            bool acompanhado = false;
            string mensagemAdicional = null; 

            if (acompanhado==true)
            {
                mensagemAdicional = "Joao esta acompanhado";
            }
            else
            {
                mensagemAdicional = "Joao nao esta acompanhado";
            }

            if (idadeJoao >= 18 || acompanhado)
            {
                Console.WriteLine("Joao pode entrar.");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Joao não pode entrar.");
                Console.WriteLine(mensagemAdicional);
            }




            Console.ReadLine();
        }
    }
}
