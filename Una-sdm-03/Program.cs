using System;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main()
    {
        string json = File.ReadAllText("livro.json");

        Livro livro = JsonSerializer.Deserialize<Livro>(json);

        Console.WriteLine("Livro carregado:");
        Console.WriteLine($"Título: {livro.titulo}");
        Console.WriteLine($"Autor: {livro.autor}");
        Console.WriteLine($"Ano: {livro.anoPublicacao}");
        Console.WriteLine($"Disponível: {livro.disponivel}");
    }
}