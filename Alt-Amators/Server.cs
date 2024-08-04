using Alt_Amators.Common;
using AltV.Net;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;
using AltV.Net.Resources.Chat.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alt_Amators
{
    class Server : Resource
    {
        public override void OnStart()
        {
            AltVContext alt = new AltVContext();
            Alt.LogInfo("Server started!");
        }

        public override void OnStop()
        {
            Alt.LogInfo("Server stopped!");
        }

        public override IEntityFactory<IPlayer> GetPlayerFactory()
        {
            return new PlayerFactory();
        }
    }
}
