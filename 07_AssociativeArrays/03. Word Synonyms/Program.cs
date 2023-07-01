using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

            List<string> allSynonyms = new List<string>();

            for (int i = 0; i < lines; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                allSynonyms.Add(synonym);

                if (!synonyms.ContainsKey(word))
                {
                    synonyms.Add(word, new List<string>());
                }
                synonyms[word].Add(synonym);
            }

            foreach (var curentWord in synonyms)
            {
                Console.WriteLine($"{curentWord.Key} - {string.Join(", ", curentWord.Value)}");
            }
        }
    }
}
