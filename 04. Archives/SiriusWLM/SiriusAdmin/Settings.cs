using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sirius.SiriusAdmin
{
    public static class Settings
    {
        public static string ProgramName = "SiriusAdmin";
        public static string ProgramDescription = "Administrare";
        public static int ProgramVersionMajor = 1;
        public static int ProgramVersionMinor = 1;
        public static string ProgramUpdateDate = "09.09.2014";
        public static string[] ProgramUpdateLog = {
            "2013-03-08 - Creare structura baze de date"
        };

        public static string GetVersion()
        {
            return ProgramVersionMajor.ToString() + "." + ProgramVersionMinor.ToString();
        }

        public static string GetProgramNameFull()
        {
            return ProgramName + " v" + GetVersion();
        }
    }
}
