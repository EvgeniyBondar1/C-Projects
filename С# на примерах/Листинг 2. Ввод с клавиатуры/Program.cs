namespace Листинг_2._Ввод_с_клавиатуры
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя:");
            string? name = Console.ReadLine();

            Console.Write("Введите возраст:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите рост:");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Имя: {name}; Возраст {age}; Рост {height}");
            Console.ReadLine();
        }
    }
}