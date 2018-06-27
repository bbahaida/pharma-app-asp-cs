using PharmaDomain.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaDomain.Service
{
    public class UserServiceImpl : IUserService
    {
        log4net.ILog logger = Log4NetHelper.GetLogger(typeof(UserServiceImpl));
        IUserDao UserDao;
        public UserServiceImpl(IUserDao udao)
        {
            UserDao = udao;
        }
        public User AddUser(User u, User user)
        {
            if(u != null)
            {
                if (UserDao.GetOneByLogin(u.Login) == null)
                {
                    User o = UserDao.AddUser(u);
                    if (o != null)
                    {
                        logger.Info(user.Login + " a ajouter l'utilisateur "+o.Login);
                        return o;
                    }

                }
            }
            return null;
        }

        public User DeleteUser(User del, User user)
        {
            if(del != null)
            {
                User u = UserDao.DeleteUser(del);
                if (u == null)
                {
                    logger.Info(user.Login + " a supprime l'utilisateur " + del.Login);
                    return null;
                }
                return del;
            }
            return del;
        }

        public User EditUser(User u, User user)
        {
            if (u != null)
            {
                if (UserDao.GetOneById(u.UserId) != null)
                {
                 
                    User o = UserDao.EditUser(u);
                    if (o != null)
                    {
                        logger.Info(user.Login + " a modifier l'utilisateur " + u.Login);
                        return o;
                    }

                }
            }
            return null;
        }

        public IEnumerable<User> GetAll()
        {
            return UserDao.GetAll();
        }

        public User GetOneById(int id)
        {
            if (id > 0)
                return UserDao.GetOneById(id);
            return null;
        }

        public User GetUserByAuth(string login, string passworrd)
        {
            if(!login.Equals("") && !passworrd.Equals(""))
            {
                return UserDao.GetUserByAuth(login,passworrd);
            }
            return null;
        }

        public User GetUserByLogin(string login)
        {
            if (!login.Equals(""))
                return UserDao.GetOneByLogin(login);
            return null;
        }

        public IEnumerable<User> GetUsersByName(string name)
        {
            return UserDao.GetUsersByName(name);
        }
    }
}
