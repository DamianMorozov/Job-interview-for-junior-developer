using System;
using System.Collections.Generic;
// ReSharper disable AccessToModifiedClosure

namespace Question_03
{
    internal class Program02
    {
        private static void Main()
        {
            List<Action> actions = new List<Action>();
            for (var count = 0; count < 10; count++)
            {
                actions.Add(() => Console.WriteLine(count));
            }
            foreach (var action in actions)
            {
                action();
            }

            Console.ReadKey();
        }
    }
}
