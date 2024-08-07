using Alt_Amators.Common;
using AltV.Net;
using AltV.Net.Resources.Chat.Api;

namespace Alt_Amators.Helper
{
    internal class Commands : IScript
    {
        [Command("coord")]
        public void PrintPlayerPosition(CustomPlayer player)
        {
            player.SendChatMessage(player.GetPosition().ToString());
        }
    }
}
