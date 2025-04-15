class Program
{
    static void Main()
    {
        Console.Write("Digite uma letra: ");
        char letra = char.Parse(Console.ReadLine().ToLower());

        if ("aeiou".Contains(letra))
        {
            Console.WriteLine("A letra é uma vogal.");
        }
        else
        {
            Console.WriteLine("A letra não é uma vogal.");
        }
    }
}
