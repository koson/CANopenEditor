using libEDSsharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEditor
{
    public class UpdateODViewEventArgs : EventArgs
    {
        public EDSsharp EDS { get; set; }

        public UpdateODViewEventArgs(EDSsharp eds)
        {
            EDS = eds;
        }
    }
}
