class Program
{
    static void Main()
    {
        string senhaCorreta = "1234";

        Console.Write("coloque uma senha: ");
        string senhaDigitada = Console.ReadLine();

        if (senhaDigitada == senhaCorreta)
        {
            Console.WriteLine("correta.");
        }
        else
        {
            Console.WriteLine("incorreta.");
        }
    }
}
