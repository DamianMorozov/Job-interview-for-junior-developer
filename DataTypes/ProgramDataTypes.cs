// ReSharper disable UnusedParameter.Local
// ReSharper disable RedundantAssignment
// ReSharper disable ConditionIsAlwaysTrueOrFalse
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace DataTypes
{
    internal class ProgramDataTypes
    {
        private struct SomeStruct
        {
            public string Value;
            public SomeStruct(string value)
            {
                Value = value;
            }
            public void ChangeValue(string value)
            {
                Value = value;
            }
        }

        private enum SomeEnum
        {
            Usa, Russia
        }

        private static class MakeSome
        {
            public static void ChangeInt(int i)
            {
                i = 2;
            }
            public static void ChangeChar(char c)
            {
                c = 'b';
            }
            public static void ChangeBool(bool flag)
            {
                flag = false;
            }
            public static void ChangeStruct(SomeStruct st)
            {
                st.Value = "changed value";
            }
            public static void ChangeEnum(SomeEnum en)
            {
                en = SomeEnum.Usa;
            }
            public static void ChangeString(string str)
            {
                str = "new string";
            }
            public static void ChangeCollection(Collection<string> collectionValues)
            {
                for (var i = 0; i < collectionValues.Count; i++)
                {
                    collectionValues[i] = "changed " + collectionValues[i];
                }
            }
            public static void ChangeStringArray(string[] arrStr)
            {
                for (var i = 0; i < arrStr.Length; i++)
                {
                    arrStr[i] = "changed " + arrStr[i];
                }
            }
        }

        private static void Main()
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Value data types");
            Console.WriteLine("----------------");
            Console.WriteLine();

            ValueDataTypes();

            Console.WriteLine("--------------------");
            Console.WriteLine("Reference data types");
            Console.WriteLine("--------------------");
            Console.WriteLine();

            ReferenceDataTypes();

            Console.ReadKey();
        }

        private static void ValueDataTypes()
        {
            int i = 1;
            Console.WriteLine("int i = 1;");
            MakeSome.ChangeInt(i);
            Console.WriteLine("MakeSome.ChangeInt(i) == " + i);
            Console.WriteLine();

            char c = 'a';
            Console.WriteLine("char c = 'a';");
            MakeSome.ChangeChar(c);
            Console.WriteLine("MakeSome.ChangeChar(c) == " + c);
            Console.WriteLine();

            bool flag = true;
            Console.WriteLine("bool flag = true;");
            MakeSome.ChangeBool(flag);
            Console.WriteLine("MakeSome.ChangeBool(flag) == " + Convert.ToString(flag));
            Console.WriteLine();

            SomeStruct st = new SomeStruct("init value");
            Console.WriteLine(@"SomeStruct st = new SomeStruct(""init value"");");
            st.ChangeValue("new value");
            Console.WriteLine(@"st.ChangeValue(""new value"");");
            MakeSome.ChangeStruct(st);
            Console.WriteLine("MakeSome.ChangeStruct(st) == " + st.Value);
            Console.WriteLine();

            SomeEnum country = SomeEnum.Russia;
            Console.WriteLine("SomeEnum country = SomeEnum.Russia;");
            MakeSome.ChangeEnum(country);
            Console.WriteLine("MakeSome.ChangeEnum(country) == " + country);
            Console.WriteLine();
        }

        private static void ReferenceDataTypes()
        {
            string str = "init string";
            Console.WriteLine(@"string str = ""init string"";");
            MakeSome.ChangeString(str);
            Console.WriteLine("MakeSome.ChangeString(str) == " + str);
            Console.WriteLine();

            var collectionValues = new Collection<string> { @"1", @"2" };
            Console.WriteLine(@"var collectionValues = new Collection<string> {@""1"", @""2""};");
            MakeSome.ChangeCollection(collectionValues);
            var changeCollection = collectionValues.Aggregate(@"", (current, value) => current + value + "; ");
            Console.WriteLine("MakeSome.ChangeCollection(collectionValues) == " + changeCollection);
            Console.WriteLine();

            string[] arrStr = new string[] { "first", "second", "third" };
            Console.WriteLine(@"string[] arrStr = new string[] { ""first"", ""second"", ""third"" };");
            MakeSome.ChangeStringArray(arrStr);
            var changeArrStr = arrStr.Aggregate(@"", (current, value) => current + value + "; ");
            Console.WriteLine("MakeSome.ChangeStringArray(arrStr) == " + changeArrStr);
            Console.WriteLine();
        }
    }
}
