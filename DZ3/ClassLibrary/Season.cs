using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class Season
    {
        public int SeasonNb { get; private set; }
        private Episode[] episodes;
        public int Length { get; private set; }
        public Season(int SeasonNb, Episode[] episodes)
        {
            this.SeasonNb = SeasonNb;
            this.episodes = episodes;
            this.Length = episodes.Length;
        }
        public Season()
        {
            this.SeasonNb = 0;
            this.episodes = null;
            this.Length = 0;

        }

        public override string ToString()
        {
            string ToWrite = "Season " + SeasonNb + ":\n=================================================\n"+ string.Join<Episode>(Environment.NewLine, episodes) + "Report:\n=================================================\nTotal viewers: " + GetTotalViews(episodes) +"\nTotal duration: " + GetTotalLenght(episodes) + "\n=================================================\n" ;
            return ToWrite;
        }

        public int GetTotalViews(Episode[] episodes)
        {
            int totalViews = 0;
            foreach (Episode episode in episodes)
            {
                totalViews += episode.NbViewers;
            }
            return totalViews;
        }

        public TimeSpan GetTotalLenght(Episode[] episodes)
        {
            TimeSpan total = TimeSpan.Zero;
            foreach(Episode episode in episodes)
            {
                total += episode.GetLenghtOfEpisode();
            }
            return total;
        }

        public Episode this[int index]
        {
            get { return episodes[index]; }
            set { episodes[index] = value; }
        }
    }
}
