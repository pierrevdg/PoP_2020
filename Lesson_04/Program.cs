﻿using System;

namespace Lesson_04
{
    class Program
    {
        static void Task_01()
        {
            int number;
            double sum = 0;
            double average;
            for (int i = 1; i <= 10; i++)
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
            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Task_03()
        {
            int num = 1;
            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num);
                    num++;
                }
                Console.WriteLine();
            }
        }
        static void Task_05(int num)
        {
            int result = 1;
            while (num >= 1)
            {
                result = result * num;
                num--;
            }
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            Task_05(4);
        }
    }
}
