using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ysfo.Core;
using Ysfo.Core.Collections;

namespace Ysfo.Samples.Unloader
{
    class YsfoWrapper
    {
        Ysfo.Core.Ysfo _ysfo;
        public AircraftCollection LoadedAircraft { get; protected set; }
        public AircraftCollection UnloadedAircraft { get; protected set; }

        public void Setup(String ysPath)
        {
            _ysfo = new Ysfo.Core.Ysfo {Path = ysPath};

            // load collections
            LoadedAircraft = _ysfo.GetAircraftCollection();
            UnloadedAircraft = _ysfo.GetAircraftCollection("aircraft/unloaded_aircraft.lst");
        }

        public bool Loaded()
        {
            return !(_ysfo == null);
        }

        public void Cleanup(bool save)
        {
            if (save)
            {
                if (LoadedAircraft != null)
                {
                    LoadedAircraft.Save();
                    
                }

                if (UnloadedAircraft != null)
                {
                    UnloadedAircraft.Save();
                }
            }

            LoadedAircraft = null;
            UnloadedAircraft = null;
            _ysfo = null;
        }

        public void UnloadAircraft(AircraftAddon aircraft)
        {
            if (LoadedAircraft.Remove(aircraft))
            {
                // only add if the aircraft was removed from loaded list
                UnloadedAircraft.Add(aircraft);
            }
        }

        public void LoadAircraft(AircraftAddon aircraft)
        {
            if (UnloadedAircraft.Remove(aircraft))
            {
                // only add if the aircraft was removed from loaded list
                LoadedAircraft.Add(aircraft);
            }
        }

        public void MoveUp(AircraftAddon aircraft)
        {
            if (LoadedAircraft.Contains(aircraft))
            {
                int index = LoadedAircraft.IndexOf(aircraft);

                if (index > 0)
                {
                    LoadedAircraft.Swap(index, index - 1);
                }
            }

            if (UnloadedAircraft.Contains(aircraft))
            {
                int index = UnloadedAircraft.IndexOf(aircraft);

                if (index > 0)
                {
                    UnloadedAircraft.Swap(index, index - 1);
                }
            }
        }

        public void MoveDown(AircraftAddon aircraft)
        {
            if (LoadedAircraft.Contains(aircraft))
            {
                int index = LoadedAircraft.IndexOf(aircraft);

                if (index < LoadedAircraft.Count)
                {
                    LoadedAircraft.Swap(index, index + 1);
                }
            }

            if (UnloadedAircraft.Contains(aircraft))
            {
                int index = UnloadedAircraft.IndexOf(aircraft);

                if (index < UnloadedAircraft.Count)
                {
                    UnloadedAircraft.Swap(index, index + 1);
                }
            }
        }
    }
}
