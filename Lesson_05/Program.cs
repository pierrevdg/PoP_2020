using System;

namespace Lesson_05
{
    class Program
    {
        static void Task_01()
        {
            Dog dog1 = new Dog();
            dog1.Name = "Jean";
            dog1.Breed = "Tequel";
            Console.WriteLine(dog1.Name);
            dog1.Bark();
        }
        static void Task_02()
        {
            Person student = new Person("Pierre", 20, "pvdg@gmail.com");
            Console.WriteLine(student.ToString());
        }
        static void Main(string[] args)
        {
            Task_02();
        }
    }
}
