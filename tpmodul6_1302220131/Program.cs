using tpmodul6_1302220131.SayaTubeVideo;

namespace program;

class Program
{
    public static void Main(String[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("judul", 0);
        for(int i = 0; i < 220; i++)
        {
            video.incrementPlayCount(10000000);
            video.printVideoDetails();
        }
        Console.WriteLine("new play count :" +int.MaxValue);
    }
}