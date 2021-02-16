using System;
using System.Diagnostics;
using System.Text;

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
