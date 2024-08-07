using Alt_Amators.Common;
using Alt_Amators.Entity;
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
        public void OnPlayerConnect(CustomPlayer player, string reason)
        {
            player.Emit("Event.ChangeActiveView", "Auth");
            player.Emit("Event.Auth");
            player.SendChatMessage("Welcome!!!");
        }

        [ClientEvent("Event.Register")]
        public void OnPlayerRegistration(CustomPlayer player, string username, string password, string email)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                player.Emit("SendErrorMessage", "Validation failed!");

                return;
            }

            if (!_authService.IsUserExist(username))
            {
                player.Emit("SendErrorMessage", "User with same login already exist");

                return;
            }

            var user = new User()
            {
                Login = username,
                Password = password,
                Email = email,
                Money = 5000,
                SocialClubName = player.SocialClubName,
                X = DefaultSettings.SPAWN_POSITION.X, 
                Y = DefaultSettings.SPAWN_POSITION.Y,
                Z = DefaultSettings.SPAWN_POSITION.Z,
                RegistryDate = DateTime.UtcNow,
                LastVisitDate = DateTime.UtcNow,
                IsDeleted = false
            };

            _authService.AddUser(user);
            _authService.SaveChangesAsync();

            player.Spawn(DefaultSettings.SPAWN_POSITION, 0);
            player.Model = (uint)PedModel.FreemodeMale01;
            player.Emit("CloseLoginCEF");
        }

        [ClientEvent("Event.Login")]
        public void OnPlayerLogin(CustomPlayer player, string login, string password)
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
