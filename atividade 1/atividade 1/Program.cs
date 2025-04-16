class Program
{
    static void Main()
    {
        Console.Write("coloca um numero: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero > 0)
        {
            Console.WriteLine("é positivo.");
        }
        else
        {
            Console.WriteLine("não é positivo.");
        }
    }
}
