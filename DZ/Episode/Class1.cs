using System;
using System.Collections.Generic;
using System.Text;
using DescriptionClass;

namespace EpisodeClass
{
    public class Episode
    {
        private int NbViewers;
        private double SumOfScores;
        private double MaxScore;
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

        public void AddView(double Score)
        {
            NbViewers++;
            SumOfScores += Score;
            if (Score > MaxScore) MaxScore = Score;
        }


        public double GetMaxScore()
        {
            return MaxScore;
        }

        public int GetViewerCount()
        {
            return NbViewers;
        }

        public double GetAverageScore()
        {
            return SumOfScores / NbViewers;
        }

        public override string ToString()
        {
            return NbViewers.ToString()+ "," + SumOfScores.ToString() + "," + MaxScore.ToString() + "," + description.ToString();
        }

        public static bool operator<(Episode ep1, Episode ep2)
        {
            return (ep1.GetAverageScore() < ep2.GetAverageScore());
        }

        public static bool operator >(Episode ep1, Episode ep2)
        {
            return ep1.GetAverageScore() > ep2.GetAverageScore();
        }
    }
}
