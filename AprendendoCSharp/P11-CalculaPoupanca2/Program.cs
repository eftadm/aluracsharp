﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 11 - Calcula Poupanca");

            double valorInvestido = 1000;
            

           for(int cont=1; cont <= 12; cont++)
            {
                valorInvestido = valorInvestido + (valorInvestido * 0.0036);
                Console.WriteLine("Após " + cont + " mes, voce tera R$" + valorInvestido);
                
            }



            Console.ReadLine();
        }
    }
}
