using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            //          Input
            // C:\Internal\training-internal\Template.pptx

            //          Output
            // File name: Template
            // File extension: pptx

            string[] input = Console.ReadLine().Split(':', '\\', '.');

            Console.WriteLine($"File name: {input[4]}");
            Console.WriteLine($"File extension: {input[5]}");
        }
    }
}
