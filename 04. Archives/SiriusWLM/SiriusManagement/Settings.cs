using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sirius.SiriusManagement
{
    public static class Settings
    {
        public static string ProgramName = "SiriusManagement";
        public static string ProgramDescription = "Helvetica Distribution";
        public static int ProgramVersionMajor = 1;
        public static int ProgramVersionMinor = 0;
        public static string ProgramUpdateDate = "01.11.2015";
        public static string[] ProgramUpdateLog = {
        };

        public static string GetProgramVersion()
        {
            return ProgramVersionMajor.ToString() + "." + ProgramVersionMinor.ToString();
        }

        public static string GetProgramNameFull()
        {
            return ProgramName + " v" + GetProgramVersion();
        }
    }
}
