internal class Program
{
    private static void Main(string[] args)
    {
        string Name = "Вячеслав";
        Console.Write("Введите имя:   ");
        string name = Console.ReadLine();
        if (name == Name)
            Console.WriteLine("\nПривет, Вячеслав");
        else
        if (name != Name)
            Console.WriteLine("\nНет такого имени");
    }
}