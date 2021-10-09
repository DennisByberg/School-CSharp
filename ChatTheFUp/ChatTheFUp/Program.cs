using System;
using System.Collections.Generic;

namespace ChatTheFUp
{
    class Program
    {
        class Person
        {
            public string name { get; protected set; }
            public int age { get; protected set; }

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public string returnDetails()
            {
                return name + " - " + age;
            }
        }

        static void Main(string[] args)
        {
            Person person = new Person("Dennis", 23);

            Console.WriteLine(person.returnDetails());

            Console.ReadLine();
        }
    }
}
