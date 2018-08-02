using System;
using System.Collections.Generic;

namespace Class_field
{
    internal interface ISomeChild
    {
        void SetValues(int id1, int? id2);
    }

    internal class ClassSomeChild : ISomeChild
    {
        public int Id1 { get; set; }
        public int? Id2 { get; set; }

        public void SetValues(int id1, int? id2)
        {
            Id1 = id1;
            Id2 = id2;
        }

        public ClassSomeChild(int id1, int? id2)
        {
            SetValues(id1, id2);
        }
    }

    internal class ClassSomeParent
    {
        public List<ISomeChild> SomeChilds { get; set; }

        public ClassSomeParent(List<ISomeChild> childs)
        {
            SomeChilds = childs;
        }

        public void GetSome() { }
    }

    internal class ProgramClassField
    {
        private static string WriteIntValue(int? value)
        {
            if (value.HasValue)
                return Convert.ToString(value);
            else
                return @"null";
        }

        private static void Main(string[] args)
        {
            var listParents = new List<ClassSomeParent>();
            Console.WriteLine(@"var listParents = new List<ClassSomeParent>();");
            var listChilds = new List<ISomeChild>();
            Console.WriteLine(@"var listChilds = new List<ISomeChild>();");

            listParents.Add(new ClassSomeParent(listChilds));
            Console.WriteLine(@"listParents.Add(new ClassSomeParent(listChilds));");
            Console.WriteLine();

            listChilds.Add(new ClassSomeChild(1, null));
            Console.WriteLine(@"listChilds.Add(new ClassSomeChild(1, null));");
            listChilds.Add(new ClassSomeChild(11, 22));
            Console.WriteLine(@"listChilds.Add(new ClassSomeChild(11, 22));");
            listChilds.Add(null);
            Console.WriteLine(@"listChilds.Add(null);");
            Console.WriteLine();

            listParents.ForEach(p =>
            {
                Console.WriteLine(@"listParents.ForEach(p => {...});");
                Console.WriteLine();

                p.SomeChilds.ForEach(ch =>
                {
                    Console.WriteLine(@"-------------------------------------");
                    Console.WriteLine(ch != null 
                        ? @"ch?.GetHashCode()==" + Convert.ToString(ch.GetHashCode()) 
                        : @"ch == null");
                    if (ch is ClassSomeChild child)
                    {
                        Console.WriteLine(@"child.Id1==" + WriteIntValue(child.Id1));
                        Console.WriteLine(@"child.Id2==" + WriteIntValue(child.Id2));
                    }
                });
                Console.WriteLine(@"-------------------------------------");
            });

            Console.ReadLine();
        }

    }
}
