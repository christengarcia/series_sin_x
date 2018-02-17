/*
 * C# Program to calculate the series sin(x)=x-x^3/3!+x^5/!-x^7/7!+......
 */

using System;

namespace series_sin_x
{
    class Sine
    {
        int deg, n;
        public void ReadData()
        {
            Console.WriteLine("Enter the Number of Terms:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Angle in Degrees:");
            deg = Convert.ToInt32(Console.ReadLine());
        }
    }
}
