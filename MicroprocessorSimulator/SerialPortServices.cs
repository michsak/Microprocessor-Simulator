using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroprocessorSimulator
{
    class SerialPortServices
    {
        public SerialPortServices(short subprogram)
        {
            if(subprogram == 768)
            {
                string isOpen;
                string[] ports = SerialPort.GetPortNames();
                try
                {
                SerialPort port = new SerialPort(ports[0]);
                isOpen = (port.IsOpen) ? "OPEN" : "CLOSE";
                MessageBox.Show($"PORT is {isOpen}");

                }
                catch
                {
                    MessageBox.Show("NIE ZNALEZIONO PORTU SZEREGOWEGO");
                }
            }
        }
    }
}
