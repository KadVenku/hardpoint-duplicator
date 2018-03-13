using System.Collections.Generic;
using yvaw_hardpointcreator.core.writer;

namespace yvaw_hardpointcreator.shared.service
{
    internal static class FileWriterService
    {
        internal static void WriteToFile(IEnumerable<string> content)
        {
            FileDumper.WriteToFile(content);
        }
    }
}
