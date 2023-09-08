internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите число:\t");
        try
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 7)
            {
                Console.WriteLine("\nПривет");
            }
            
        }
        catch (FormatException)
        {
            Console.WriteLine("\nFormat Exception");
        }
        



    }
}
