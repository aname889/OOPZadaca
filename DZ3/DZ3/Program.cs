﻿using System;
using ClassLibrary;

namespace DZ3
{
    class Program
    {
        static void Main()
        {
           string fileName = "shows.tv";
            string outputFileName = "storage.tv";

           // string fileName = "shows.txt";
           // string outputFileName = "storage.txt";
            IPrinter printer = new ConsolePrinter();
            printer.Print($"Reading data from file {fileName}");

            Episode[] episodes = TvUtilities.LoadEpisodesFromFile(fileName);
            Season season = new Season(1, episodes);

            printer.Print(season.ToString());
            for (int i = 0; i < season.Length; i++)
            {
                season[i].AddView(TvUtilities.GenerateRandomScore());
            }
            printer.Print(season.ToString());

            printer = new FilePrinter(outputFileName);
            printer.Print(season.ToString());
        }
    }
}
