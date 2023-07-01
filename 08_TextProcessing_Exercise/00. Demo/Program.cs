using System;
using System.Collections.Generic;

namespace _00._Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //  •	On the first input line – lost games count – integer in the range[0…1000].
            //  •	On the second line – headset price – floating - point number in the range[0…1000].
            //  •	On the third line – mouse price – floating - point number in the range[0…1000].
            //  •	On the fourth line – keyboard price – floating - point number in the range[0…1000].
            //  •	On the fifth line – display price – floating - point number in the range[0… 1000].

            // Lost games
            int lostGameCount = int.Parse(Console.ReadLine());
            // Prices
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            // Every second lost game, Petar trashes his headset.
            // Every third lost game, Petar trashes his mouse.
            // When Petar trashes both his mouse and headset in the same lost game, he also trashes his keyboard.
            // Every second time, when he trashes his keyboard, he also trashes his display.

            

            double sum = 0;
            int keyboardTrashesCounter = 0;
            for (int i = 1; i <= lostGameCount; i++)
            {
                bool headsetTrashed = false;
                bool mouseTrashed = false;
                bool keyboardTrashed = false;

                int currentLostGame = i;

                if (currentLostGame % 2 == 0)
                {
                    sum += headsetPrice;
                    headsetTrashed = true;
                }
                if (currentLostGame % 3 == 0)
                {
                    sum += mousePrice;
                    mouseTrashed = true;
                }
                    
                if (mouseTrashed == true && headsetTrashed == true)
                {
                    sum += keyboardPrice;
                    keyboardTrashesCounter++;
                    keyboardTrashed = true;
                }
                if (keyboardTrashesCounter % 2 == 0 && keyboardTrashesCounter != 0 && keyboardTrashed == true)
                {
                    sum += displayPrice;
                }
            }

            //              Output 
            //•	As output you must print Petar's total expenses: "Rage expenses: {expenses} lv.".
            Console.WriteLine($"Rage expenses: {sum:f2} lv.");
        }
    }
}
