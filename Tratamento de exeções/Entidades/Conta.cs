using System;
using Tratamento_de_exeções.Entidades.DominExeções;

namespace Tratamento_de_exeções.Entidades.DominExeções
{
    class Conta
    {
        public int Número { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaque { get; set; }

        public Conta() //construtor sem argumento
        {
        }
        public Conta(int número, string titular, double saldo, double limiteSaque) //construtor com argumentos
        {
            Número = número;
            Titular = titular;
            Saldo = saldo;
            LimiteSaque = limiteSaque;      
        }
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public void Saque(double quantia)
        {
            Saldo -= quantia;

            if (Saldo <= 0)
            {
                throw new DominExeções("Não há saldo suficiente");
            }
            if (quantia > LimiteSaque)
            {
                throw new DominExeções("O valor execede o limite de saque");
            }
        }
        public override string ToString()
        {
            return "Novo saldo: "
                + Saldo.ToString("f2");
        }
    }
}
