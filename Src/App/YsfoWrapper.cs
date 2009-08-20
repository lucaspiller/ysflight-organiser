using System;
using System.ComponentModel;
using System.Configuration;
using Ysfo.Core.Collections;

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

        // collections
        public AircraftCollection LoadedAircraft { get; protected set; }
        public AircraftCollection UnloadedAircraft { get; protected set; }

        public GroundCollection LoadedGround { get; protected set; }
        public GroundCollection UnloadedGround { get; protected set; }

        public SceneryCollection LoadedScenery { get; protected set; }
        public SceneryCollection UnloadedScenery { get; protected set; }

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

            // aircraft
            LoadedAircraft = _ysfo.GetAircraftCollection();

            String aircraftPath = System.IO.Path.Combine("aircraft", "unloaded_aircraft.lst");
            UnloadedAircraft = _ysfo.GetAircraftCollection(aircraftPath);

            // ground
            LoadedGround = _ysfo.GetGroundCollection();

            String groundPath = System.IO.Path.Combine("ground", "unloaded_ground.lst");
            UnloadedGround = _ysfo.GetGroundCollection(groundPath);

            // scenery
            LoadedScenery = _ysfo.GetSceneryCollection();

            String sceneryPath = System.IO.Path.Combine("scenery", "unloaded_scenery.lst");
            UnloadedScenery = _ysfo.GetSceneryCollection(sceneryPath);
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
