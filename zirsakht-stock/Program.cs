using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;

namespace zirsakht_stock
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// llllll
        /// </summary>
        [STAThread]
        static void Main()
        {
          //  EncryptConfigSection("connectionStrings");
            Application.EnableVisualStyles();
            
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
            

        }
        static void EncryptConfigSection(string sectionKey)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConfigurationSection section = config.GetSection(sectionKey);
            if (section != null)
            {
                if (!section.SectionInformation.IsProtected)
                {
                    if (!section.ElementInformation.IsLocked)
                    {
                        section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                        section.SectionInformation.ForceSave = true;
                        config.Save(ConfigurationSaveMode.Full);
                    }
                }
            }
        }
    }
}
