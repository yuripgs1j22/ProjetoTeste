class Program
{
    static void Main()
    {
        Console.Write("coloca um numero: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 3 == 0)
        {
            Console.WriteLine("O número é múltiplo de 3.");
        }
        else
        {
            Console.WriteLine("O número não é múltiplo de 3.");
        }
    }
}
