using System;
using System.Threading;
namespace Timer
{
    class Timer
    {
        private int Hours;
        private int Minutes;
        private int Seconds;

        public Timer(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public void Start()
        {
            int totalSeconds = Hours * 3600 + Minutes * 60 + Seconds;
            Thread.Sleep(totalSeconds * 1000);
            Console.WriteLine("Таймер завершен");
        }
    }
}
