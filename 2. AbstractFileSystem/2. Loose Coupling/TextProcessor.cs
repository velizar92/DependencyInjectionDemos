using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._AbstractFileSystem._2._Loose_Coupling
{
    /*Here our TextProcessor class is decoupled from the File system.
     * It depends from an abstraction interface IFileReader. That means now this class
     * is fully testable and we can create mock and simulate the behavior of its dependency
     * (IFileReader) in our unit tests. Also we can swap the real file readers very easily without 
     * to touch the TextProcessor class. TextProcessor class just works via abstraction,
     * and not concreate implementation. It is decoupled.
     */
    public class TextProcessor
    {
        private readonly IFileReader _reader;
        public TextProcessor(IFileReader reader)
        {
            if (reader == null)
            {
                throw new ArgumentNullException(nameof(reader));
            }

            _reader = reader;
        }

        public void ProcessTextContent(string fileName)
        {
            string[] fileLines = _reader.ReadFileLines(fileName);

            //Some processing of these file lines...

        }
    }
}
