namespace СoncatenationStrings
{
    public static class Program
    {
        public static void Main()
        {
            

            Console.WriteLine("Введите две произвольные строки");
            Console.Write("Строка 1: ");
            string? FirstString = Console.ReadLine();

            Console.Write("Строка 2: ");
            string? SecondString = Console.ReadLine();

            Console.WriteLine("Объединённая строка:");
            Console.WriteLine($"{FirstString} {SecondString}");
            Console.Write("Нажмите <Enter> для завершения");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { };
        }
    }
}
