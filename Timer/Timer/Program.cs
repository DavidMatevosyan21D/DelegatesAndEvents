using System;

namespace Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите часы: ");
            int hours = int.Parse(Console.ReadLine());

            Console.Write("Введите минуты: ");
            int minutes = int.Parse(Console.ReadLine());

            Console.Write("Введите секунды: ");
            int seconds = int.Parse(Console.ReadLine());

            Timer timer = new Timer(hours, minutes, seconds);
            timer.Start();
        }
    }
}
