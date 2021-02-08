using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroprocessorSimulator
{
    class CursorPositionReader
    {
        public CursorPositionReader(short subprogram, int x, int y)
        {
            if (subprogram == 2560)         //2560 = 10h
            {
                int xCursorPosition = x;
                int yCursorPosition = y;
                MessageBox.Show($"Wspolrzedna x kursora: {x}\n Wspolrzedna y kursora: {y}");
            }
        }
    }
}
