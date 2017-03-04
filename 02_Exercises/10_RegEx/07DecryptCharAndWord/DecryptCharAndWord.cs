namespace _07DecryptCharAndWord
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class DecryptCharAndWord
    {
        public static void Main()
        {
            //// Read a char symbol as a string, and decrypt it 13 chars after.
            string inputt = Console.ReadLine();
            char resultt = (char)(((char.Parse(inputt) - 'a' + 13) % 26) + 'a');
            Console.WriteLine(resultt.ToString());

            //// Read a string, and decrypt each char 13 chars after.
            string input = Console.ReadLine();
            StringBuilder decrWord = new StringBuilder();
            foreach (var newChar in input)
            {
                decrWord.Append(AfterHalfAlphabet(newChar));
            }

            Console.WriteLine(decrWord.ToString());
        }

        public static char AfterHalfAlphabet(char currentChar)
        {
            char[] alphabet = new char[26];
            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabet[i - 'a'] = i;
            }

            int index = currentChar - 'a';
            char result = alphabet[(index + 13) % alphabet.Length];
            return result;
        }
    }
}