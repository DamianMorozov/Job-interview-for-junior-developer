using System;

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

        static void Main(string[] args)
        {
            lock (syncObject)
            {
                Write();
            }

            Console.ReadKey();
        }
    }
}
