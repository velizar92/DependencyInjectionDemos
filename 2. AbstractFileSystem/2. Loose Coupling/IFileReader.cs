using System;

namespace _2._AbstractFileSystem._2._Loose_Coupling
{
    public interface IFileReader
    {
        string[] ReadFileLines(string filePath);
    }
}
