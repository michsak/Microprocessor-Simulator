using System;
using System.Collections.Generic;
using System.Text;

namespace MicroprocessorSimulator
{
    class DestinationTypeContainer
    {
        public Dictionary<int, string> destinationData = new Dictionary<int, string>();

        public DestinationTypeContainer()
        {
            destinationData.Add(0, Enum.GetName(typeof(Registers), Registers.AX));
            destinationData.Add(1, Enum.GetName(typeof(Registers), Registers.BX));
            destinationData.Add(2, Enum.GetName(typeof(Registers), Registers.CX));
            destinationData.Add(3, Enum.GetName(typeof(Registers), Registers.DX));
        }
    }
}
