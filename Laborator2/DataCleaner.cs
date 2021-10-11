using System;
using System.Collections.Generic;
using System.Linq;

namespace Laborator2
{
    class DataCleaner
    {
        public List<string> ReadData(string filename)
        {
            // Read each line of the file into a string array. Each element
            // of the list is one line of the file.
            return System.IO.File.ReadAllLines(filename).ToList();
        }
        public void RemoveRow(List<string> data, int index)
        {
            data.RemoveAt(index);
        }
        public List<List<string>> ParseLines(List<string> data, string[] separators)
        {
            var lines = new List<List<string>>();
            foreach (string row in data)
            {
                lines.Add(row.Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList());
            }
            return lines;
        }
        public List<List<string>> LinesMunging(string filename, int[] indexToBeRemoved, string[] separators)
        {
            if (System.IO.File.Exists(filename))
            {

                var data = ReadData(filename);
                foreach (int index in indexToBeRemoved)
                {
                    RemoveRow(data, index);
                }
                return ParseLines(data, separators);
            }
            return null;
        }
    }
}
