using System;
using System.Collections.Generic;

namespace Laborator2
{
    class Program
    {
        static void Main(string[] args)
        {


            var filename = @"C:\Users\Spanache Cerasela\Desktop\.net\football.dat";
            string[] separators = { " ", "-", "." };

            var cleaner = new DataCleaner();
            List<string> data = cleaner.ReadData(filename);
            cleaner.RemoveRow(data, 0);
            cleaner.RemoveRow(data, 17);

            var lines = new List<List<String>>();
            lines = cleaner.ParseLines(data, separators);

            var footballData = new FootballData();
            footballData.AddData(lines);
            Console.WriteLine(footballData.GetSmallestDifference());
            //footballData.GetTeamsNames();

        }
    }
}
