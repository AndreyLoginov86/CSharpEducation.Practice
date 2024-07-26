namespace AreaCircle
{
    public class Program
    {
        public static void Main()
        {
            const double pi = 3.14;
            double radiusCircle = 30;

            double areasCircle = pi * Math.Pow(radiusCircle, 2);

            Console.WriteLine($"Площадь круга радиусом {radiusCircle} см. равна {areasCircle} кв.см.");

            Console.WriteLine();
            Console.Write("Нажмите <Enter> для завершения");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { };
        }
    }
}
