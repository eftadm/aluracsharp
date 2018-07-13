﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";
            Console.WriteLine(contaDoBruno.saldo);
            bool resultadoSaque = contaDoBruno.Sacar(500);
            Console.WriteLine(resultadoSaque);
            Console.WriteLine(contaDoBruno.saldo);            
            Console.ReadLine();

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);
            Console.ReadLine();

            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo anterior do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo anterior da Gabriela: " + contaDaGabriela.saldo);
            bool resultadoTransferencia = contaDoBruno.Transferir(2000,contaDaGabriela);
            Console.WriteLine(resultadoTransferencia);
            Console.WriteLine("Saldo atual do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo atual da Gabriela: " + contaDaGabriela.saldo);
            Console.ReadLine();

            resultadoTransferencia = contaDaGabriela.Transferir(100, contaDoBruno);
            Console.WriteLine(resultadoTransferencia);
            Console.WriteLine("Saldo atual do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo atual da Gabriela: " + contaDaGabriela.saldo);
            Console.ReadLine();
        }
    }
}