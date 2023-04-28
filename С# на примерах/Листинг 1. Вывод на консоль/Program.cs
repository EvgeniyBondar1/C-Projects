namespace Листинг_1._Вывод_на_консоль
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "Пока, мир!";
            string name = "Андрей";
            int age = 37;

            Console.WriteLine("Привет, мир!");
            Console.WriteLine(msg);
            Console.WriteLine(100);

            Console.WriteLine($"Имя: {name}; Возраст {age}");
            Console.WriteLine("Еще один способ:");
            Console.WriteLine("Имя: {0}; Возраст {1}", name, age);

            Console.ReadLine();
        }
    }
}