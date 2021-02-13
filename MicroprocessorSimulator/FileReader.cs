using System;

namespace MicroprocessorSimulator
{
    class FileReader
    {
        private string filename;

        public FileReader(string filename)
        {
            this.filename = filename;
        }

        public string ReturnText()
        {
            try
            {
                string fileContent = System.IO.File.ReadAllText(filename);
                return fileContent;
            }
            catch (System.ArgumentException)
            {
                return String.Empty;
            }
        }
    }
}
