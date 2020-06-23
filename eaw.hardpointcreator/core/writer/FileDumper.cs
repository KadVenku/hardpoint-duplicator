using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace eaw.hardpointduplicator.core.writer
{
    internal static class FileDumper
    {
        internal static void WriteToFile(IEnumerable<string> content)
        {
            string path = Path.Combine(Application.StartupPath, ".hp-dump");
            Directory.CreateDirectory(path);
            path = Path.Combine(path, DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss") + "-hp-dump.txt");
            using (StreamWriter file = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.ReadWrite), Encoding.UTF8))
            {
                foreach (string line in content)
                {
                    file.WriteLine(line);
                }
            }
        }
    }
}
