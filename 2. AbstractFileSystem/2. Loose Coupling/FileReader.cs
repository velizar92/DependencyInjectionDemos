using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._AbstractFileSystem._2._Loose_Coupling
{
    public class FileReader : IFileReader
    {
        public string[] ReadFileLines(string filePath)
        {
            return File.ReadAllLines(filePath);
        }
    }
}
