using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroprocessorSimulator
{
    public class RegistersAdder
    {
        private int addressingType;
        private int instructionType;
        private int sourceType;
        private int destinationType;
        private int value;

        public RegistersAdder(int addressingType, int instructionType, int sourceType, int destinationType, int value)
        {
            this.addressingType = addressingType;
            this.instructionType = instructionType;
            this.sourceType = sourceType;
            this.destinationType = destinationType;
            this.value = value;
        }

        public int GetAddressingType()
        {
            return addressingType;
        }

        public int GetInstructionType()
        {
            return instructionType;
        }

        public int GetSourceType()
        {
            return sourceType;
        }

        public int GetDestinationType()
        {
            return destinationType;
        }

        public int GetValue()
        {
            return value;
        }
    }
}
