using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            string opicaoUsuario = ObterOpicaoUsuario();

            while (opicaoUsuario.ToUpper() !="X")
            {
                
            
                while (opicaoUsuario)
                {
                    case "1":
                        ListaContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
                        break;
                    case "C":
                        Console.clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
         private static string ObterOpicaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Bank esta disponivel!!!");
            Console.WriteLine("Informe a opição desejada:");
            Console.WriteLine("1- Lista Contas");
            Console.WriteLine("2- Inserir nova conta");
            Console.WriteLine("3- Transferir");
            Console.WriteLine("4- Sacar");
            Console.WriteLine("5- Depositar");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opicaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opicaoUsuario;
        }
    }
}
