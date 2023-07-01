using System;
using System.Collections.Generic;

namespace _03._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int songsCount = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < songsCount; i++)
            {
                string[] songProperty = Console.ReadLine().Split('_');

                Song song = new Song(songProperty[0], songProperty[1], songProperty[2]);

                songs.Add(song);
            }

            string command = Console.ReadLine();

            if (command == "all")
            {
                foreach (Song songName in songs)
                {
                    Console.WriteLine(songName.Name);
                }
            }
            else
            {
                foreach (var songName in songs)
                {
                    if (songName.TypeList == command)
                    {
                        Console.WriteLine(songName.Name);
                    }
                }
            }
        }
    }
    class Song
    {
        public Song(string tipeList, string name, string time)
        {
            this.TypeList = tipeList;
            this.Name = name;
            this.Time = time;
        }

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
