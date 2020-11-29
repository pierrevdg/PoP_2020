using System;

namespace Lesson_03
{
    class Program
    {
        public static void Task_01(double side1, double side2, double side3)
        {
            if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                if (side1 == side2 && side1 == side3)
                {
                    Console.WriteLine("Every sides of the triangle are equal");
                }
                else
                {
                    if (side1 == side2)
                    {
                        Console.WriteLine("side1 and side2 are equal");
                    }
                    else
                    {
                        if (side1 == side3)
                        {
                            Console.WriteLine("side1 and side3 are equal");
                        }
                        else
                        {
                            Console.WriteLine("side2 and side3 are equal");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Every sides of the triangle are differents");
            }
        }
        public static void Task_02()
        {
            int number;
            int count = 0; //count the numbers between 10 and 20
            int sum = 0; // sum of the numbers between 10 and 20
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Write a number");
                number = Convert.ToInt32(Console.ReadLine());
                if (number >= 10 && number <= 20)
                {
                    count++;
                    sum = sum + number;
                }
                //Console.Clear();
            }
            Console.WriteLine("Number of numbers between 10 and 20 : " + count);
            Console.WriteLine("Sum of those numbers : " + sum);
        }
        public static void Task_03(int height)
        {
            if (height < 175)
            {
                Console.WriteLine("Do horse riding");
            }
            else
            {
                if (height < 190)
                {
                    Console.WriteLine("Do athletics");
                }
                else
                {
                    Console.WriteLine("Do basketball");
                }
            }
        }
        static void Main(string[] args)
        {
            Task_03(190);
        }
    }
}
