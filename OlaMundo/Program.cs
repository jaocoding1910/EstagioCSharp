using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome: ");


        string nome = Console.ReadLine();

        Console.Write("Digite sua idade: ");

        int idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Olá {nome}, você tem {idade} anos.");      
    }
}