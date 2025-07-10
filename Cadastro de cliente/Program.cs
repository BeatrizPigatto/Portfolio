using System;

class Program
{
    static void Main()
    {
        int opcao;
        do
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Cadastrar cliente");
            Console.WriteLine("2. Listar clientes");
            Console.WriteLine("3. Buscar cliente por CPF");
            Console.WriteLine("4. Remover cliente por CPF");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Client.Cadastrar(); break;
                case 2: Client.Listar(); break;
                case 3: Client.Buscar(); break;
                case 4: Client.Remover(); break;
                case 0: Console.WriteLine("Saindo..."); break;
                default: Console.WriteLine("Opção inválida"); break;
            }

        } while (opcao != 0);
    }
}
