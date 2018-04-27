using System;

namespace Question_04
{
    class Program04
    {
        static void Main(string[] args)
        {
            int i = 1;
            object obj = i;
            ++i;
            Console.WriteLine(i);
            Console.WriteLine(obj);
            Console.WriteLine((short)obj);

            Console.ReadKey();
        }
    }
}
