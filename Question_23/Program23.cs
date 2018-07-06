using System;

namespace Question_23
{
    internal class Program23
    {
        private static void Main()
        {
            string s = "A";
            Action action = () =>
            {
                Console.WriteLine(s);
                s = "B";
            };
            s = "C";
            action();
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
