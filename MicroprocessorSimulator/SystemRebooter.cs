using System;
using System.Diagnostics;

namespace MicroprocessorSimulator
{
    class SystemRebooter
    {
        public SystemRebooter()
        {
            Process.Start("shutdown","/r /t 0");
        }
    }
}
