using System;
using System.Text;

namespace lab2OOTP
{
    class Program
    {
        static void Main()
        {
            //Types
            bool boolean = true;
            byte newByte = 255;
            sbyte newSbyte = -128;
            char symbol = 'n';
            decimal newDecimal = 1844370500.0006400m;
            float newF = 1.23f;
            double newD = 1.23;
            int newInt = -2;
            uint newUint = 2;
            long newLong = -309809;
            ulong newUlong = 309809;
            short newShort = -34;
            ushort newUshort = 34;
            object newObj = "ffgk";
            string a = "emgklrgk";
            dynamic b = 5;
            Console.WriteLine("Wanna skip? q - yes");
            char q = Convert.ToChar(Console.ReadLine());
            if (q != 'q')
            {
                Console.Write("object: ");
                newObj = Console.ReadLine();
                Console.Write("dynamic: ");
                b = Console.ReadLine();
                Console.Write("ulong: ");
                newUlong = Convert.ToUInt64(Console.ReadLine());
                Console.Write("decimal: ");
                newDecimal = Convert.ToDecimal(Console.ReadLine());
                Console.Write("float: ");
                newF = Convert.ToSingle(Console.ReadLine());
                Console.Write("uint: ");
                newUint = Convert.ToUInt32(Console.ReadLine());
                Console.Write("short: ");
                newShort = Convert.ToInt16(Console.ReadLine());
                Console.Write("ushort: ");
                newUshort = Convert.ToUInt16(Console.ReadLine());
                Console.Write("double: ");
                newD = Convert.ToDouble(Console.ReadLine());
                Console.Write("long: ");
                newLong = Convert.ToInt64(Console.ReadLine());
                Console.Write("char: ");
                symbol = Convert.ToChar(Console.ReadLine());
                Console.Write("sbyte: ");
                newSbyte = Convert.ToSByte(Console.ReadLine());
                Console.Write("byte: ");
                newByte = Convert.ToByte(Console.ReadLine());
                Console.Write("bool: ");
                boolean = Convert.ToBoolean(Console.ReadLine());
                Console.Write("string: ");
                a = Console.ReadLine();
                Console.Write("int: ");
                newInt = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write($"\nbool:{boolean}\nbyte:{newByte}\nsbyte:{newSbyte}\nchar:{symbol}\ndecimal:{newDecimal}\nfloat:{newF}\ndouble:{newD}\nint:{newInt}\nuint:{newUint}\nlong:{newLong}\nulong:{newUlong}\nshort:{newShort}\nushort:{newUshort}\nobject:{newObj}\nstring:{a}\ndynamic:{b}\n");
            newLong = newInt;
            newInt = newShort;
            newObj = symbol;
            newD = newF;
            newUlong = newUint;
            newObj = newInt;//упаковка
            newLong = (int)newObj;//распаковка
            newInt = (int)newD;
            var c = 's';
            //c = 5; нельзя
            int? price = null;
            //Strings
            var lit1 = "hello";
            var lit2 = "world";
            int cmp = lit1.CompareTo(lit2);
            var cmp2 = lit1.Equals("hello");
            var lit3 = lit1 + lit2;
            var lit4 = lit1.Substring(2);
            string[] words = lit3.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            lit3 = lit3.Insert(3, lit1);
            lit3 = lit3.Remove(3, 8);
            foreach (string s in words)
            {
                Console.WriteLine($"{ s }");
            }
            string EmptyString = "";
            string NullString = null;
            Console.WriteLine(String.IsNullOrEmpty(EmptyString));
            Console.WriteLine(String.IsNullOrEmpty(NullString));
            StringBuilder strB = new StringBuilder("Строчка");
            strB.Append("ааа");
            strB.Insert(0, "ССС");
            strB.Remove(2, 5);
            //Arrays
            int[,] A = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{A[i, j]} ");
                }
            }
            string[] sA = { "theFirst", "theSecond", "theThird" };
            for (int i = 0; i < sA.Length; i++)
            {
                Console.WriteLine(sA[i]);
            }
            Console.Write("Position = ");
            int pos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Value = ");
            var val = Console.ReadLine();
            sA[pos] = val;
            Console.WriteLine(sA[pos]);
            int[][] tooth = { new int[2], new int[3], new int[4] };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < tooth[i].Length; j++)
                {
                    Console.Write($"a{ i + 1 }-{ j + 1 }=");
                    int el = Convert.ToInt32(Console.ReadLine());
                }
            }
            var B = new[] { 1, 3, 5, 7, 9, 11 };
            var tuple = (1, "str", 'g', "str2", 10);
            Console.WriteLine($"Item5: {tuple.Item5}, Item3: {tuple.Item3}");
            Console.WriteLine(tuple);
            var (one, str, g, str2, ten) = tuple;
            g = tuple.Item3;
            var (_, _, _, needed, needed2) = tuple;
            (int, int, int, char) Local(int[] array, string s)
            {
                int max = System.Int32.MinValue;
                int min = System.Int32.MaxValue;
                int S = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > max) max = array[i];
                    if (array[i] < min) min = array[i];
                    S += array[i];
                }
                var tuple1 = (max, min, S, s[0]);
                return tuple1;
            }
            int m = Local(B, lit4).Item1;
            Console.WriteLine(m);
            int LocalChecked()
            {
                checked
                {
                    int MAX = System.Int32.MaxValue;
                    return MAX;
                }
            }
            int LocalUnchecked()
            {
                unchecked
                {
                    int MAX = System.Int32.MaxValue;
                    return MAX;
                }
            }
            try
            {
                int MAX = LocalChecked();
                MAX = LocalUnchecked();
            }
            catch(OverflowException)
            {
                Console.WriteLine("Overflow");
            }
        }
    }
}
