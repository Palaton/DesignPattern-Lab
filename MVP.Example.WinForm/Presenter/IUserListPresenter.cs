using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVP.Example.WinForm.Model.Entity;

namespace MVP.Example.WinForm.Presenter
{
    public interface IUserListPresenter : IPresenter
    {
        void ShowUsers(List<User> users);

        void ShowUser(User user);
    }
}
