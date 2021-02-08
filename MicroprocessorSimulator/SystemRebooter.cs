using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
