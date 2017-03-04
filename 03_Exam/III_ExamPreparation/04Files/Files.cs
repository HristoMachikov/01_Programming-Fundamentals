namespace _04Files
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class Files
    {
        public static void Main()
        {
            int numb = int.Parse(Console.ReadLine());
            ////string[] input = File.ReadAllLines(@"..\..\Input.txt");
            string[] input = new string[numb];
            for (int i = 0; i < numb; i++)
            {
                input[i] = Console.ReadLine();
            }

            string[] querys = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            string fileExtension = querys.First();
            string rootDirectiry = querys.Last();
            Dictionary<string, Dictionary<string, long>> allFiles = new Dictionary<string, Dictionary<string, long>>();

            foreach (var query in input)
            {
                string[] queryArray = query
                    .Trim()
                    .Split('\\');
                string currentRoot = queryArray.First();
                string currentFile = queryArray.Last();
                string[] fileSize = currentFile
                    .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();
                long currentSize = long.Parse(fileSize.Last());
                string[] fileName = fileSize[0].Split('.');
                string currentExtension = fileName.Last();

                var temp = fileSize[0];
                var currentNameArray = temp.Take(temp.Length - currentExtension.Length - 1).ToArray();
                string currentName = new string(currentNameArray);

                if (currentRoot == rootDirectiry)
                {
                    if (!allFiles.ContainsKey(currentRoot))
                    {
                        allFiles[currentRoot] = new Dictionary<string, long>();
                    }

                    if (currentExtension == fileExtension)
                    {
                        if (!allFiles[currentRoot].ContainsKey(currentName))
                        {
                            allFiles[currentRoot][currentName] = 0;
                        }

                        allFiles[currentRoot][currentName] = currentSize;
                    }
                }
            }

            if (allFiles.Any() && allFiles[rootDirectiry].Any())
            {
                foreach (var kvp in allFiles[rootDirectiry].OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine("{0}.{1} - {2} KB", kvp.Key, fileExtension, kvp.Value);
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}