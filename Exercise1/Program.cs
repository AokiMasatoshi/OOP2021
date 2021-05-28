using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static Song[] Songs = new Song[1];

        static void Main(string[] args) {
            Songs[0] = new Song("リリック", " TOKIO", 72);

            PrintSongs(Songs);
           
        }
        private static void PrintSongs(Song[] songs) {
            int min = Songs.Length / 60;
            int sec = Songs.Length % 60;
            foreach (var song in songs) {
                Console.WriteLine("{0},{1},{2}:{3}", songs[0].Title, songs[0].ArtistName, min, sec);
            }
        }
    }
}
