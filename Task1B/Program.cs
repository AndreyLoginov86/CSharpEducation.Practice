namespace Task1B
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Task1B");
            Console.Write("Нажмите <Enter> для завершения");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { };
        }
    }
}
