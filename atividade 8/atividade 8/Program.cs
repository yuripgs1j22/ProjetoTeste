﻿class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 != num2)
        {
            Console.WriteLine("Os números são diferentes.");
        }
        else
        {
            Console.WriteLine("Os números são iguais.");
        }
    }
}
