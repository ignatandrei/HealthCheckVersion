using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TestHealthCheckVersion")]

namespace HCVersion
{
    internal class HCV
    {
        static Version versionEntry;
        static Version versionHCV;
        static HCV()
        {
            var ass = Assembly.GetEntryAssembly();
            versionEntry = ass.GetName().Version;
            versionHCV = Assembly.GetExecutingAssembly().GetName().Version;

        }
        public string GetStartingAssemblyInformation()
        {
            return versionEntry.ToString();
        }
        public string GetHCVAssemblyInformation()
        {
            return versionHCV.ToString();
        }
    }
}
