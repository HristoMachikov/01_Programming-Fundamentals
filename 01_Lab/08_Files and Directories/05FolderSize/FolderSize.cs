namespace _05FolderSize
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FolderSize
    {
        public static void Main()
        {
            string[] myDir = Directory.GetFiles(@"..\..\TestFolder");
            //string[] myPath = Directory.GetDirectories(@"..\..\TestFolder");
            double sum = 0;
            foreach (var file in myDir)
            {
                FileInfo myInfo = new FileInfo(file);
                sum += myInfo.Length;
            }
            File.WriteAllText(@"..\..\Output.txt", Convert.ToString(sum / 1024.0 / 1024.0));
        }
    }
}
