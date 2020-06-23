using System.Collections.Generic;
using eaw.hardpointduplicator.core.writer;

namespace eaw.hardpointduplicator.shared.service
{
    internal static class FileWriterService
    {
        internal static void WriteToFile(IEnumerable<string> content)
        {
            FileDumper.WriteToFile(content);
        }
    }
}
