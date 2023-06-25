using System;

class ExibirNomesAlunos
{
    static void Main()
    {
        string[] nomesAlunos = new string[5] { "Gabriel", "Maria", "George", "Breno", "Patricia" };

        Console.WriteLine("Nomes dos alunos:");

        foreach (string nome in nomesAlunos)
        {
            Console.WriteLine(nome);
        }
    }
}
