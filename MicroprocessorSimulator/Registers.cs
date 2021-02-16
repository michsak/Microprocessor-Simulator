using System;
using System.Linq;
using System.Text;

namespace MicroprocessorSimulator
{
    public enum Registers
    {
        AX,     //Accumulator, used for arithmetic
        BX,     //Base, used as a pointer to data 
        CX,     //Counter, used in shift/rotate, string ops and loops
        DX      //Data, used in arithmetic and I/O
    }
}
