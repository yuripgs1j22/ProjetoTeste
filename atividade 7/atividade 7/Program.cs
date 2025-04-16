class Program
{
    static void Main()
    {
        Console.Write("coloca primeiro número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("coloca segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 == num2)
        {
            Console.WriteLine("são iguais.");
        }
        else
        {
            Console.WriteLine("são diferentes.");
        }
    }
}
