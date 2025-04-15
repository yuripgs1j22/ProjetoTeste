class Program
{
    static void Main()
    {
        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        if (idade >= 18)
        {
            Console.WriteLine("Você pode votar.");
        }
        else
        {
            Console.WriteLine("Você não pode votar.");
        }
    }
}
