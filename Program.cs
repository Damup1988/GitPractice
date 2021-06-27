using System;

namespace GitPractice
{
    class Program
    {
        static void NewFunc()
        {
            System.Console.WriteLine("Some new func");
        }

        static void Main(string[] args)
        {
            NewFunc();
            MyClass obj = new MyClass();
            obj.a = 2;
            obj.b = 4;
        }
    }
}
