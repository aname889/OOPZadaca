using System;
using System.Collections.Generic;
using System.Text;

namespace DescriptionClass
{
    public class Description
    {
        private int NbOfEpisode;
        private TimeSpan LengthOfEpisode;
        private String Name;
        public Description(int NbEpisode, TimeSpan Length, String Name)
        {
            NbOfEpisode = NbEpisode;
            LengthOfEpisode = Length;
            this.Name = Name;
        }
        public Description()
        {
            NbOfEpisode = 0;
            LengthOfEpisode = TimeSpan.Zero;
            this.Name = null;
        }

        public override string ToString()
        {
            return NbOfEpisode.ToString() + "," + LengthOfEpisode.ToString() + "," + Name;
        }
    }
}
