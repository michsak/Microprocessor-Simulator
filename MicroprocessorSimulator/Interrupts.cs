using System;
using System.Text;

namespace MicroprocessorSimulator
{
    //external interrupts
    //http://www.ablmcc.edu.hk/~scy/CIT/8086_bios_and_dos_interrupts.htm
    //https://en.wikipedia.org/wiki/BIOS_interrupt_call

    public enum Interrupts
    {
        NONE,
        INT10,
        INT13,
        INT14,
        INT16,
        INT17,
        INT19,
        INT1A,
        INT20
    }
}
