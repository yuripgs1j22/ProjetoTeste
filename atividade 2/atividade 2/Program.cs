class Program
{
    static void Main()
    {
        Console.Write("coloca um numeri: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("par.");
        }
        else
        {
            Console.WriteLine("não é par.");
        }
    }
}
