namespace SidesTriangle
{
    public static class Program
    {
        public static void Main()
        {
            double firstCathetus = 5;
            double secondCathetus = 7;
            double hypotenuse = 11;

            Console.WriteLine("Длина гипотенузы при длине катетов {0} и {1} см. равна {2} см.", 
                firstCathetus, secondCathetus, GetHypotenuse(firstCathetus, secondCathetus));

            Console.WriteLine("Длина катета при длине гипотенузы {0} см. и длине второго катета {1} см. равна {2} см.",
                hypotenuse, secondCathetus, GetCathetus(hypotenuse, firstCathetus));

            Console.WriteLine();
            Console.Write("Нажмите <Enter> для завершения");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { };
        }

        static double GetHypotenuse(double Cathetus1, double Cathetus2)
        {
            double sumCathetus = Math.Pow(Cathetus1, 2) + Math.Pow(Cathetus2, 2);
            return Math.Round(Math.Sqrt(sumCathetus), 2);
        }

        static double GetCathetus(double hypotenuse, double Cathetus)
        {
            return Math.Round(Math.Sqrt(Math.Pow(hypotenuse, 2) - Math.Pow(Cathetus, 2)), 2);
        }
    }
}
