using System;
using System.Collections.Generic;
// ReSharper disable AccessToModifiedClosure

namespace Question_26
{
    internal class Program26
    {
        private static void Main()
        {
            var list = new List<Action>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(() => Console.WriteLine(i));
            }

            foreach (var i in list)
            {
                i();
            }

            Console.ReadKey();
        }
    }
}
