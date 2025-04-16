class Program
{
    static void Main()
    {
        Console.Write("Digite o 1 número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o 2 número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 != num2)
        {
            Console.WriteLine("são diferentes.");
        }
        else
        {
            Console.WriteLine("são iguais.");
        }
    }
}
