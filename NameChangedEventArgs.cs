using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV_Burgers.Events
{
    class NameChangedEventArgs : EventArgs
    {
        public string OldName { get; set; }
        public string NewName { get; set; }

    }
}
