using System;
using EpisodeClass;
using DescriptionClass;

namespace TvUtilitiesClass
{
   static public class TvUtilitiess
    {
        static public Episode Parse(string episodeString)
        {
            string[] TempInfo;
            TempInfo = episodeString.Split(',');
            Description description = new Description(Convert.ToInt32(TempInfo[3]),TimeSpan.Parse(TempInfo[4]), TempInfo[5]);
            Episode episode = new Episode(Convert.ToInt32(TempInfo[0]),Convert.ToDouble(TempInfo[1]),Convert.ToDouble(TempInfo[2]), description);
            return episode;
        }

        static public void Sort(Episode[] episodes)
        {
            for(int i = 0; i < episodes.Length - 1; i++)
            {
                int max = i;
                for(int j = i + 1; j < episodes.Length; j++)
                    if (episodes[j] > episodes[max]) max = j;
                Episode temp = episodes[i];
                episodes[i] = episodes[max];
                episodes[max] = temp;
            }
        }

        public static double GenerateRandomScore()
        {
            Random random = new Random();
            return random.NextDouble() * 10;
        }
    }
}
