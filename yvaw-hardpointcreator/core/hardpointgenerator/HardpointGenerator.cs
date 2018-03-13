namespace yvaw_hardpointcreator.core.hardpointgenerator
{
    internal static class HardpointGenerator
    { 
        internal static string CreateHardpoint(string hardpointCode, string replacementPattern, int hardpointNumber)
        {
            return hardpointCode.Replace(replacementPattern, hardpointNumber.ToString("D2"));
        }
    }
}
