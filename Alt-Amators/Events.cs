using Alt_Amators.Service;
using AltV.Net;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;
using AltV.Net.Resources.Chat.Api;

namespace Alt_Amators
{
    public class Events : IScript
    {
        private readonly AuthService _authService;
        
        public Events()
        {
            _authService = new AuthService();
        }

        [ScriptEvent(ScriptEventType.PlayerConnect)]
        public void OnPlayerConnect(IPlayer player, string reason)
        {
            player.Emit("Event.Auth");
            player.SendChatMessage("Welcome!!!");
            player.Spawn(new AltV.Net.Data.Position(-425, 1123, 325), 0);
            player.Model = (uint)PedModel.FreemodeMale01;
        }

        [ClientEvent("Event.Login")]
        public void OnPlayerLogin(Player player, string login, string password)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                player.Emit("SendErrorMessage", "Invalid username or password");

                return;
            }

            var result = _authService.GetAuthorizedUser(login, password);

            if (!string.IsNullOrEmpty(result.ErrorDescription))
            {
                player.Emit("SendErrorMessage", result.ErrorDescription);

                return;
            }
            var user = result.Content;

            player.Spawn(new AltV.Net.Data.Position(user.X, user.Y, user.Z), 0);
            player.Emit("CloseLoginCEF");
        }
    }
}
