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
        private Core.Ysfo _ysfo;
        
        public String Path {
            get
            {
                return _ysfo.Path;
            }
            set
            {
                _ysfo.Path = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Path"));
                }
            }
        }

        public YsfoWrapper()
        {
            _ysfo = new Core.Ysfo();

            Path = ConfigurationManager.AppSettings["YsPath"] ?? "";
        }

        public void Setup()
        {
            if (!_ysfo.IsPathValid())
            {
                throw new YsfoPathInvalidException();
            }
        }

        public void Dispose()
        {
            // cleanup
            _ysfo.Dispose();
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

        // exceptions
        public class YsfoPathInvalidException : Exception
        {
            public YsfoPathInvalidException() : base()
            {
                
            }

            public YsfoPathInvalidException(String message) : base(message)
            {

            }
        }
    }
}
