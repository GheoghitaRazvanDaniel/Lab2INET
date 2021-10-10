using System;
using System.Collections.Generic;

namespace Lab2Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            string file_path = @"G:\INET\Lab2\Lab2Part1\Lab2Part1\Lab2Part1\weather.dat";
            List<string> file_lines = GetFileContent(file_path);
            // Linia cu numele coloanelor
            file_lines.RemoveAt(0);
            // Linia goala dintre numele coloanelor si valorile lor
            file_lines.RemoveAt(0);
            file_lines.RemoveAt(file_lines.Count - 1);
            List<WeatherData> weatherData = new List<WeatherData>();
            var i = 0;
            foreach (string line in file_lines)
            {
                
                string[] data = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                WeatherData day_data = new WeatherData(data);
                weatherData.Add(day_data);
            }
            Console.WriteLine("The day with the lowest temperature spread is " + GetSmallestTemperatureSpreadDay(weatherData));
        }

        static List<string> GetFileContent(string file_path)
        {
            List<string> lines = new List<string>();
            foreach(string line in System.IO.File.ReadLines(file_path))
            {
                lines.Add(line);
            }
            return lines;
        }

        static decimal GetSmallestTemperatureSpreadDay(List<WeatherData> weatherDatas)
        {
            decimal day = weatherDatas[0].GetDayNumber();
            decimal minimalSpread = weatherDatas[0].GetTemperatureSpread();
            foreach(WeatherData day_data in weatherDatas)
            {
                if(minimalSpread>day_data.GetTemperatureSpread())
                {
                    day = day_data.GetDayNumber();
                    minimalSpread = day_data.GetTemperatureSpread();
                }
            }
            return day;
        }
    }
}
