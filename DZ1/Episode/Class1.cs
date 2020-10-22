using System;
using System.Collections.Generic;
using System.Text;

namespace EpisodeClass
{
    public class Episode
    {
        private int NbViewers;
        private double SumOfScores;
        private double MaxScore;

        public Episode(int NbViewers, double SumOfScores, double MaxScore)
        {
            this.NbViewers = NbViewers;
            this.SumOfScores = SumOfScores;
            this.MaxScore = MaxScore;
        }
        public Episode()
        {
            this.NbViewers = 0;
            this.SumOfScores = 0;
            this.MaxScore = 0;
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
    }
}
