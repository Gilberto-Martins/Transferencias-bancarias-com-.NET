using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta("Luiz",TipoConta.PessoaFizica,100.00,30.00);
            minhaConta.Depositar(100.00);
            Console.WriteLine(minhaConta.ToString());
        }
    }
}
