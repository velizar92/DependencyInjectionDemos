using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._AbstractFileSystem._1._Tight_Coupling
{
    /*Here our class TextProcessor is coupled to the File system. This is bad!
     *It is not testable with unit tests! Our unit tests will depend from the File System which
     *is incorrect. */
    public class TextProcessor
    {
        public void ProcessTextContent(string fileName)
        {
           string[] fileLines =  File.ReadAllLines(fileName);

           //Some processing of these file lines...
            
        }
    }
}
