using System;
using Tratamento_de_exeções.Entidades;
using Tratamento_de_exeções.Entidades.DominExeções;
using System.Globalization;

namespace Tratamento_de_exeções
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Entre com os dados da conta");
                Console.Write("Número: ");
                int número = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Titular: ");
                string titular = Console.ReadLine();
                Console.Write("Saldo inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Limite de saque: ");
                double limiteSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Conta conta = new Conta(número, titular, saldo, limiteSaque);

                Console.WriteLine();
                Console.Write("Entre com a quantia para saque: ");
                double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Saque(quantia);
                Console.WriteLine("Novo saldo: " + conta.Saldo.ToString("f2"), CultureInfo.InvariantCulture);
            }
            catch(DominExeções e)
            {
                Console.WriteLine("ERROR! " + e.Message);
            }
        }
    }
}
