using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegateUser.Model;

namespace DelegateUser.IDao
{
    interface IUser
    {
        List<User> getAllUser();
        User AddUser(User user);
    }
}
