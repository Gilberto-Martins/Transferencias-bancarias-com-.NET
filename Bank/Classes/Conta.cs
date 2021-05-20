using System;

namespace Bank
{
    public class Conta
    {

        public Conta(string nome, double saldo, TipoConta tipoConta, double credito) 
        {
            this.Nome = nome;
            this.Saldo = saldo;
            this.TipoConta = tipoConta;
            this.Credito = credito;
               
        }
                private string Nome { get; set; }
        private double Saldo { get; set; }
        private TipoConta TipoConta { get; set; }
        private double Credito { get; set; }
        public Conta(string nome, TipoConta conta, double saldo, double credito)
        {
            this.Nome = nome;
            this.TipoConta = conta;
            this.Saldo = saldo;
            this.Credito = credito;
        }

        public bool Sacar(double ValorSaque)
        {
            //validação de saldo
            if (this.Saldo - ValorSaque < (this.Credito * -1))
            {
                Console.WriteLine("Saldo insuficiente!!!!");
                return false;
            }
            else
            {
                this.Saldo -= ValorSaque;
                Console.WriteLine("Saque realizado com sucesso!!! Saldo atual da conta {0} é {1} ", this.Nome, this.Saldo);
                return true;
            }
        }

        public void Depositar(double valorDeposito)
        {
            //incrementando deposito ao saldo
            this.Saldo += valorDeposito;
            Console.WriteLine("Saldo atual da Conta {0} é {1}", this.Nome, this.Saldo);
        }

        public void Transferir(double valorTranferencia, Conta contaDestino)
        {
            if (this.Sacar(valorTranferencia))
            {
                contaDestino.Depositar(valorTranferencia);
            }
        }

        public override string ToString()
        {
            string retornando = "";
            retornando += "TipoConta: " + this.TipoConta + " | ";
            retornando += "Nome: " + this.Nome + " | ";
            retornando += "Saldo: " + this.Saldo + " | ";
            retornando += "Credito: " + this.Credito;
            return retornando;
        }
    }
}
