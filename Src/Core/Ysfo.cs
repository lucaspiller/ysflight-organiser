using System;

namespace Ysfo.Core
{
    public class Ysfo : IDisposable
    {
        public String Path { get; set; }

        public void Dispose()
        {
        }

        public AircraftCollection GetAircraftCollection()
        {
            return GetAircraftCollection(null);
        }

        public AircraftCollection GetAircraftCollection(String lstPath)
        {
            AircraftCollection collection = new AircraftCollection(Path, lstPath);
            collection.Load();

            return collection;
        }
    }
}
