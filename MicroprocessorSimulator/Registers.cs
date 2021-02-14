using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MicroprocessorSimulator
{
    public enum Registers
    {
        AX,     //Accumulator, used for Arithmetic
        BX,     //Base, used as a pointer to data 
        CX,     //Counter, used in shift/rotate, string ops and loops
        DX      //Data, used in arithmetic and I/O
    }
}
