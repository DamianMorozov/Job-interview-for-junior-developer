using System;
// ReSharper disable InconsistentNaming

namespace Question_02
{
    internal class Program02
    {
        public struct S : IDisposable
        {
            private bool dispose;
            public void Dispose()
            {
                dispose = true;
            }
            public bool GetDispose()
            {
                return dispose;
            }
        }

        private static void Main()
        {
            var s = new S();
            using (s)
            {
                Console.WriteLine(s.GetDispose());
            }
            Console.WriteLine(s.GetDispose());

            Console.ReadKey();
        }
    }
}
