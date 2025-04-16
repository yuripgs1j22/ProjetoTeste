class Program
{
    static void Main()
    {
        Console.Write("Digite a idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade >= 18)
        {
            Console.WriteLine("é maior de idade.");
        }
        else
        {
            Console.WriteLine(" é menor de idade.");
        }
    }
}
