using System;
using System.Collections.Generic;

namespace Bank
{
    class Program
    {
        static List<Conta> listaContas = new List<Conta>();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpicaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarContas();
						break;
					case "2":
						InserirConta();
						break;
					case "3":
						//Transferir();
						break;
					case "4":
						//Sacar();
						break;
					case "5":
						//Depositar();
						break;
                    case "C":
						//Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpicaoUsuario();
			}
            
            Console.WriteLine("Obrigado por usar os serviços do Bank");
            Console.ReadLine();
        }

        private static void ListarContas()
        {
            Console.WriteLine("LIstar Contas");

            if(listaContas.Count == 0){
                Console.WriteLine("Nenhuma Conta Cadastrada.");
                return;
            }else{
                for(int i = 0; i < listaContas.Count; i++){
                    Conta conta = listaContas[i];
                    Console.WriteLine("#{0} - ",i);
                    Console.WriteLine(conta);
                }
            }
        }

        private static void InserirConta()
        {
            Console.WriteLine("Inserir Conta");
            Console.WriteLine("Digite 1 para Conta Fizica ou 2 para Juridica: ");
            int tipo_Conta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Nome do Cliente: ");
            string Cliente_nome = Console.ReadLine();

            Console.WriteLine("Ensira o saldo da Conta: ");
            double Saldo_Conta = double.Parse(Console.ReadLine());

            Console.WriteLine("Ensira o Credito da Conta: ");
            double Credito_Conta = double.Parse(Console.ReadLine());

            Conta nova_Conta = new Conta(
                nome: Cliente_nome,
                saldo: Saldo_Conta,
                tipoConta: (TipoConta)tipo_Conta,
                credito: Credito_Conta
            );
            listaContas.Add(nova_Conta);
        }

        private static string ObterOpicaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Bank esta disponivel!!!");
            Console.WriteLine("Informe a opição desejada:");

            Console.WriteLine("1 - Lista Contas");
            Console.WriteLine("2 - Inserir nova conta");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
