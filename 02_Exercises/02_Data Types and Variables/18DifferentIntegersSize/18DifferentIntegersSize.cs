using System;
using System.Collections.Generic;
using System.Numerics;

namespace _18DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            string types = null;
            var primitives = new List<string>();
            if (input >= -128 && input <= 127)
            {
                types = "sbyte";
                primitives.Add(types);
            }
            if (input >= 0 && input <= 255)
            {
                types = "byte";
                primitives.Add(types);
            }
            if (input >= -32768 && input <= 32767)
            {
                types = "short";
                primitives.Add(types);
            }
            if (input >= 0 && input <= 65535)
            {
                types = "ushort";
                primitives.Add(types);
            }
            if (input >= -2147483648 && input <= 2147483647)
            {
                types = "int";
                primitives.Add(types);
            }
            if (input >= 0 && input <= 4294967295)
            {
                types = "uint";
                primitives.Add(types);
            }
            if (input >= -9223372036854775808 && input <= 9223372036854775807)
            {
                types = "long";
                primitives.Add(types);
            }
            if (primitives.Count == 0)
            {
                Console.WriteLine("{0} can't fit in any type",input);
            }
            else
            {
                Console.WriteLine("{0} can fit in:", input);
                for (int i = 0; i < primitives.Count; i++)
                {
                    Console.WriteLine("* {0}",primitives[i]);
                }
            }
        }
    }
}
