namespace WelcomeMessage
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string nameHuman;
            
            Console.Write("Введите своё имя: ");
            nameHuman = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Добро пожаловать, " + nameHuman + "!!!");
            Console.WriteLine();

            Console.Write("Нажмите <Enter> для завершения");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { };
        }
    }
}
