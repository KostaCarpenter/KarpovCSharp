internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите количево элементов массива:\t");
        try
        {
            int elementCount = int.Parse(Console.ReadLine());
            int[] myArray = new int[elementCount];
            

            for (int i = 0; i < elementCount; i++)
            {
                Console.Write($"\nВведите элемент массива {i}:\t");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nВывод массива:");

            int result = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
                if (myArray[i] % 3 == 0)
                {
                    Console.WriteLine("Кратно 3 = " + myArray[i]);
                    result++;
                }
            }
            Console.WriteLine("\nВсего: " + result);
        }
        catch (FormatException)
        {
            Console.WriteLine("\nFormat Exception");
        }
    }
}