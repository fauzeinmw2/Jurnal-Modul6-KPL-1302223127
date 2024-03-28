using modul6_1302223127;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo agakLaen = new SayaTubeVideo("Review Film Agak Laen oleh fauzein");
        SayaTubeVideo film2 = new SayaTubeVideo("Review Film 2 oleh fauzein");
        SayaTubeVideo film3 = new SayaTubeVideo("Review Film 3 oleh fauzein");
        SayaTubeVideo film4 = new SayaTubeVideo("Review Film 4 oleh fauzein");
        SayaTubeVideo film5 = new SayaTubeVideo("Review Film 5 oleh fauzein");
        SayaTubeVideo film6 = new SayaTubeVideo("Review Film 6 oleh fauzein");
        SayaTubeVideo film7 = new SayaTubeVideo("Review Film 7 oleh fauzein");
        SayaTubeVideo film8 = new SayaTubeVideo("Review Film 8 oleh fauzein");
        SayaTubeVideo film9 = new SayaTubeVideo("Review Film 9 oleh fauzein");
        SayaTubeVideo film10 = new SayaTubeVideo("Review Film 10 oleh fauzein");

        agakLaen.IncreasePlayCount(9000000);
        film2.IncreasePlayCount(100000);
        film3.IncreasePlayCount(800000);
        film4.IncreasePlayCount(9000);
        film5.IncreasePlayCount(11000);
        film6.IncreasePlayCount(100);
        film7.IncreasePlayCount(10);
        film8.IncreasePlayCount(50);
        film9.IncreasePlayCount(2500000);
        film10.IncreasePlayCount(90000);

        agakLaen.PrintVideoDetails();
        film2.PrintVideoDetails();
        film3.PrintVideoDetails();
        film4.PrintVideoDetails();
        film5.PrintVideoDetails();
        film6.PrintVideoDetails();
        film7.PrintVideoDetails();
        film8.PrintVideoDetails();
        film9.PrintVideoDetails();
        film10.PrintVideoDetails();

        SayaTubeUser fauzein = new SayaTubeUser("fauzein");
        fauzein.AddVideo(agakLaen);
        fauzein.AddVideo(film2);
        fauzein.AddVideo(film3);
        fauzein.AddVideo(film4);
        fauzein.AddVideo(film5);
        fauzein.AddVideo(film6);
        fauzein.AddVideo(film7);
        fauzein.AddVideo(film8);
        fauzein.AddVideo(film9);
        fauzein.AddVideo(film10);

        Console.WriteLine("Total Play Count Video User : " + fauzein.GetTotalVideoPlayCount());
        fauzein.PrintAllVideoPlaycount();

    }
}