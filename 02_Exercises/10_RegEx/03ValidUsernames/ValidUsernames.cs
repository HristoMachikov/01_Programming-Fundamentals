namespace _03ValidUsernames
{
    using System;
    using System.Text.RegularExpressions;

    public class ValidUsernames
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            if (input.Length > 0 && input.Length < 10000)
            {
                MatchCollection matches = Regex.Matches(input, @"\b[a-zA-Z]\w{1,23}[^ \/\\\(\)]\b");
                string firstEmail = string.Empty;
                string secondEmail = string.Empty;
                string previewsMail = string.Empty;
                int sum = 0;
                int maxSum = 0;
                foreach (Match match in matches)
                {
                    string currentMail = match.ToString();
                    sum = previewsMail.Length + currentMail.Length;
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        firstEmail = previewsMail;
                        secondEmail = currentMail;
                    }

                    previewsMail = currentMail;
                }

                Console.WriteLine(firstEmail);
                Console.WriteLine(secondEmail);
            }
        }
    }
}