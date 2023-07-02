using System;

namespace _06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int widh = int.Parse(Console.ReadLine());

            int pieces = lenght * widh;
            int wholePieces = lenght * widh;

            string input = "";
            int takenPiece = 0;
            int sumOfTakenPiece = 0;
            while (pieces > 0)
            {
                input = Console.ReadLine();
                //takenPiece = int.Parse(Console.ReadLine());

                if (input == "STOP")
                {
                    break;
                }
                takenPiece = int.Parse(input);

                sumOfTakenPiece += takenPiece;
                pieces -= takenPiece;
            }
            if (sumOfTakenPiece >= wholePieces)
            {
                sumOfTakenPiece -= wholePieces;
                Console.WriteLine($"No more cake left! You need {sumOfTakenPiece} pieces more.");
            }
            else
            {
                wholePieces -= sumOfTakenPiece;
                Console.WriteLine($"{wholePieces} pieces are left.");
            }
        }
    }
}
