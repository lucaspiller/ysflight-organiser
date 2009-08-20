using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Configuration;

namespace Ysfo.App
{
    public class YsfoWrapper : IDisposable, INotifyPropertyChanged
    {
        private String _path;
        public String Path {
            get
            {
                return _path;    
            }
            set
            {
                _path = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Path"));
                }
            }
        }

        public YsfoWrapper()
        {
            Path = ConfigurationManager.AppSettings["YsPath"] ?? "";
        }

        public void Dispose()
        {
            WriteAppConfig();
        }

        private void WriteAppConfig()
        {
            // open
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            Console.WriteLine(config.FilePath);

            // write settings
            config.AppSettings.Settings.Clear();
            config.AppSettings.Settings.Add("YsPath", Path);

            // save
            config.Save(ConfigurationSaveMode.Modified);
        }

        // events
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
