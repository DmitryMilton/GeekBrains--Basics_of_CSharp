using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("I want to learn C#!");
            //Console.ReadLine();

            String a = Console.ReadLine();
            String b = Console.ReadLine();

            int num1 = Int32.Parse(a);
            int num2 = Int32.Parse(b);

            int result = num1 + num2;
            Console.WriteLine(result);

        }
    }
}
