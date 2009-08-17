using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ysfo.Core.Loader
{
    public class AircraftCollection : List<Addons.Aircraft>
    {
        public const String DefaultLstPath = "aircraft/aircraft.lst";

        protected String _ysPath;
        protected String _lstPath;

        public String LstPath {
            get
            {
                return _lstPath;    
            }
            
            protected set
            {
                _lstPath = value;
            }
        }

        public AircraftCollection(String ysPath) : this(ysPath, null)
        {
        }

        public AircraftCollection(String ysPath, String lstPath)
        {
            _ysPath = ysPath;

            if (lstPath == null)
            {
                _lstPath = DefaultLstPath;
            }
            else
            {
                _lstPath = lstPath;
            }
        }

        #region Debug Methods
        #if DEBUG

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public String Debug_GetYsPath()
        {
            return _ysPath;
        }

        #endif
        #endregion
    }
}
