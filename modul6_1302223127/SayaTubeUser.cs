using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace modul6_1302223127
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string username;

        public SayaTubeUser(string username)
        {
            Debug.Assert(username != null && username.Length != 0, "Username tidak boleh kosong");
            Debug.Assert(username.Length <= 100, "Panjang username tidask boleh lebih dari 100 karakter");

            this.id = new Random().Next(11111, 99999);
            this.username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int totalPlayCount = 0;

            foreach (var data in uploadedVideos)
            {
                totalPlayCount += data.getPlayCount();
            }

            return totalPlayCount;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine($"User : {username}");

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"Video {i} judul : {uploadedVideos[i].getTitle()}");
            }
        }
    }
}
