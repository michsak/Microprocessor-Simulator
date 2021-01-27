using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroprocessorSimulator
{
    public enum CommandExecutingType
    {
        TOTAL,          //execute all commands at once
        STEP_BY_STEP    //execute each command step by step
    }
}
