using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Linq;
using eaw.hardpointduplicator.core.definitions;
using eaw.hardpointduplicator.core.hardpointgenerator;

namespace eaw.hardpointduplicator.shared.service
{
    internal static class HardPointGeneratorService
    {
        internal static List<string> GenerateHpVariants(string hardPointCode, string replacementPattern, int hardpointCount, string hardpointBaseName, RotationDefinitions.RotationArc arcType)
        {
            List<string> hardpointList = new List<string>();
            for (int i = 1; i <= hardpointCount; i++)
            {
                string newHardPoint = HardpointGenerator.CreateHardpoint(hardPointCode, replacementPattern, i);
                newHardPoint = newHardPoint + "\n";
                XElement newHardpointXml = XDocument.Parse(newHardPoint).Root;
                Debug.Assert(newHardpointXml != null, nameof(newHardpointXml) + " != null");
                if (arcType != RotationDefinitions.RotationArc.RDefault)
                {
                    newHardpointXml.Attribute("Name").Value = hardpointBaseName + arcType + i.ToString("D2");
                }
                newHardpointXml.Element("Turret_Rotate_Extent_Degrees").Value = (int) arcType + ".0";
                hardpointList.Add(newHardpointXml.ToString());
#if DEBUG
                Console.WriteLine(newHardpointXml.ToString());
#endif
            }
            return hardpointList;
        }
        internal static List<string> GenerateHpVariants(string hardPointCode, string replacementPattern, int hardpointCount)
        {
            List<string> hardpointList = new List<string>();
            for (int i = 1; i <= hardpointCount; i++)
            {
                string newHardPoint = HardpointGenerator.CreateHardpoint(hardPointCode, replacementPattern, i);
                newHardPoint = newHardPoint + "\n";
                XElement newHardpointXml = XDocument.Parse(newHardPoint).Root;
                Debug.Assert(newHardpointXml != null, nameof(newHardpointXml) + " != null");
                hardpointList.Add(newHardpointXml.ToString());
#if DEBUG
                Console.WriteLine(newHardpointXml.ToString());
#endif
            }
            return hardpointList;
        }
    }
}
