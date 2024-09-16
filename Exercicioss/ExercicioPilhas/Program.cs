// ATIVIDADE 2:
// Programa que leia uma entrada do usuario e dentifique se a palabra informada é ou não um PALÍNDROMO. Utilizando os métodos Pop() e Push(),

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma palavra:");
        string? palavra = Console.ReadLine();
        
        if (IsPalindrome(palavra))
        {
            Console.WriteLine("A palavra é um palíndromo.");
        }
        else
        {
            Console.WriteLine("A palavra não é um palíndromo.");
        }
    }

    static bool IsPalindrome(string valor)
    {
        Stack<char> stack = new Stack<char>();
        
        // Adiciona cada caractere da palavra na pilha
        foreach (char c in valor)
        {
            stack.Push(c);
        }

        // Reconstrói a palavra a partir da pilha
        string invertido = string.Empty;
        while (stack.Count > 0)
        {
            invertido += stack.Pop();
        }

        // Compara a palavra original com a palavra invertida
        return valor.Equals(invertido, StringComparison.OrdinalIgnoreCase);
    }
}