using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_05
{
    class Person
    {
        private string name;
        private int age;
        private string email;
        public Person(string name, int age, string email)
        {
            this.name = name;
            this.age = age;
            this.email = email;
        }
        public Person(string name, int age) : this(name, age, null)
        {

        }
        public string Name
        {
            get => this.name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name !");
                }                   
                this.name = value;
            }
        }
        public int Age
        {
            get => this.age;
            set
            {
                if(value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Put an age between 1 and 100");
                }
                this.age = value;
            }
        }
        public string Email
        {
            get => this.email;
            set
            {
                if (value != null && !value.Contains("@"))
                {
                    throw new FormatException("Invalid e-mail format !");
                }
                this.email = value;
            }
        }
        public override string ToString()
        {
            return "Person : " + name + " is " + age + " and his/her email is : " + email;
        }
    }
}
