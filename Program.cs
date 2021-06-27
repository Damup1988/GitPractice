using System;

namespace GitPractice
{
    class Program
    {
        static void NewFunc()
        {
            System.Console.WriteLine("Some new func");
        }

        static void AnotherFunc()
        {
            System.Console.WriteLine("Another func is working");
        }

        static void Main(string[] args)
        {
            NewFunc();
            AnotherFunc();

            MyClass obj = new MyClass();
            obj.a = 2;
            obj.b = 4;

            MyClass2 person = new MyClass2("Damir", 32);

            System.Console.WriteLine($"Name: {person.Name}, age: {person.Age}");
        }
    }
}
