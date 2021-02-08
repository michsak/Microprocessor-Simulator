using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroprocessorSimulator
{
    class PrinterServices
    {
        public PrinterServices(short subprogram)
        {
            List<string> names = new List<string>();
            List<string> statuses = new List<string>();
            List<string> isDefaults = new List<string>();
            List<string> isNetworkPrinters = new List<string>();

            StringBuilder stringBuilder = new StringBuilder(15000);

            if (subprogram == 512)
            {
                var printerQuery = new ManagementObjectSearcher("SELECT * from Win32_Printer");
                foreach (var printer in printerQuery.Get())
                {
                    var name = printer.GetPropertyValue("Name");
                    var status = printer.GetPropertyValue("Status");
                    var isDefault = printer.GetPropertyValue("Default");
                    var isNetworkPrinter = printer.GetPropertyValue("Network");

                    stringBuilder.Append($"{name} (Status: {status}, Default: {isDefault}, Network: {isNetworkPrinter}\n");
                }

                MessageBox.Show(stringBuilder.ToString());
            }
        }
    }
}
