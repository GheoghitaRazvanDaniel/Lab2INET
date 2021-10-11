using System;
using System.Collections.Generic;
using System.IO;

namespace Lab2Part3
{
    public class FileReader
    {
        public List<string> FileContentsByLine { get; private set; }

        public FileReader(string filepath)
        {
            if(File.Exists(filepath))
            {
                FileContentsByLine = new List<string>();
                foreach(string line in File.ReadLines(filepath))
                {
                    FileContentsByLine.Add(line);
                }
            }
        }

        public void RemoveFirstLines(int number)
        {
            for(int i = 0; i < number; i++)
            {
                FileContentsByLine.RemoveAt(0);
            }
        }

        public void RemoveLastLines(int number)
        {
            for(int i = 0; i < number; i++)
            {
                FileContentsByLine.RemoveAt(FileContentsByLine.Count - 1);
            }
        }

        public void RemoveAtLine(int line)
        {
            FileContentsByLine.RemoveAt(line);
        }
    }
}
