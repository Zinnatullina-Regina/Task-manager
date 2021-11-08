using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int countSongs = 4;
            List<Song> songs = new List<Song>();
            for (int i = 0; i < countSongs; i++)
            {
                Console.WriteLine("Введите название песни");
                string name = Console.ReadLine();
                Console.WriteLine("Введите название артиста");
                string author = Console.ReadLine();
                songs.Add(new Song(name, author));
            }
            Song.SearchEqualsSongs(songs);
            Song.SearchPrevSong(songs);

        }
    }
}
