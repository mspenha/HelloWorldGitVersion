using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;

namespace HelloWorldGitVersion.Models
{
    public class VersionControll
    {

        public string VersionNumber { get; set; }

        Version version = Assembly.GetEntryAssembly().GetName().Version;
        public string GetAssemblyVersion => version.Major + "." + version.Minor + "." + version.Build;
        public VersionControll()
        {

            VersionNumber = version.Major + "." + version.Minor + "." + version.Build;
        }
    }
}
