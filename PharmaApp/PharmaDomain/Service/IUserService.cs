using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaDomain.Service
{
    public interface IUserService
    {
        User AddUser(User u, User user);
        User DeleteUser(User del, User user);
        User EditUser(User u, User user);
        IEnumerable<User> GetAll();
        IEnumerable<User> GetUsersByName(string name);
        User GetOneById(int id);
        User GetUserByLogin(string login);
        User GetUserByAuth(string login, string passworrd);
    }
}
