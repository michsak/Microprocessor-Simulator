using System;
using System.Collections.Generic;

namespace MicroprocessorSimulator
{
    class SourceTypeContainer
    {
        public Dictionary<int, string> sourcesData = new Dictionary<int, string>();

        public SourceTypeContainer()
        {
            sourcesData.Add(0, Enum.GetName(typeof(Registers), Registers.AX));
            sourcesData.Add(1, Enum.GetName(typeof(Registers), Registers.BX));
            sourcesData.Add(2, Enum.GetName(typeof(Registers), Registers.CX));
            sourcesData.Add(3, Enum.GetName(typeof(Registers), Registers.DX));
        }
    }
}
