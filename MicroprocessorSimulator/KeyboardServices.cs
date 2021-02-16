using System;
using System.Text;

namespace MicroprocessorSimulator
{
    class KeyboardServices
    {
        public int keyValue;
        public KeyboardServices(short subprogram)
        {
            if(subprogram == 0)
            {
                KeyReader keyReader = new KeyReader();
                keyReader.ShowDialog();
                keyValue = keyReader.keyValue;
            }
        }

    }
}
