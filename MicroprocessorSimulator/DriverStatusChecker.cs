using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroprocessorSimulator
{
    class DriverStatusChecker
    {
        public DriverStatusChecker(short subprogram)
        {
            StringBuilder stringBuilder = new StringBuilder(1500);

            if (subprogram == 256)
            {
                DriveInfo[] drives = DriveInfo.GetDrives();
                foreach (DriveInfo drive in drives)
                {
                    if (drive.IsReady)
                    {
                        stringBuilder.Append($"Nazwa dysku: {drive.Name}  Rozmiar dysku: {drive.TotalSize} B\n");
                    }
                }

                

                MessageBox.Show(stringBuilder.ToString());

            }
        }
    }
}
