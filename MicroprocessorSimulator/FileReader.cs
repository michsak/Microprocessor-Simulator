using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string fileContent = System.IO.File.ReadAllText(filename);
            return fileContent;
        }
    }

}
