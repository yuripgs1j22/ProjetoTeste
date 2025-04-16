class Program
{
    static void Main()
    {
        Console.Write("Digite a idade da pessoa: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade >= 18)
        {
            Console.WriteLine("A pessoa é maior de idade.");
        }
        else
        {
            Console.WriteLine("A pessoa é menor de idade.");
        }
    }
}
