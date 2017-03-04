namespace _06DownloadFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Threading.Tasks;

    public class DownloadFile
    {
        public static void Main()
        {
            string destination = Console.ReadLine();
            string name = Console.ReadLine();
            WebClient myWebClient = new WebClient();
            myWebClient.DownloadFile(destination, name);
        }
    }
}