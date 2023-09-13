using System;
using System.Globalization;

namespace aula60
{
    class ContaBancaria
    {
        public int NumeroDaConta { get; private set; }
        public string TitularDaConta { get; private set; }
        public double Saldo { get ; private set; }

        public ContaBancaria(int numero, string titular)
        {
            NumeroDaConta = numero;
            TitularDaConta = titular;
        }

        public double Deposito(double valorDeposito)
        {
            return Saldo += valorDeposito; 
        }

        public void Saque(double valorSaque)
        {
            Saldo -= valorSaque;
        }

        public override string ToString()
        {
            return "Conta: " + NumeroDaConta + ", Titular: " + TitularDaConta + ", Saldo: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
 