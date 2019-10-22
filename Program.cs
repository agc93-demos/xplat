using System;
using System.IO;
using System.Linq;

namespace xplat
{
    class Program
    {
        static void Main(string[] args)
        {
            var allDrives = DriveInfo.GetDrives().Where(d => d.DriveType == DriveType.Fixed);
            // var allDrives = DriveInfo.GetDrives();
            foreach (var drive in allDrives)
            {
                Console.WriteLine($"{drive.Name}: {drive.DriveFormat} ({drive.DriveType})");
            }
        }
    }
}
