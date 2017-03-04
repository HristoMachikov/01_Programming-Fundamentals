namespace _01OddLines
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class OddLines
    {
        public static void Main()
        {
            List<string> readLines = File.ReadAllLines(@"..\..\Input.txt").ToList();
            //string[] readLines = File.ReadAllLines(@"..\..\Input.txt").ToList();
            //List<string> output = new List<string>();
            //for (int i = 0; i < readLines.Length; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        output.Add(readLines[i]);
            //    }
            //}

            //File.WriteAllLines("Output.txt", output);
            ////File.WriteAllLines(@"..\..\Output.txt", readLines.Where((line, x) => x % 2 == 1));
            List<string> output = new List<string>();
            for (int i = 0; i < readLines.Count; i++)
            {
                if (i % 2 == 1)
                {
                    File.AppendAllText("Output.txt", readLines[i] + Environment.NewLine);
                    output.Add(readLines[i]);
                }
            }
        }
    }
}
