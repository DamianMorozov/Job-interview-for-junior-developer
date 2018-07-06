using System;
// ReSharper disable InconsistentNaming
// ReSharper disable FieldCanBeMadeReadOnly.Local

namespace Question_06
{
    internal class Program
    {
        private static Object syncObject = new Object();

        private static void Write()
        {
            lock (syncObject)
            {
                Console.WriteLine("test");
            }
        }

        static void Main()
        {
            lock (syncObject)
            {
                Write();
            }

            Console.ReadKey();
        }
    }
}
