using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302223127
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string username;

        public SayaTubeUser(string username)
        {
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
            int i = 1;
            Console.WriteLine($"User : {username}");

            foreach (var data in uploadedVideos)
            {
                Console.WriteLine($"Video {i} judul : {data.getTitle()}");
            }
        }
    }
}
