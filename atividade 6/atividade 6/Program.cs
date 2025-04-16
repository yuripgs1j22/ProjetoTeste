class Program
{
    static void Main()
    {
        Console.Write("Digite a nota do aluno: ");
        double nota = Convert.ToDouble(Console.ReadLine());

        if (nota >= 7)
        {
            Console.WriteLine("Aluno aprovado!");
        }
        else
        {
            Console.WriteLine("Aluno reprovado.");
        }
    }
}
