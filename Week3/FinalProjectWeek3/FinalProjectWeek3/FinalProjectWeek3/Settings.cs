using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectWeek3
{
    public static class Settings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        private const String ContactListKey = "contactListData";
        private static readonly String ContactListDefaultValue = String.Empty;

        public static string ContactList
        {
            get { return AppSettings.GetValueOrDefault<String>(ContactListKey, ContactListDefaultValue); }
            set { AppSettings.AddOrUpdateValue<String>(ContactListKey, value); }
        }
    }
}
