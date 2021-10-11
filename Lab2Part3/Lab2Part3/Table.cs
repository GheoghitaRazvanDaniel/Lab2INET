using System;
using System.Collections.Generic;

namespace Lab2Part3
{
    class Table
    {
        public List<string> rows;
        public Table(List<string> lines)
        {
            rows = lines;
        }

        public string GetSmallestDifference()
        {
            string message= "default";
            double minimum = double.MaxValue;
            foreach(string line in rows)
            {
                double value1 = Convert.ToDouble(line.Split(" ")[1]);
                double value2 = Convert.ToDouble(line.Split(" ")[2]);
                if (Math.Abs(value1-value2)<minimum)
                {
                    message = line.Split(" ")[0];
                    minimum = Math.Abs(value1 - value2);
                }
            }
            return message;
        }
    }
}
