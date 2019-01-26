using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Request library
using System.Net;
using System.IO;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
        string url = @"http://localhost:5000/api/projects";
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

        using (HttpWebResponse response = (HttpWebResponse) request.GetResponse())
        using (Stream stream = response.GetResponseStream())
        using (StreamReader reader = new StreamReader(stream))
        
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }
}
