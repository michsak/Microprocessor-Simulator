using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroprocessorSimulator
{
    class TimeReader
    {
        public TimeReader(short subprogram)
        {
            if(subprogram == 0)
            {
                MessageBox.Show($"RTC: {DateTime.Now.ToString()}");
            }
            if(subprogram == 512)
            {
                MessageBox.Show($"Obecna godzina: {DateTime.Now.ToString("HH:mm:ss: tt")}");
            }

            if(subprogram == 1024)
            {
                MessageBox.Show($"Dzisiejsza data: {DateTime.Now.ToString("M/d/yyyy")}");
            }
            
        }
    }
}
