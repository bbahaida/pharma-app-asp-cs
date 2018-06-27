using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaDomain.Dao
{
    public interface IUserDao
    {
        User AddUser(User u);
        User DeleteUser(User del);
        User EditUser(User u);
        IEnumerable<User> GetAll();
        IEnumerable<User> GetUsersByName(string name);
        User GetOneById(int id);
        User GetOneByLogin(string login);
        User GetUserByAuth(string login, string passworrd);
    }
}
