using System;

namespace Lab_4._6_jorgevillarreal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] days = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            string[] tasks = new string[7];

            for (int i = 0; i < days.Length; i++)
            {

                Console.WriteLine("Type in a new Task for " + days[i]);
                tasks[i] = days[i] + " : " + Console.ReadLine();

            }

            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(tasks[i]);
            }
        }
    }
}
