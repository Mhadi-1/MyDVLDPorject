
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLDPorject.genralClasess
{
    public  class ClsProjectSettings
    {
        public static void EventLogExption(string Message, EventLogEntryType entryType)
        {

            string SourceName = "MyDVLDPorject";
            if (!EventLog.SourceExists(SourceName))
            {
                EventLog.CreateEventSource(SourceName, "Application");

            }
            EventLog.WriteEntry(SourceName, Message, entryType);

        }

        private static string _KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";

        public static bool SaveToWinRegistry(string userName, string PassWord, bool Permissions)
        {
            try
            {
                Registry.SetValue(_KeyPath, "UserName", userName);
                Registry.SetValue(_KeyPath, "PassWord", PassWord);
                Registry.SetValue(_KeyPath, "Permissions", Permissions);
                return true;

            }
            catch (Exception Ex)
            {
                return false;
            }
        }
        public static string[] GetRegistryValue()
        {
            string[] DatValues = new string[3];

            try
            {
                DatValues[0] = Registry.GetValue(_KeyPath, "UserName", RegistryValueKind.String) as string;
                DatValues[1] = Registry.GetValue(_KeyPath, "PassWord", RegistryValueKind.String) as string;
                DatValues[2] = Registry.GetValue(_KeyPath, "Permissions", RegistryValueKind.String) as string;
            }
            catch (Exception Ex)
            {
                return null;
            }
            return DatValues;
        }

    }
}

