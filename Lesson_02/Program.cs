using System;

namespace Lesson_02
{
    class Program
    {
        public static void Task1()
        {
            Console.WriteLine("Write your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            age = age + 10;
            Console.WriteLine("Your age in 10 years will be " + age);
        }
        public static void Task2_Rectangle()
        {
            Console.WriteLine("What is the lentgh of the first side in cm");
            int length1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the lentgh of the second side in cm");
            int length2 = Convert.ToInt32(Console.ReadLine());
            int perimeter = 2 * length1 + 2 * length2;
            int area = length1 * length2;
            Console.WriteLine("Perimeter of the rectangle : " + perimeter);
            Console.WriteLine("Area of the rectangle : " + area);
        }
        // A finir triangle
        public static void Task2_Triangle()
        {
            Console.WriteLine("What is the lentgh of the first side in cm");
            int length1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the lentgh of the second side in cm");
            int length2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the lentgh of the third side in cm");
            int length3 = Convert.ToInt32(Console.ReadLine());
            int perimeter = length1 + length2 + length3;
            // A faire
            int area = length1 * length2;
            Console.WriteLine("Perimeter of the triangle : " + perimeter);
            Console.WriteLine("Area of the triangle : " + area);
        }
        public static void Task2_Circle()
        {
            Console.WriteLine("What is the rayon of the circle in cm");
            int rayon = Convert.ToInt32(Console.ReadLine());
            double perimeter = 2 * Math.PI * rayon;
            double area = Math.PI * rayon * rayon;
            Console.WriteLine("Perimeter of the rectangle : " + perimeter);
            Console.WriteLine("Area of the rectangle : " + area);
        }
        // Faire task3
        public static void Homework_1()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Pierre");
        }
        public static void Homework_2()
        {
            Console.WriteLine("Enter the first number :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine(num1 + " + " + num2 + " = " + sum);
        }
        public static void Homework_3()
        {
            int operation1 = -1 + 4 * 6;
            Console.WriteLine("-1 + 4*6 = " + operation1);
            int operation2 = (35 + 5) % 7;
            Console.WriteLine("(35 + 5) % 7 = " + operation2);
            int operation3 = 14 + -4 * 6 / 11;
            Console.WriteLine("14 + -4 * 6 / 11 = " + operation3);
            int operation4 = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine("2 + 15 / 6 * 1 - 7 % 2 = " + operation4);
        }
        public static void Homework_4()
        {
            Console.WriteLine("Enter the first number :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number :");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int result = num1 * num2 * num3;
            Console.WriteLine(num1 + "*" + num2 + "*" + num3 + " = " + result);
        }
        public static void Homework_5()
        {
            Console.WriteLine("Please enter the number :");
            int number = Convert.ToInt32(Console.ReadLine());
            int result;
            Console.WriteLine("Its multiplication table is : ");
            for (int i = 1; i <= 10; i++)
            {
                result = number * i;
                Console.WriteLine(number + "*" + i + " = " + result);
            }
        }
        public static void Homework_6(double num1, double num2, double num3, double num4)
        {
            double average = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("The average of " + num1 + ", " + num2 + ", " + num3 + ", " + num4 + " is : " + average);
        }
        public static void Homework_7()
        {
            Console.WriteLine("Please enter a number :");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number <= 200 && number >= 100)
            {
                Console.WriteLine("The number is between 100 and 200");
            }
            else
            {
                Console.WriteLine("The number is not between 100 and 200");
            }
        }
        public static void Homework_8()
        {
            DateTime today = DateTime.Now;
            Console.WriteLine(today.Day + "/" + today.Month + "/" + today.Year);
        }
        public static void Homework_9()
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("Please enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            int year = today.Year - age;
            Console.WriteLine("Your year of birth is : " + year);
        }
        public static void Homework_10(int num1, int num2, int num3)
        {
            int result1 = (num1 + num2) * num3;
            int result2 = num1 * num2 + num2 * num3;
            Console.WriteLine("(" + num1 + " + " + num2 + ")*" + num3 + " = " + result1);
            Console.WriteLine(num1 + "*" + num2 + " + " + num2 + "*" + num3 + " = " + result2);
        }
        static void Main(string[] args)
        {
            Homework_10(2, 3, 4);
            Console.ReadKey();
        }
    }
}
