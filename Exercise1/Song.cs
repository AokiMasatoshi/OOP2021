using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Song {
        public String Title { get; set; }

        public string ArtistName { get; set; }

        public int Length { get; set; }


        public Song(String Title,String ArtistName,int Length) {
            this.Title = Title;
            this.ArtistName = ArtistName;
            this.Length = Length;


        }
        }



    }

