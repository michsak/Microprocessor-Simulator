using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroprocessorSimulator
{
    class CharReader
    {
        public CharReader(short subprogram)
        {
            if (subprogram == 256)
            {
                ReadKeyForm characterReader = new ReadKeyForm();
                characterReader.ShowDialog();
            }
        }
    }
}
