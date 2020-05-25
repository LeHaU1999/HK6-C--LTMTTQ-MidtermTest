using DelegateUser.IDao;
using DelegateUser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateUser.DaoImpl
{
    class UserImpl : IUser
    {
        LinQUserDataContext db;
        List<User> listUser;
        public User AddUser(User user)
        {
            db = new LinQUserDataContext();
            User users = new User();
            users = user;
            db.Users.InsertOnSubmit(users);
            db.SubmitChanges();
            return user;
        }

        public List<User> getAllUser()
        {
            db = new LinQUserDataContext();
            var us = from x in db.Users select x;
            listUser = us.ToList();
            return listUser;
        }
    }
}
