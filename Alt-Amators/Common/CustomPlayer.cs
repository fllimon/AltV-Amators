using AltV.Net;
using AltV.Net.Elements.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alt_Amators.Common
{
    public class CustomPlayer : Player
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public long Money { get; set; }
        public byte AdminLevel { get; set; }

        public CustomPlayer(ICore core, IntPtr nativePointer, uint id) 
            : base(core, nativePointer, id)
        {
        }
    }
}
