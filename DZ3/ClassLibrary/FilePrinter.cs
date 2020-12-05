using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace ClassLibrary
{
    public class FilePrinter : IPrinter
    {
        private string outputFile;
        public FilePrinter(string outputFile)
        {
            this.outputFile = outputFile;
        }
        public void Print(string data)
        {
           using(StreamWriter writer = new StreamWriter(outputFile))
            {
                writer.WriteLine(data);
            }
        }
    }
}
