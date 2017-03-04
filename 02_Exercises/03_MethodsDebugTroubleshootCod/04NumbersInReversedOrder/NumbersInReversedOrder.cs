namespace _04NumbersInReversedOrder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class NumbersInReversedOrder
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string output = ReverseOrder(input);
            Console.WriteLine(output);
        }

        public static string ReverseOrder(string input)
        {
            var inputList = new List<char>();
            foreach (var symbol in input)
            {
                inputList.Add(symbol);
            }

            var reverseInputList = new char[inputList.Count];
            for (int i = 0; i < inputList.Count; i++)
            {
                reverseInputList[i] = inputList[inputList.Count - 1 - i];
            }

            string output = new string(reverseInputList);
            return output;
        }
    }
}
