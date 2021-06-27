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

        }

        static void Main(string[] args)
        {
            NewFunc();
            AnotherFunc();

            MyClass obj = new MyClass();
            obj.a = 2;
            obj.b = 4;
        }
    }
}
