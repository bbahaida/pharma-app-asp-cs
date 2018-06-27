using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaDomain.Dao
{
    public class UserDaoImpl : IUserDao
    {
        PharmaEntities context = new PharmaEntities();
        ILog logger = Log4NetHelper.GetLogger(typeof(UserDaoImpl));
        public User AddUser(User u)
        {
            try
            {
                context.Users.Add(u);
                context.SaveChanges();
                return u;

            } catch(Exception e)
            {
                logger.Error(e.Message);
                return null;
            }
        }

        public User DeleteUser(User del)
        {
            try {
                context.Users.Remove(del);
                context.SaveChanges();
                return null;

            } catch(Exception e)
            {
                logger.Error(e.Message);
                return del;
            }
        }

        public User EditUser(User u)
        {
            try
            {
                context.Users.Attach(u);
                context.Entry(u).State = System.Data.Entity.EntityState.Modified;

                context.SaveChanges();
                return u;

            }
            catch (Exception e)
            {
                logger.Error(e.Message);
                return null;
            }
        }

        public IEnumerable<User> GetAll()
        {
            return context.Users;
        }

        public User GetOneById(int id)
        {
            try
            {
                return context.Users.FirstOrDefault(e => e.UserId == id);
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
                return null;
            }
            
        }

        public User GetOneByLogin(string login)
        {
            try
            {
                return context.Users.FirstOrDefault(e => e.Login.ToUpper().Equals(login.ToUpper()));
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
                return null;
            }
            
        }

        public User GetUserByAuth(string login, string passworrd)
        {
            try
            {
                return context.Users.FirstOrDefault(e => e.Login.Equals(login) && e.Password.Equals(passworrd));
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
                return null;
            }
            
        }

        public IEnumerable<User> GetUsersByName(string name)
        {
            return context.Users.Where(e=>e.Name.ToUpper().StartsWith(name.ToUpper()));
        }
    }
}
