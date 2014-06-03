namespace DelegateTimer
{
    using System;
    using System.Threading;

    public class Timer
    {
        public delegate void TimerDelegate();

        public static void Start(TimerDelegate method, int secondsDelay, int totalSeconds)
        {
            long start = 0;
            while (start <= totalSeconds)
            {
                method();
                Thread.Sleep(secondsDelay * 1000);
                start += secondsDelay;
            }
        }

        public static void DateAndTime()
        {
            Console.WriteLine(DateTime.Now);
        }
        public static void Main()
        {
            Timer.Start(DateAndTime, 3, 10); // printing date and time in 3 seconds interval for 10 seconds
        }
    }
}