using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Episode
    {
        public int NbViewers { get; private set; }
        public double SumOfScores { get; private set; }
        public double MaxScore { get; private set; }
        Description description;

        public Episode(int NbViewers, double SumOfScores, double MaxScore, Description description)
        {
            this.NbViewers = NbViewers;
            this.SumOfScores = SumOfScores;
            this.MaxScore = MaxScore;
            this.description = description;
        }
        public Episode()
        {
            this.NbViewers = 0;
            this.SumOfScores = 0;
            this.MaxScore = 0;
            description = new Description();
        }

        public TimeSpan GetLenghtOfEpisode()
        {
            return description.LengthOfEpisode;
        }

        public void AddView(double Score)
        {
            NbViewers++;
            SumOfScores += Score;
            if (Score > MaxScore) MaxScore = Score;
        }
        public double GetAverageScore()
        {
            return SumOfScores / NbViewers;
        }

        public override string ToString()
        {
            return NbViewers.ToString() + "," + SumOfScores.ToString() + "," + MaxScore.ToString() + "," + description.ToString();
        }

        public static bool operator <(Episode ep1, Episode ep2)
        {
            return (ep1.GetAverageScore() < ep2.GetAverageScore());
        }

        public static bool operator >(Episode ep1, Episode ep2)
        {
            return ep1.GetAverageScore() > ep2.GetAverageScore();
        }
    }
}
