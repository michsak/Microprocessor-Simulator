using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroprocessorSimulator
{
    class TimeReader
    {
        public TimeReader(short subprogram)
        {
            if(subprogram == 0)
            {
                string todaysDate = DateTime.Now.ToString("HH:mm:ss: tt");
                Console.WriteLine(todaysDate);
            }
            
        }
    }
}
