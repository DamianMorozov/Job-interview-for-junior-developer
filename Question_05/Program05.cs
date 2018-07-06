using System;
// ReSharper disable UseStringInterpolation
// ReSharper disable RedundantCast

namespace Question_05
{
    class Program05
    {
        static void Main()
        {
            var s1 = string.Format("{0}{1}", "abc", "cba");
            var s2 = "abc" + "cba";
            var s3 = "abccba";

            Console.WriteLine(s1 == s2);
            Console.WriteLine((object)s1 == (object)s2);
            Console.WriteLine(s2 == s3);
            Console.WriteLine((object)s2 == (object)s3);

            Console.ReadKey();
        }
    }
}
