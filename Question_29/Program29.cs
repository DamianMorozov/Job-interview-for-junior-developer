using System;
// ReSharper disable ArrangeTypeMemberModifiers

namespace Question29
{
    internal class Program29
    {
        static int Method(int number)
        {
            if (number == 0)
                return 1;
            return number * Method(number - 1);
        }

        private static void Main()
        {
            Console.WriteLine(Method(5));

            Console.ReadKey();
        }
    }
}
