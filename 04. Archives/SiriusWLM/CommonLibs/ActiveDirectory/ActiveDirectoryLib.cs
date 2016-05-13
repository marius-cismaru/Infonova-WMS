using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
using System.DirectoryServices;
using System.Security.Principal;

namespace Sirius.CommonLibs
{
    public class ActiveDirectoryLib
    {
        public static bool CheckIfUserIsMemberOfGroup(string Group)
        {
            StringCollection groupMembers = GetGroupMembers(Group);
            foreach (string strMember in groupMembers)
            {
                if (strMember == Environment.UserName)
                {
                    return true;
                }
            }
            return false;
        }

        public static StringCollection GetGroupMembers(string strGroup)
        {
            StringCollection groupMembers = new StringCollection();
            try
            {
                DirectoryEntry ent = new DirectoryEntry("LDAP://DC=DomainName,DC=com");
                DirectorySearcher srch = new DirectorySearcher("(CN=" + strGroup + ")");
                SearchResultCollection coll = srch.FindAll();
                foreach (SearchResult rs in coll)
                {
                    ResultPropertyCollection resultPropColl = rs.Properties;
                    foreach (Object memberColl in resultPropColl["member"])
                    {
                        DirectoryEntry gpMemberEntry = new DirectoryEntry("LDAP://" + memberColl);
                        System.DirectoryServices.PropertyCollection userProps = gpMemberEntry.Properties;
                        object obVal = userProps["sAMAccountName"].Value;
                        if (null != obVal)
                        {
                            groupMembers.Add(obVal.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return groupMembers;
        }

        public static string GetWindowsCurrentThreadUser()
        {
            string result = "";
            string user = WindowsIdentity.GetCurrent().Name;
            string[] strArray = user.Split('\\');
            if (strArray.Count() > 1)
            {
                result = strArray[1];
            }
            return result;
        }

        public static string GetWindowsCurrentThreadDomain()
        {
            string result = "";
            string user = WindowsIdentity.GetCurrent().Name;
            string[] strArray = user.Split('\\');
            if (strArray.Count() > 1)
            {
                result = strArray[0];
            }
            return result;
        }

        public static string GetWindowsLoggedUser()
        {
            return Environment.UserName;
        }

        public static string GetWindowsStationName()
        {
            return Environment.MachineName.ToUpper();
        }
    }
}
