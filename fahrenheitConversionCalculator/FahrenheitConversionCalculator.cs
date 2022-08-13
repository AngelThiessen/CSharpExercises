using System;

namespace csPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what number would you like to convert to Fahrenheit today?");
            CtoF();
        }
    }
    static void CtoF(double C)
        {
            double F = (C * 1.8) + 32;
            if (F < -271.15)
            {
                Console.WriteLine("Temperature below absolute zero!");
            }
            else
            {
                Console.WriteLine(F);
            }
            C = Double.Parse(Console.ReadLine());
        }
}
