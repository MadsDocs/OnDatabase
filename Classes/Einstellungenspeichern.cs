using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace Attach_Detach_DB.Classes
{
    class Einstellungenspeichern
    {
        public static string Speichern (string user, string passwort, string datenbank, string dns, string instance)
        {
            /*
                    Diese Klasse speichert die gegebene Daten in eine Datei
            */
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                
                    config.AppSettings.Settings.Add("Username", user);
                    config.AppSettings.Settings.Add("Passwort", passwort);
                    config.AppSettings.Settings.Add("Datenbank", datenbank);
                    config.AppSettings.Settings.Add("DNS", dns);
                    config.AppSettings.Settings.Add("Instanz", instance);
                    config.AppSettings.Settings.Add("sucess", "true");
                    config.Save(ConfigurationSaveMode.Full);
                    ConfigurationManager.RefreshSection("appSettings");

                    return "Einstellungen gespeichert!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string GetAppSettings (string key)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            return config.AppSettings.Settings[key].Value;
        }

        public static bool GetStatusAppSetting (string key)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string success = config.AppSettings.Settings[key].Value;

            if (success == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ResetAppSettings ()
        {
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Remove("Username");
                config.AppSettings.Settings.Remove("Passwort");
                config.AppSettings.Settings.Remove("Datenbank");
                config.AppSettings.Settings.Remove("DNS");
                config.AppSettings.Settings.Remove("Instanz");
                config.AppSettings.Settings.Remove("sucess");
                ConfigurationManager.RefreshSection("appSettings");
                
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
