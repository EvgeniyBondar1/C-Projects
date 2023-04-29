namespace Листинг_3._Код_калькулятора_расхода_топлива
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Простой калькулятор расхода топлива");
            Console.Write("Введите расстояник (км): ");

            double dist = Convert.ToDouble(Console.ReadLine());

            Console.Write("Потрачено топлива (л): ");
            double vol = Convert.ToDouble(Console.ReadLine());

            double cons = (100 * vol) / dist;

            Console.WriteLine($"Автомобиль прошел: {dist} км, потратил {vol} л топлива. Средний расход - {cons} л/100 км");
            Console.ReadLine();
        }
    }
}