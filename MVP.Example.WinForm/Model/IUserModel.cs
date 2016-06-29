using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVP.Example.WinForm.Model.Entity;

namespace MVP.Example.WinForm.Model
{
    public interface IUserModel
    {
        void AddItem(User user);

        List<User> GetUsers();

        User SelectUser(string userName);
    }
}
