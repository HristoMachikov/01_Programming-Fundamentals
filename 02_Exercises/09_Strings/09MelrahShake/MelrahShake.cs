namespace _09MelrahShake
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class MelrahShake
    {
        public static void Main()
        {
            string sentence = Console.ReadLine();
            string pattern = Console.ReadLine();
            while (pattern.Length != 0)
            {
                if (pattern == sentence)
                {
                    Console.WriteLine("Shaked it.");
                    Console.WriteLine("No shake.");
                    sentence = string.Empty;
                    break;
                }

                int firstIndex = sentence.IndexOf(pattern);
                if (firstIndex >= 0)
                {
                    StringBuilder sb = new StringBuilder(sentence);
                    sb.Remove(firstIndex, pattern.Length);
                    sentence = sb.ToString();
                    int lastIndex = sentence.LastIndexOf(pattern);
                    if (lastIndex >= 0)
                    {
                        sb.Remove(lastIndex, pattern.Length);
                        sentence = sb.ToString();
                        Console.WriteLine("Shaked it.");
                        sb = new StringBuilder(pattern);
                        if (pattern.Length > 0)
                        {
                            sb.Remove(pattern.Length / 2, 1);
                            pattern = sb.ToString();
                        }
                    }
                    else
                    {
                        Console.WriteLine("No shake.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("No shake.");
                    break;
                }
            }

            if (pattern.Length == 0)
            {
                Console.WriteLine("No shake.");
            }

            Console.WriteLine(sentence);
        }
    }
}