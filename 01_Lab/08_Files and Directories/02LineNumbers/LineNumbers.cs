namespace _02LineNumbers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LineNumbers
    {
        public static void Main()
        {
            string[] readLines = File.ReadAllLines(@"..\..\Input.txt");
            List<string> lineWithNumb = new List<string>();
            int count = 0;
            for (int i = 0; i < readLines.Length; i++)
            {
                count += 1;
                string output = count + ". " + readLines[i];
                File.AppendAllText(@"..\..\Output.txt", output + Environment.NewLine);
                lineWithNumb.Add(output);
            }
            File.WriteAllLines(@"..\..\Output.txt", lineWithNumb);
        }
    }
}
