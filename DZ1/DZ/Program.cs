using System;
using EpisodeClass;

namespace DZ
{
    class Program
    {
        public static double GenerateRandomScore()
        {
            Random random = new Random();
            return random.NextDouble() * 10;
        }
        static void Main(string[] args)
        {
            Episode ep1 = new Episode();
            Episode ep2 = new Episode(10, 64.13, 8.7);
            int viewers = 10;
            for (int i = 0; i < viewers; i++)
            {
                ep1.AddView(GenerateRandomScore());
                Console.WriteLine(ep1.GetMaxScore());
            }
            if (ep1.GetAverageScore() > ep2.GetAverageScore())
            {
                Console.WriteLine("Viewers:" + ep1.GetViewerCount());
            }
            else
            {
                Console.WriteLine("Viewers:" + ep2.GetViewerCount());
            }
        }
    }
}
