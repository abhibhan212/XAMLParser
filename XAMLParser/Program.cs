using System;
using System.IO;
using System.Collections;
using System.Xaml;





namespace XAMLParser
{
    public class Program
    {

        static void Main(string[] args)
        {
            string[] fileNames = Directory.GetFiles("/Users/abhibhandari/Desktop/JOLT/xaml_outputs");
            string[] fileContents = new string[fileNames.Length];
            object[] xamlGraphs = new object[fileNames.Length];

            for (int i = 0; i < fileNames.Length; i++)
            {
                Console.WriteLine(i);
                fileContents[i] = File.ReadAllText(fileNames[i]);
            }

            for (int i = 0; i < fileNames.Length; i++)
            {
                xamlGraphs[i] = XamlServices.Parse(fileContents[i]);
            }

        }
    }
}
