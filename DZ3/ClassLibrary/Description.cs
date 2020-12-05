using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Description
    {
        public int NbOfEpisode { get; private set; }
        public TimeSpan LengthOfEpisode { get; private set; }
        public String Name { get; private set; }
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
