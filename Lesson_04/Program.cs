using System;

namespace Lesson_04
{
    class Program
    {
        static void Task_01()
        {
            int number;
            double sum = 0;
            double average;
            for(int i = 1; i<=10;i++)
            {
                Console.WriteLine("Write a number");
                number = Convert.ToInt32(Console.ReadLine());
                sum = sum + number;
                Console.Clear();
            }
            average = sum / 10;
            Console.WriteLine("Sum : " + sum);
            Console.WriteLine("Average : " + average);
        }
        static void Task_02()
        {

        }
        static void Main(string[] args)
        {
            Task_01();
        }
    }
}
