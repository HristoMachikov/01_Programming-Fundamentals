namespace _04MergeFiles
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MergeFiles
    {
        public static void Main()
        {
            int[] firstInput = File.ReadAllLines(@"..\..\Input1.txt").Select(int.Parse).ToArray();
            int[] secondInput = File.ReadAllLines(@"..\..\Input2.txt").Select(int.Parse).ToArray();
            int[] combine = firstInput.Concat(secondInput).OrderBy(x => x).ToArray();

            foreach (var item in combine)
            {
                File.AppendAllText(@"..\..\Output.txt", Convert.ToString(item) + Environment.NewLine);
            }
        }
    }
}