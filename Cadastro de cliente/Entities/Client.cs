using System;
using System.Collections.Generic;

class Client
{
    public string Nome { get; set; }
    public string Cpf { get; private set; }
    public string Email { get; set; }
    
    public Client(string nome, string cpf, string email)
    {
        Nome = nome;
        Cpf = cpf;
        Email = email;
    }
    public static List<Client> listClient = new List<Client>();
    public static void Cadastrar()
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("CPF: ");
        string cpf = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();

        listClient.Add(new Client(nome, cpf, email));
        Console.WriteLine("Cliente cadastrado com sucesso!");
    }
    public static void Listar()
    {
        if (listClient.Count == 0)
        {
            Console.WriteLine("Nenhum cliente cadastrado");
            return;
        }
        Console.WriteLine("\n--- Lista de clientes ---");
        foreach (var client in listClient)
        {
            Console.WriteLine(client);
        }
    }
    public static void Buscar()
    {
        Console.Write("Digite o CPF do cliente: ");
        string cpf = Console.ReadLine();

        var client = listClient.Find(c => c.Cpf == cpf);

        if (client != null)
        {
            Console.Write("Cliente encontrado: ");
            Console.WriteLine(client);
        }
        else
        {
            Console.WriteLine("Clinte não encontrado.");
        }
    } 
    public static void Remover()
    {
        Console.Write("Digite o CPF do cliente que será removido: ");
        string cpf = Console.ReadLine();

        var removido = listClient.RemoveAll(c => c.Cpf == cpf);

        if (removido > 0)
            Console.WriteLine("Cliente removido com sucesso!");
        else
            Console.WriteLine("Cliente não encontrado.");
    }
    public override string ToString()
    {
        return $"Nome: {Nome}, CPF: {Cpf}, Email: {Email}.";
    }
}