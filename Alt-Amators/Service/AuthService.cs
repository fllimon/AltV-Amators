using Alt_Amators.Common;
using Alt_Amators.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alt_Amators.Service
{
    public class AuthService
    {
        private readonly AltVContext _context;

        public AuthService()
        {
            _context = new AltVContext();
        }

        public Result<User> GetAuthorizedUser(string login, string password)
        {
            var user = _context.Users
                .Where(x => x.Login == login)
                .FirstOrDefault();

            if (user is null)
            {
                return new Result<User>(null, "User with this login doesn't exists");
            }

            if (!user.Password.Equals(password))
            {
                return new Result<User>(null, "Incorrect username or password");
            }

            return new Result<User>(user, string.Empty);
        }

        private void AddUser(User user)
        {
            _context.Users.Add(user);
        }

        private void SaveChangesAsync()
        {
            _context.SaveChanges();
        }

        private bool IsExist(string login)
        {
            return _context.Users.FirstOrDefault(x => x.Login == login) == null;
        }
    }
}
