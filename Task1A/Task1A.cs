using System;

namespace Task1.CSharpBase
{
    public static class Task1A
    {
        public static void Main()
        {
            Console.WriteLine("Task1A");
            Console.Write("Нажмите <Enter> для завершения");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { };
        }
    }
}
