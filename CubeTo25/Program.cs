using System;

namespace CubeTo25
{
    class Program
    {
        static void Main(string[] args)
        {
            var xn = 1;
            while (xn <= 25)
            {
                var cube = xn * xn * xn;
                Console.WriteLine($"{cube}");
                xn += 2;
            }
        }
    }
}
