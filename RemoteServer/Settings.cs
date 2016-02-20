using System;
using System.Windows.Forms;
using System.Drawing.Imaging ;
using System.Text;
using Microsoft.Win32;

namespace RemoteServer
{
   public class Settings
    {
        public static bool FirstTime = true;
        public static string MainProgramName = "TeamViewer Jugad";
        public static string Pass = "ghusneDe";
        public static FrmService FormService = null;
        public static int Port = 4000;
        public static bool Debug = false;
        public static int ScreenServerX = 1366;
        public static int ScreenServerY = 768;
        
        public static void LoadSettings()
        {
            Settings.FirstTime = bool.Parse(LoadSetting("FirstTime","true"));
            Settings.ScreenServerX = Screen.PrimaryScreen.Bounds.Width + 5;
            Settings.ScreenServerY = Screen.PrimaryScreen.Bounds.Height + 5;
            Settings.Port = int.Parse(LoadSetting("Port", "4000"));
            Settings.Pass = LoadSetting("id", "ghusneDe");
            Settings.ScreenServerX = int.Parse(LoadSetting("ScreenServerX", Settings.ScreenServerX.ToString()));
            Settings.ScreenServerY = int.Parse(LoadSetting("ScreenServerY", Settings.ScreenServerY.ToString()));
        }

        public static void SaveSettings()
        {
            SaveSetting("ScreenServerX", Settings.ScreenServerX.ToString());
            SaveSetting("ScreenServerY", Settings.ScreenServerY.ToString());
            SaveSetting("Port", Settings.Port.ToString());
            SaveSetting("id", Settings.Pass);
            SaveSetting("FirstTime", Settings.FirstTime.ToString());
        }


        public static void SaveSetting(string Name, string Value)
        {
            try
            {
                RegistryKey Root = Registry.CurrentUser.CreateSubKey(MainProgramName);
                Root.SetValue(Name, Value);
            }
            catch { ;}
        }

        public static string LoadSetting(string Name, string Default)
        {
            RegistryKey Root = Registry.CurrentUser.CreateSubKey(MainProgramName);
            try
            {
                return Root.GetValue(Name).ToString();
            }
            catch
            {
                SaveSetting(Name, Default);
                return Default;
            }
        }
    }
}
