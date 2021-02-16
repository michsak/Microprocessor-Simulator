using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MicroprocessorSimulator
{
    class CursorPositionReader
    {
        public CursorPositionReader(short subprogram, int x, int y)
        {
            if (subprogram == 768)
            {
                int xCursorPosition = x;
                int yCursorPosition = y;
                MessageBox.Show($"X cursor coordinates: {x}\nY cursor coordinates: {y}");
            }
        }
    }
}
