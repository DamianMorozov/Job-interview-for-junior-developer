// ReSharper disable RedundantCast
// ReSharper disable RedundantNameQualifier
using System;

namespace Question_25
{
    internal class Program25
    {
        private static void Main()
        {
            string s1 = "Hello";
            string s2 = new string("Hello".ToCharArray());
            string s3 = "Hello";

            Console.WriteLine(s1 == s2);
            Console.WriteLine((object)s1 == (object)s2);
            Console.WriteLine((object)s1 == (object)s3);
            Console.WriteLine(object.ReferenceEquals(s1, s2));

            Console.ReadKey();
        }
    }
}
