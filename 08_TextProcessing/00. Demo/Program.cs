using System;

namespace _00._Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordsToRemove = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var word in wordsToRemove)
            {
                if (text.Contains(word))
                {
                    string asterisk = new string('*', word.Length);
                    text = text.Replace(word, asterisk);
                }
            }
            Console.WriteLine(text);
        }
    }
}
