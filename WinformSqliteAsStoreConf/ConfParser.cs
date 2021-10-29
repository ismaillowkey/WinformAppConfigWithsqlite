using System.Windows.Forms;

namespace WinformSqliteAsStoreConf
{
    public static class ConfParser
    {
        private static SQLiteDatabase appSettingsDB = new SQLiteDatabase();

        static ConfParser()
        {
            //bool rs = appSettingsDB.Create(Path.ChangeExtension(Application.ExecutablePath, "db"), false, null, true);
            bool rs = appSettingsDB.Create("dbsettings.db", false, null, true);
            if (!rs)
            {
                MessageBox.Show(appSettingsDB.LastError);
                return;
            }
        }

        /// <summary>
        /// Read Key (string)
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string ReadKey(string section, string key)
        {
            var res = appSettingsDB.GetConfig(section + "_" + key);
            return res;
        }

        /// <summary>
        /// Read Key (int)
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static int ReadKey(string section, int key)
        {
            var res = appSettingsDB.GetIntConfig(section + "_" + key);
            return res;
        }

        /// <summary>
        /// Read Key (bool)
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool ReadKey(string section, bool key)
        {
            var res = appSettingsDB.GetBoolConfig(section + "_" + key);
            return res;
        }

        /// <summary>
        /// Write key (string)
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void WriteKey(string section, string key, string value)
        {
            appSettingsDB.SetConfig(section + "_" + key, value);
        }

        /// <summary>
        /// Write Key (int)
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void WriteKey(string section, string key, int value)
        {
            appSettingsDB.SetConfig(section + "_" + key, value);
        }

        /// <summary>
        /// Write Key (bool)
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void WriteKey(string section, string key, bool value)
        {
            appSettingsDB.SetConfig(section + "_" + key, value);
        }
    }

}
