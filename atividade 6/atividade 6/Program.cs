class Program
{
    static void Main()
    {
        Console.Write("nota do aluno: ");
        double nota = Convert.ToDouble(Console.ReadLine());

        if (nota >= 7)
        {
            Console.WriteLine("aprovado!");
        }
        else
        {
            Console.WriteLine("reprovado.");
        }
    }
}
