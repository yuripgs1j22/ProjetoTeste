class Program
{
    static void Main()
    {
        Console.Write("coloca um numero: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 3 == 0)
        {
            Console.WriteLine("é múltiplo de 3.");
        }
        else
        {
            Console.WriteLine("não é múltiplo de 3.");
        }
    }
}
