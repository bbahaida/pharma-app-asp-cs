﻿using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaDomain.Dao
{
    public class UserDoaImpl : IUserDao
    {
        PharmaEntities context = new PharmaEntities();
        ILog logger = Log4NetHelper.GetLogger(typeof(UserDoaImpl));
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
            return context.Users.ToList();
        }

        public User GetOneById(int id)
        {
            return context.Users.Where(e => e.UserId == id).Single();
        }

        public User GetOneByLogin(string login)
        {
            return context.Users.Where(e => e.Login.Equals(login)).Single();
        }

        public User GetUserByAuth(string login, string passworrd)
        {
            return context.Users.Where(e => e.Login.Equals(login) && e.Password.Equals(passworrd)).Single();
        }

        public IEnumerable<User> GetUsersByName(string name)
        {
            return context.Users.Where(e=>e.Name.Contains(name));
        }
    }
}
