internal class Program
{
    private static void Main(string[] args)
    {
        string name1;
        string name2;
        char escolha;

        do
        {
            Console.Clear();
            Console.Write("Informe o 1° nome: ");
            name1 = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Informe o 2° nome: ");
            name2 = Console.ReadLine();
            Console.WriteLine();

            if (name1.Equals(name2))
            {
                Console.WriteLine($"{name1} é igual a {name2}");
            }
            else
            {
                Console.WriteLine($"{name1} é diferente de {name2}");
            }

            Console.WriteLine();
            Console.Write("Deseja realizar uma nova comparação [Y / N]? ");
            escolha = char.Parse(Console.ReadLine());
        } while ((escolha == 'Y') || (escolha == 'y'));

        Console.WriteLine();
        Console.WriteLine("Ok, fim do programa!!!");
    }
}