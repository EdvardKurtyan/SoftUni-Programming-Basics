using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstHand = Console.ReadLine().Split().Select(int.Parse).ToList();
            var firstHandAllCardsSum = new List<int>();
            int firstHandSum = 0;
            var secondHand = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondHandAllCards = new List<int>();
            int secondHandsum = 0;

            for (int i = 0; i < firstHand.Count; i++)
            {
                for (int t = 0; t < firstHand.Count; t++)
                {
                    if (firstHand[i] > secondHand[i])
                    {
                        firstHandAllCardsSum.Add(secondHand[i]);
                    }
                    else
                    {
                        secondHandAllCards.Add(firstHand[i]);
                    }
                    break;
                }
                if (firstHand.Count != 0 || secondHand.Count != 0)
                {
                    continue;
                }
            }
            if (firstHandAllCardsSum.Count > secondHandAllCards.Count)
            {
                foreach (var item in firstHandAllCardsSum)
                {
                    firstHandSum += item;
                }
                Console.WriteLine(firstHandSum);
            }
            else
            {
                foreach (var item in secondHandAllCards)
                {
                    secondHandsum += item;
                }
                Console.WriteLine(secondHandsum);
            }
        }
    }
}