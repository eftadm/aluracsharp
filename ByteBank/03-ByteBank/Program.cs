using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDagabriela = new ContaCorrente();
            contaDagabriela.titular = "Gabiela";
            contaDagabriela.agencia = 863;
            contaDagabriela.numero = 863452;

            ContaCorrente contaDagabrielaCosta = new ContaCorrente();
            contaDagabrielaCosta.titular = "Gabiela";
            contaDagabrielaCosta.agencia = 863;
            contaDagabrielaCosta.numero = 863452;

            Console.WriteLine("Igualade de tipo de referencia: " + (contaDagabriela == contaDagabrielaCosta));

            int idade = 27;
            int idadeMaisUmaVez = 27;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idadeMaisUmaVez));

            contaDagabriela = contaDagabrielaCosta;
            Console.WriteLine("Igualade de tipo de referencia: " + (contaDagabriela == contaDagabrielaCosta));

            contaDagabriela.saldo = 300;
            Console.WriteLine(contaDagabriela.saldo);
            Console.WriteLine(contaDagabrielaCosta.saldo);

            Console.ReadLine();

        }
    }
}
