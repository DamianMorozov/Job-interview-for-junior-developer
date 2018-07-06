using System;

namespace Question_04
{
    internal class Program04
    {
        private static void Main()
        {
            int i = 1;
            object obj = i;
            ++i;
            Console.WriteLine(i);
            Console.WriteLine(obj);
            //Console.WriteLine((short)obj);

            Console.ReadKey();
        }
    }
}
