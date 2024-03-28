using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302223127
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Debug.Assert(title != null && title.Length != 0, "Title tidak boleh kosong");
            Debug.Assert(title.Length <= 200, "Panjang title tidask boleh lebih dari 200");

            this.title = title;
            this.id = new Random().Next(11111, 99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int playCount)
        {
            Debug.Assert(playCount <= 25000000, "Play count melebihi batas maksimal");
            Debug.Assert(playCount > 0, "Play count tidak boleh negatif");
           
            try
            {
                int result = checked(this.playCount + playCount);
                this.playCount = result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
            
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID : {id}");
            Console.WriteLine($"Title : {title}");
            Console.WriteLine($"Play Count : {playCount}\n");
        }

        public int getPlayCount() { return playCount; }
        public string getTitle() { return title; }
    }
}
