using System;
using System.Collections.Generic;

namespace Lab2Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            // string wanted_data = "weather";
            string wanted_data = "football";
            // string file_path = @"G:\INET\Lab2\Lab2Part3\Lab2Part3\weather.dat";
            string file_path = @"G:\INET\Lab2\Lab2Part3\Lab2Part3\football.dat";
            FileReader reader = new FileReader(file_path);
            List<string> table_data = new List<string>();
            switch(wanted_data)
            {
                case "weather":
                    {
                        reader.RemoveFirstLines(2);
                        reader.RemoveLastLines(1);
                        foreach(string line in reader.FileContentsByLine)
                        {
                            WeatherData weather = new WeatherData(line.Split(" ", StringSplitOptions.RemoveEmptyEntries));
                            table_data.Add(weather.GetImportantData());
                        }
                        Table table = new Table(table_data);
                        Console.WriteLine("The day with the smallest temperature spread is " + table.GetSmallestDifference());
                        break;
                    }
                case "football":
                    {
                        reader.RemoveAtLine(0);
                        reader.RemoveAtLine(17);
                        foreach(string line in reader.FileContentsByLine)
                        {
                            char[] separators = {' ', '-', '.'};
                            string[] data = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                            Team team = new Team(Convert.ToInt32(data[0]), data[1], Convert.ToInt32(data[2]), Convert.ToInt32(data[3]), Convert.ToInt32(data[4]), Convert.ToInt32(data[5]), Convert.ToInt32(data[6]), Convert.ToInt32(data[7]), Convert.ToInt32(data[8]));
                            table_data.Add(team.GetImportantData());
                        }
                        Table table = new Table(table_data);
                        Console.WriteLine("The team with the smallest difference in goals is " + table.GetSmallestDifference());
                        break;
                    }
                default:
                    {
                        Console.WriteLine("No implementation for " + wanted_data + " yet");
                        break;
                    }
            }
            
        }
    }
}
