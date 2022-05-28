using System;

namespace dot_net2
{
    class Program
    {
        private const string Format = "your sge is:";

        static void Main(string[] args)
        {
            Console.Write("Your age: " + age);
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);
            float v = (float)Convert.ToDouble(Console.ReadLine());
            NewMethod(v);
        }

        private static void NewMethod(float v)
        {
            var age = v;
        }
    }
}
    
